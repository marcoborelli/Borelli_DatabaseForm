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
            Partecipazioni,
            Progetti
        }

        private DataGridView[] gridsView;
        bool isBasicQuery;

        public Form1() {
            InitializeComponent();

            gridsView = new DataGridView[] { dataGridViewDipartimenti, dataGridViewImpiegati, dataGridViewPartecipazioni, dataGridViewProgetti };

            isBasicQuery = true;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
            isBasicQuery = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            isBasicQuery = true;
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
            isBasicQuery = false;
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
        /*FINE TAB 4*/



        private string GetBasicQuery(int tabIndex) {
            string query = "";

            switch (tabControl1.SelectedIndex) {
                case (int)eTabPages.Dipartimenti:
                    query = "SELECT dipartimenti.codice, dipartimenti.nome, dipartimenti.sede, impiegati.matricola, impiegati.cognome AS 'cognome responsabile' FROM dipartimenti JOIN impiegati ON impiegati.matricola = dipartimenti.id_direttore";
                    break;
                case (int)eTabPages.Impiegati:
                    query = "SELECT impiegati.matricola, impiegati.cognome, impiegati.stipendio, dipartimenti.nome AS 'nome dipartimento' FROM dipartimenti JOIN impiegati ON impiegati.id_dipartimento = dipartimenti.codice";
                    break;
                case (int)eTabPages.Partecipazioni:
                    query = "SELECT impiegati.matricola AS 'matricola impiegato', impiegati.cognome AS 'cognome impiegato', progetti.nome AS 'nome progetto' FROM (partecipazioni JOIN impiegati ON partecipazioni.id_impiegato = impiegati.matricola) JOIN progetti ON partecipazioni.id_progetto = progetti.sigla";
                    break;
                case (int)eTabPages.Progetti:
                    query = "SELECT progetti.sigla, progetti.nome, progetti.bilancio, impiegati.cognome AS 'cognome responsabile' FROM progetti JOIN impiegati ON progetti.id_responsabile = impiegati.matricola";
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

            if (isBasicQuery) { //perche' le comboBox per filtrare prendono i dati della tabella ma se sono filtrati non ci sono tutti
                switch (tabControl1.SelectedIndex) {
                    case (int)eTabPages.Dipartimenti:
                        dati.Columns.Remove("matricola");
                        break;
                    case (int)eTabPages.Impiegati:
                        cbNomeDipartInImpiegati.DisplayMember = "nome dipartimento";
                        List<string> tmp = dati.AsEnumerable().Select(row => row.Field<string>("nome dipartimento")).ToList(); //non so che faccia, so che va
                        tmp.Insert(0, ""); //opzione per non selezionare nulla
                        cbNomeDipartInImpiegati.DataSource = tmp.Distinct().ToList();
                        break;
                }
            }

            gridsView[tabControl1.SelectedIndex].DataSource = dati;
        }

        private MySqlDataAdapter ExecQuery(string command) {
            MySqlDataAdapter myAdapter = null;

            try {
                SqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(command, SqlConnection);
                cmd.ExecuteNonQuery();
                myAdapter = new MySqlDataAdapter();
                myAdapter.SelectCommand = cmd;

                SqlConnection.Close();
            } catch (Exception e) {
                throw new Exception(e.Message);
            }

            return myAdapter;
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
