using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace Borelli_DatabaseForm {
    public partial class Form1 : Form {
        private MySqlConnection _sqlConn;

        private MySqlConnection SqlConnection {
            get {
                if (_sqlConn == null) {
                    try {
                        _sqlConn = new MySqlConnection("server=84.33.120.138; port=3306; uid=programma; pwd=12345; database=AziendaImpiegatiProgetti");
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
        bool isBasicQuery;
        int cbElementCounterInImpiegati = -1;

        public Form1() {
            InitializeComponent();

            gridsView = new DataGridView[] { dataGridViewDipartimenti, dataGridViewImpiegati, dataGridViewProgetti, dataGridViewPartecipazioni };

            LoadBasicDataOnSelectedTab();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            LoadBasicDataOnSelectedTab();
        }


        /* TAB 1*/
        private void bFiltraInDipartimenti_Click(object sender, EventArgs e) {
            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE dipartimenti.sede LIKE '{tbNomeCittaInDipartimenti.Text}%' AND impiegati.cognome LIKE '{tbCognResponsInDipartimenti.Text}%'";
            LoadDataOnSelectedTab(q);
        }

        private void bResetIndipartimenti_Click(object sender, EventArgs e) {
            tbCognResponsInDipartimenti.Text = tbNomeCittaInDipartimenti.Text = String.Empty;
            LoadBasicDataOnSelectedTab();
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
            LoadBasicDataOnSelectedTab();
        }
        /*FINE TAB 2*/



        /*TAB 3*/
        private void bFiltraInPartecipazioni_Click(object sender, EventArgs e) {
            string q = $"{GetBasicQuery(tabControl1.SelectedIndex)} WHERE progetti.nome LIKE '{tbNomeProgInPartecipazioni.Text}%' AND impiegati.cognome LIKE '{tbCognomeInPartecipazioni.Text}%'";
            LoadDataOnSelectedTab(q);
        }

        private void bResetInPartecipazioni_Click(object sender, EventArgs e) {
            tbNomeProgInPartecipazioni.Text = tbCognomeInPartecipazioni.Text = String.Empty;
            LoadBasicDataOnSelectedTab();
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
            LoadBasicDataOnSelectedTab();
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
                    newCol = GetComboBoxColumn("cognome responsabile", "matricola", dati.DefaultView.ToTable(true, "cognome responsabile", "matricola"));

                    dati.Columns.Remove("cognome responsabile"); //la rimuovo perche' mi serviva nella combobox ma poi non la voglio vedere
                    break;
                case (int)eTabPages.Impiegati:
                    newCol = GetComboBoxColumn("nome dipartimento", "codice", dati.DefaultView.ToTable(true, "nome dipartimento", "codice"));

                    if (cbElementCounterInImpiegati < newCol.Items.Count) { //comboBox nei filtri ricerca
                        cbNomeDipartInImpiegati.DisplayMember = "nome dipartimento";
                        cbNomeDipartInImpiegati.ValueMember = "codice";
                        cbNomeDipartInImpiegati.DataSource = dati.DefaultView.ToTable(true, "nome dipartimento", "codice");

                        cbElementCounterInImpiegati = newCol.Items.Count;
                    }

                    dati.Columns.Remove("nome dipartimento");
                    break;
                case (int)eTabPages.Progetti:
                    DataTable datiImpiegatiTmp = new DataTable(); //perche' chiunque puo' essere capo
                    ExecQuery("SELECT impiegati.matricola AS 'matricola', impiegati.cognome AS 'cognome responsabile' FROM impiegati").Fill(datiImpiegatiTmp);

                    newCol = GetComboBoxColumn("cognome responsabile", "matricola", datiImpiegatiTmp);

                    dati.Columns.Remove("cognome responsabile");
                    break;

                case (int)eTabPages.Partecipazioni:
                    newCol = GetComboBoxColumn("cognome impiegato", "matricola", dati.DefaultView.ToTable(true, "cognome impiegato", "matricola"));
                    newCol1 = GetComboBoxColumn("nome progetto", "sigla", dati.DefaultView.ToTable(true, "nome progetto", "sigla"));

                    dati.Columns.Remove("cognome impiegato");
                    dati.Columns.Remove("nome progetto");
                    break;
                default:
                    throw new Exception("Index non gestito");
            }


            ChangeComboBoxColumnIfSmaller(gridsView[tabControl1.SelectedIndex], newCol, newCol1); //se ad esempio sto filtrando la ricera non voglio che la nuova comboBox non abbia certi nomi. In ogni caso li voglio tutti
            gridsView[tabControl1.SelectedIndex].DataSource = dati;
        }

        private void LoadBasicDataOnSelectedTab() {
            isBasicQuery = true;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
            isBasicQuery = false;
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
    }
}
