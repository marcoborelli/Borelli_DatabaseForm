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

            LoadBasicDataOnSelectedTab();
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            LoadBasicDataOnSelectedTab();
        }

        private void LoadBasicDataOnSelectedTab() {
            MySqlDataAdapter MyAdapter = ExecQuery($"select * from {tableName[tabControl1.SelectedIndex]};");
            DataTable dati = new DataTable();
            MyAdapter.Fill(dati);

            gridsView[tabControl1.SelectedIndex].DataSource = dati;
        }
    }
}
