﻿using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Borelli_DatabaseForm {
    public partial class Form1 : Form {
        private MySqlConnection _sqlConn;

        private MySqlConnection SqlConnection {
            get {
                if (_sqlConn == null) {
                    try {
                        _sqlConn = new MySqlConnection(GetDatabaseConnectionRow(filename));
                    } catch (Exception e) {
                        MessageBox.Show(e.Message);
                    }
                }

                return _sqlConn;
            }
        }

        public enum eTabPages {
            Dipartimenti,
            Impiegati,
            Progetti,
            Partecipazioni,
        }

        private readonly DataGridView[] gridsView;

        readonly string filename;
        DataGridViewRow oldRow = null;
        int oldRowIndex = -1;

        public Form1() {
            InitializeComponent();

            filename = "dbinfo";
            gridsView = new DataGridView[] { dataGridViewDipartimenti, dataGridViewImpiegati, dataGridViewProgetti, dataGridViewPartecipazioni };

            for (int i = 0; i < gridsView.Length; i++) {
                gridsView[i].CellBeginEdit += gridsView_CellBeginEdit;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }


        /* TAB 1*/
        private void bFiltraInDipartimenti_Click(object sender, EventArgs e) {
            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE dipartimenti.sede LIKE '{tbNomeCittaInDipartimenti.Text}%' AND impiegati.cognome LIKE '{tbCognResponsInDipartimenti.Text}%'";
            LoadDataOnSelectedTab(q);
        }

        private void bResetIndipartimenti_Click(object sender, EventArgs e) {
            tbCognResponsInDipartimenti.Text = tbNomeCittaInDipartimenti.Text = String.Empty;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void bAggiungiInDipartimenti_Click(object sender, EventArgs e) {
            if (!CheckIfValidStrings(tbInsCodiceInDipartimenti.Text, tbInsNomeDipartInDipartimenti.Text, tbInssedeInDipartimenti.Text)) {
                MessageBox.Show("Inserire dei dati validi");
                return;
            }

            string q = $"INSERT INTO dipartimenti (codice, nome, sede, id_direttore) VALUES ('{tbInsCodiceInDipartimenti.Text.ToUpper()}', '{tbInsNomeDipartInDipartimenti.Text}', '{tbInssedeInDipartimenti.Text}', '{cbInsCognRespoInDipartimenti.SelectedValue}');";
            ExecQuery(q);

            ResetInsertFieldInDipartimenti();
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void dataGridViewDipartimenti_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var newRow = dataGridViewDipartimenti.Rows[oldRowIndex];

            if (newRow.Equals(oldRow)) {
                return;
            }

            string q = $"UPDATE dipartimenti SET codice = '{newRow.Cells[0].Value}', nome = '{newRow.Cells[1].Value}', sede = '{newRow.Cells[2].Value}', id_direttore = '{newRow.Cells[3].Value}' WHERE dipartimenti.codice = '{oldRow.Cells[0].Value}'";
            ExecQuery(q);
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));

        }

        private void ResetInsertFieldInDipartimenti() {
            tbInsCodiceInDipartimenti.Text = tbInsNomeDipartInDipartimenti.Text = tbInssedeInDipartimenti.Text = String.Empty;
            cbInsCognRespoInDipartimenti.SelectedIndex = 0;
        }
        /*FINE TAB 1*/



        /*TAB 2*/
        private void bFiltraInImpiegati_Click(object sender, EventArgs e) {
            string res = CheckIfValidOperatorAndNumber(cbSegnoStipendioInImpiegati, mtbStipendioInImpiegati);
            if (res != String.Empty) {
                MessageBox.Show(res);
                return;
            }

            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE impiegati.cognome LIKE '{tbCognomeInImpiegati.Text}%' AND dipartimenti.nome LIKE '{cbNomeDipartInImpiegati.Text}%'";

            if (!String.IsNullOrWhiteSpace(cbSegnoStipendioInImpiegati.Text)) { //ora posso permettermi questo if in quanto sono sicuro che i dati siano validi
                q += $" AND impiegati.stipendio {cbSegnoStipendioInImpiegati.Text} {mtbStipendioInImpiegati.Text}";
            }

            LoadDataOnSelectedTab(q);
        }

        private void bResetInImpiegati_Click(object sender, EventArgs e) {
            tbCognomeInImpiegati.Text = mtbStipendioInImpiegati.Text = cbNomeDipartInImpiegati.Text = "";
            cbSegnoStipendioInImpiegati.SelectedIndex = 0;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void bAggiungiRecInImpiegati_Click(object sender, EventArgs e) {
            if (!CheckIfValidStrings(tbInsMatricolaInImpiegati.Text, tbInsCognomeInImpiegati.Text, mtbInsStipendioInImpiegati.Text)) {
                MessageBox.Show("Inserire dei dati validi");
                return;
            }

            string q = $"INSERT INTO impiegati (matricola, cognome, stipendio, id_dipartimento) VALUES ('{tbInsMatricolaInImpiegati.Text}', '{tbInsCognomeInImpiegati.Text}', '{mtbInsStipendioInImpiegati.Text}', '{cbInsNomeDipartInImpiegati.SelectedValue}');";
            ExecQuery(q);

            ResetInsertFieldInImpiegati();
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void dataGridViewImpiegati_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var newRow = dataGridViewImpiegati.Rows[oldRowIndex];

            if (newRow.Equals(oldRow)) {
                return;
            }

            string q = $"UPDATE impiegati SET matricola = '{newRow.Cells[0].Value}', cognome = '{newRow.Cells[1].Value}', stipendio = '{newRow.Cells[2].Value}', id_dipartimento = '{newRow.Cells[3].Value}' WHERE impiegati.matricola = '{oldRow.Cells[0].Value}'";
            ExecQuery(q);
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void ResetInsertFieldInImpiegati() {
            tbInsMatricolaInImpiegati.Text = tbInsCognomeInImpiegati.Text = mtbInsStipendioInImpiegati.Text = String.Empty;
            cbInsNomeDipartInImpiegati.SelectedIndex = 0;
        }
        /*FINE TAB 2*/



        /*TAB 3*/
        private void bFiltraInPartecipazioni_Click(object sender, EventArgs e) {
            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE progetti.nome LIKE '{tbNomeProgInPartecipazioni.Text}%' AND impiegati.cognome LIKE '{tbCognomeInPartecipazioni.Text}%'";
            LoadDataOnSelectedTab(q);
        }

        private void bResetInPartecipazioni_Click(object sender, EventArgs e) {
            tbNomeProgInPartecipazioni.Text = tbCognomeInPartecipazioni.Text = String.Empty;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void bAggiungiRecInProgetti_Click(object sender, EventArgs e) {
            if (!CheckIfValidStrings(tbInsSiglaInProgetti.Text, tbInsNomeInProgetti.Text, mtbInsBilancioInProgetti.Text)) {
                MessageBox.Show("Inserire dei dati validi");
                return;
            }

            string q = $"INSERT INTO progetti (sigla, nome, bilancio, id_responsabile) VALUES ('{tbInsSiglaInProgetti.Text}', '{tbInsNomeInProgetti.Text}', '{mtbInsBilancioInProgetti.Text}', '{cbInsCognResponsInProgetti.SelectedValue}');";
            ExecQuery(q);

            ResetInsertFieldInProgetti();
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void dataGridViewProgetti_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var newRow = dataGridViewProgetti.Rows[oldRowIndex];

            if (newRow.Equals(oldRow)) {
                return;
            }

            string q = $"UPDATE progetti SET sigla = '{newRow.Cells[0].Value}', nome = '{newRow.Cells[1].Value}', bilancio = '{newRow.Cells[2].Value}', id_responsabile = '{newRow.Cells[3].Value}' WHERE progetti.sigla = '{oldRow.Cells[0].Value}'";
            ExecQuery(q);
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void ResetInsertFieldInProgetti() {
            tbInsSiglaInProgetti.Text = tbInsNomeInProgetti.Text = mtbInsBilancioInProgetti.Text = String.Empty;
            cbInsCognResponsInProgetti.SelectedIndex = 0;
        }
        /*FINE TAB 3*/



        /*TAB 4*/
        private void bFiltraInProgetti_Click(object sender, EventArgs e) {
            string res = CheckIfValidOperatorAndNumber(cbSegnoBilancioInProgetti, mtbBilancioInProgetti);
            if (res != String.Empty) {
                MessageBox.Show(res);
                return;
            }

            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE progetti.sigla LIKE '{tbSiglaInProgetti.Text}%' AND progetti.nome LIKE '{tbNomeInProgetti.Text}%' AND impiegati.cognome LIKE '{tbCognResponsInProgetti.Text}%'";

            if (!String.IsNullOrWhiteSpace(cbSegnoBilancioInProgetti.Text)) { //ora posso permettermi questo if in quanto sono sicuro che i dati siano validi
                q += $" AND impiegati.stipendio {cbSegnoBilancioInProgetti.Text} {mtbBilancioInProgetti.Text}";
            }

            LoadDataOnSelectedTab(q);
        }

        private void bResetInProgetti_Click(object sender, EventArgs e) {
            tbSiglaInProgetti.Text = tbNomeInProgetti.Text = mtbBilancioInProgetti.Text = tbCognResponsInProgetti.Text = "";
            cbSegnoBilancioInProgetti.SelectedIndex = 0;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void bAggiungiRecInPartecipazioni_Click(object sender, EventArgs e) {
            string q = $"INSERT INTO partecipazioni (id_impiegato, id_progetto) VALUES ('{cbInsCognImpiegInPartecipazioni.SelectedValue}', '{cbInsNomeProgettoInPartecipazioni.SelectedValue}');";
            ExecQuery(q);

            ResetInsertFieldInPartecipazioni();
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void dataGridViewPartecipazioni_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var newRow = dataGridViewPartecipazioni.Rows[oldRowIndex];

            if (newRow.Equals(oldRow)) {
                return;
            }

            string q = $"UPDATE partecipazioni SET id_impiegato = '{newRow.Cells[0].Value}', id_progetto = '{newRow.Cells[1].Value}' WHERE partecipazioni.id_impiegato = '{oldRow.Cells[0].Value}' AND partecipazioni.id_progetto = '{oldRow.Cells[1].Value}'";
            ExecQuery(q);
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void ResetInsertFieldInPartecipazioni() {
            cbInsCognImpiegInPartecipazioni.SelectedIndex = cbInsNomeProgettoInPartecipazioni.SelectedIndex = 0;
        }
        /*FINE TAB 4*/



        private string GetBasicQuery(int tabIndex) {
            string query = "";

            switch (tabIndex) {
                case (int)eTabPages.Dipartimenti:
                    query = "SELECT dipartimenti.codice, dipartimenti.nome, dipartimenti.sede, impiegati.matricola, impiegati.cognome AS 'cognome responsabile' FROM dipartimenti JOIN impiegati ON impiegati.matricola = dipartimenti.id_direttore";
                    break;
                case (int)eTabPages.Impiegati:
                    query = "SELECT impiegati.matricola, impiegati.cognome, impiegati.stipendio, dipartimenti.codice, dipartimenti.nome AS 'nome dipartimento' FROM dipartimenti JOIN impiegati ON impiegati.id_dipartimento = dipartimenti.codice";
                    break;
                case (int)eTabPages.Progetti:
                    query = "SELECT progetti.sigla, progetti.nome, progetti.bilancio, impiegati.matricola, impiegati.cognome AS 'cognome responsabile' FROM progetti JOIN impiegati ON progetti.id_responsabile = impiegati.matricola";
                    break;
                case (int)eTabPages.Partecipazioni:
                    query = "SELECT impiegati.matricola, impiegati.cognome AS 'cognome impiegato', progetti.sigla, progetti.nome AS 'nome progetto' FROM (partecipazioni JOIN impiegati ON partecipazioni.id_impiegato = impiegati.matricola) JOIN progetti ON partecipazioni.id_progetto = progetti.sigla";
                    break;
                default:
                    throw new Exception("Index non valido");
            }

            return query;
        }

        private void LoadDataOnSelectedTab(string query) {
            MySqlDataAdapter MyAdapter = ExecQuery($"{query};");
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);

            DataGridViewComboBoxColumn newCol, newCol1 = null;

            switch (tabControl1.SelectedIndex) {
                case (int)eTabPages.Dipartimenti:
                    DataTable datiImpiegatiTmp = new DataTable();
                    ExecQuery("SELECT impiegati.matricola AS 'matricola', impiegati.cognome AS 'cognome responsabile' FROM impiegati").Fill(datiImpiegatiTmp);

                    newCol = GetComboBoxColumn("cognome responsabile", "matricola", datiImpiegatiTmp);

                    ChangeComboBoxIfSmaller(cbInsCognRespoInDipartimenti, datiImpiegatiTmp, "cognome responsabile", "matricola");

                    dati.Columns.Remove("cognome responsabile"); //la rimuovo perche' mi serviva nella combobox ma poi non la voglio vedere
                    break;
                case (int)eTabPages.Impiegati:
                    DataTable tmp = dati.DefaultView.ToTable(true, "nome dipartimento", "codice");
                    newCol = GetComboBoxColumn("nome dipartimento", "codice", tmp);

                    ChangeComboBoxIfSmaller(cbInsNomeDipartInImpiegati, tmp, "nome dipartimento", "codice"); //lo inserisco prima perche' qui non voglio ci sia lo spazio vuoto

                    DataRow dr = tmp.NewRow(); //cosi' da lasciare l'opzione vuouta nei filtri di ricerca
                    dr[0] = dr[1] = "";
                    tmp.Rows.InsertAt(dr, 0);

                    ChangeComboBoxIfSmaller(cbNomeDipartInImpiegati, tmp, "nome dipartimento", "codice");

                    dati.Columns.Remove("nome dipartimento");
                    break;
                case (int)eTabPages.Progetti:
                    datiImpiegatiTmp = new DataTable(); //perche' chiunque puo' essere capo
                    ExecQuery("SELECT impiegati.matricola AS 'matricola', impiegati.cognome AS 'cognome responsabile' FROM impiegati").Fill(datiImpiegatiTmp);

                    newCol = GetComboBoxColumn("cognome responsabile", "matricola", datiImpiegatiTmp);

                    ChangeComboBoxIfSmaller(cbInsCognResponsInProgetti, datiImpiegatiTmp, "cognome responsabile", "matricola");

                    dati.Columns.Remove("cognome responsabile");
                    break;

                case (int)eTabPages.Partecipazioni:
                    datiImpiegatiTmp = new DataTable();
                    ExecQuery("SELECT impiegati.matricola, impiegati.cognome FROM impiegati").Fill(datiImpiegatiTmp);
                    ChangeComboBoxIfSmaller(cbInsCognImpiegInPartecipazioni, datiImpiegatiTmp, "cognome", "matricola");

                    DataTable datiDipartimentiTmp = new DataTable();
                    ExecQuery("SELECT progetti.sigla, progetti.nome FROM progetti").Fill(datiDipartimentiTmp);
                    ChangeComboBoxIfSmaller(cbInsNomeProgettoInPartecipazioni, datiDipartimentiTmp, "nome", "sigla");

                    newCol = GetComboBoxColumn("cognome impiegato", "matricola", dati.DefaultView.ToTable(true, "cognome impiegato", "matricola"));
                    newCol1 = GetComboBoxColumn("nome progetto", "sigla", dati.DefaultView.ToTable(true, "nome progetto", "sigla"));

                    dati.Columns.Remove("cognome impiegato");
                    dati.Columns.Remove("nome progetto");
                    break;
                default:
                    throw new Exception("Index non gestito");
            }

            dataGridViewDipartimenti.BeginInvoke(new Action(() => { //perche' senno' se si sta modificando una cella da' eccezione
                ChangeComboBoxColumnIfSmaller(gridsView[tabControl1.SelectedIndex], newCol, newCol1); //se ad esempio sto filtrando la ricera non voglio che la nuova comboBox non abbia certi nomi. In ogni caso li voglio tutti
                gridsView[tabControl1.SelectedIndex].DataSource = dati;
            }));
        }

        private void gridsView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) {
            oldRowIndex = gridsView[tabControl1.SelectedIndex].SelectedCells[0].RowIndex;
            oldRow = CloneRow(gridsView[tabControl1.SelectedIndex].Rows[oldRowIndex]);

            gridsView[tabControl1.SelectedIndex].ClearSelection();
        }

        private MySqlDataAdapter ExecQuery(string command) {
            MySqlDataAdapter myAdapter = null;

            try {
                SqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(command, SqlConnection);
                cmd.ExecuteNonQuery();
                myAdapter = new MySqlDataAdapter {
                    SelectCommand = cmd
                };
                SqlConnection.Close();
            } catch (Exception e) {
                throw new Exception(e.Message);
            }

            return myAdapter;
        }

        public void ChangeComboBoxIfSmaller(ComboBox cb, DataTable data, string displMemb, string valMemb) {
            if (cb.Items.Count < data.Rows.Count) { //comboBox nei filtri ricerca
                cb.DisplayMember = displMemb;
                cb.ValueMember = valMemb;
                cb.DataSource = data;
            }
        }

        private void ChangeComboBoxColumnIfSmaller(DataGridView dgv, params DataGridViewColumn[] nCol) {
            int cbColumnsIndex = 0;

            List<DataGridViewColumn> newCol = nCol.ToList();
            newCol.RemoveAll(elemento => elemento == null);

            for (int i = 0; i < dgv.ColumnCount; i++) {
                if (dgv.Columns[i].GetType() != typeof(DataGridViewComboBoxColumn))
                    continue;

                var oldCol = (DataGridViewComboBoxColumn)dgv.Columns[i];

                DataGridViewComboBoxColumn[] tmpCol = new DataGridViewComboBoxColumn[newCol.Count];
                for (int j = 0; j < newCol.Count; j++) {
                    tmpCol[j] = (DataGridViewComboBoxColumn)newCol[j];
                }

                if (oldCol.Items.Count < tmpCol[cbColumnsIndex].Items.Count) {
                    gridsView[tabControl1.SelectedIndex].Columns.RemoveAt(0);
                    gridsView[tabControl1.SelectedIndex].Columns.Insert(0, newCol[cbColumnsIndex]);
                }
            }

            if (dgv.ColumnCount == 0) {
                for (int j = 0; j < newCol.Count; j++) {
                    gridsView[tabControl1.SelectedIndex].Columns.Add(newCol[j]);
                }
            }
        }

        private DataGridViewComboBoxColumn GetComboBoxColumn(string toDisplay, string val, object src) {
            DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();

            col.HeaderText = toDisplay;
            col.DisplayMember = toDisplay;
            col.ValueMember = val;
            col.DataPropertyName = val;
            col.DataSource = src;

            return col;
        }

        private string CheckIfValidOperatorAndNumber(ComboBox cbOperatore, MaskedTextBox num) {
            if (String.IsNullOrWhiteSpace(cbOperatore.Text) && !String.IsNullOrWhiteSpace(num.Text)) {
                return "Inerire l'operatore matematico per confrontare il numero";
            } else if (!String.IsNullOrWhiteSpace(cbOperatore.Text) && String.IsNullOrWhiteSpace(num.Text)) {
                return "Inserire un valore da confrontare";
            }
            return String.Empty;
        }

        private bool CheckIfValidStrings(params string[] values) {
            for (int i = 0; i < values.Length; i++) {
                if (String.IsNullOrEmpty(values[i]) || String.IsNullOrWhiteSpace(values[i])) {
                    return false;
                }
            }

            return true;
        }

        public DataGridViewRow CloneRow(DataGridViewRow row) {
            DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();

            for (int index = 0; index < row.Cells.Count; index++) {
                clonedRow.Cells[index].Value = row.Cells[index].Value;
            }

            return clonedRow;
        }

        private string GetDatabaseConnectionRow(string fileName) {
            if (!File.Exists(fileName)) {
                MessageBox.Show("Impossibile trovare il file con le informazioni per poter accedere al database");
            }

            string outp = "";
            using (StreamReader file = new StreamReader(fileName)) {
                outp = file.ReadLine();
                file.Close();
            }
            return outp;
        }
    }
}