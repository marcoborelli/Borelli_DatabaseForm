using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Windows.Forms;

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

                /*_sqlConn.Open(); //non so se sia logicamente giusto aprirla di default

                int attemps = 0;
                bool first = true;
                do {
                    attemps++;

                    if (first) {
                        first = false;
                    } else {
                        Thread.Sleep(250);
                    }
                } while (!_sqlConn.Ping() && attemps < 15);

                if (attemps == 15) {
                    throw new Exception("Il server non risponde al ping");
                }*/

                return _sqlConn;
            }
        }

        public enum eTabPages {
            Dipartimenti,
            Impiegati,
            Partecipazioni,
            Progetti
        }

        private string[] tableName;
        private DataGridView[] gridsView;

        public Form1() {
            InitializeComponent();

            tableName = new string[] { "dipartimenti", "impiegati", "partecipazioni", "progetti" };
            gridsView = new DataGridView[] { dataGridViewDipartimenti, dataGridViewImpiegati, dataGridViewPartecipazioni, dataGridViewProgetti };

            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            LoadDataOnSelectedTab(GetBasicQuery(tabControl1.SelectedIndex));
        }


        }

        private string GetBasicQuery(int tabIndex) {
            string query = "";

            switch (tabControl1.SelectedIndex) {
                case (int)eTabPages.Dipartimenti:
                    query = "SELECT dipartimenti.codice, dipartimenti.nome, dipartimenti.sede, impiegati.cognome AS 'cognome responsabile' FROM dipartimenti JOIN impiegati ON impiegati.matricola = dipartimenti.id_direttore";
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
    }
}
