﻿namespace Borelli_DatabaseForm {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDipartimenti = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bResetIndipartimenti = new System.Windows.Forms.Button();
            this.bFiltraInDipartimenti = new System.Windows.Forms.Button();
            this.tbCognResponsInDipartimenti = new System.Windows.Forms.TextBox();
            this.tbNomeCittaInDipartimenti = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDipartimenti = new System.Windows.Forms.DataGridView();
            this.tabPageImpiegati = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mtbStipendioInImpiegati = new System.Windows.Forms.MaskedTextBox();
            this.bResetInImpiegati = new System.Windows.Forms.Button();
            this.bFiltraInImpiegati = new System.Windows.Forms.Button();
            this.cbNomeDipartInImpiegati = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSegnoStipendioInImpiegati = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCognomeInImpiegati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImpiegati = new System.Windows.Forms.DataGridView();
            this.tabPageProgetti = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbCognResponsInProgetti = new System.Windows.Forms.TextBox();
            this.tbNomeInProgetti = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mtbBilancioInProgetti = new System.Windows.Forms.MaskedTextBox();
            this.bResetInProgetti = new System.Windows.Forms.Button();
            this.bFiltraInProgetti = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSegnoBilancioInProgetti = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbSiglaInProgetti = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewProgetti = new System.Windows.Forms.DataGridView();
            this.tabPagePartecipazioni = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bResetInPartecipazioni = new System.Windows.Forms.Button();
            this.bFiltraInPartecipazioni = new System.Windows.Forms.Button();
            this.tbCognomeInPartecipazioni = new System.Windows.Forms.TextBox();
            this.tbNomeProgInPartecipazioni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridViewPartecipazioni = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabDipartimenti.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).BeginInit();
            this.tabPageImpiegati.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            this.tabPageProgetti.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).BeginInit();
            this.tabPagePartecipazioni.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDipartimenti);
            this.tabControl1.Controls.Add(this.tabPageImpiegati);
            this.tabControl1.Controls.Add(this.tabPageProgetti);
            this.tabControl1.Controls.Add(this.tabPagePartecipazioni);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 453);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDipartimenti
            // 
            this.tabDipartimenti.Controls.Add(this.panel2);
            this.tabDipartimenti.Controls.Add(this.panel1);
            this.tabDipartimenti.Controls.Add(this.dataGridViewDipartimenti);
            this.tabDipartimenti.Location = new System.Drawing.Point(4, 22);
            this.tabDipartimenti.Name = "tabDipartimenti";
            this.tabDipartimenti.Size = new System.Drawing.Size(793, 427);
            this.tabDipartimenti.TabIndex = 0;
            this.tabDipartimenti.Text = "DIPARTIMENTI";
            this.tabDipartimenti.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.bResetIndipartimenti);
            this.panel2.Controls.Add(this.bFiltraInDipartimenti);
            this.panel2.Controls.Add(this.tbCognResponsInDipartimenti);
            this.panel2.Controls.Add(this.tbNomeCittaInDipartimenti);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 133);
            this.panel2.TabIndex = 2;
            // 
            // bResetIndipartimenti
            // 
            this.bResetIndipartimenti.Location = new System.Drawing.Point(6, 103);
            this.bResetIndipartimenti.Name = "bResetIndipartimenti";
            this.bResetIndipartimenti.Size = new System.Drawing.Size(110, 23);
            this.bResetIndipartimenti.TabIndex = 6;
            this.bResetIndipartimenti.Text = "RESET VALORI";
            this.bResetIndipartimenti.UseVisualStyleBackColor = true;
            this.bResetIndipartimenti.Click += new System.EventHandler(this.bResetIndipartimenti_Click);
            // 
            // bFiltraInDipartimenti
            // 
            this.bFiltraInDipartimenti.Location = new System.Drawing.Point(122, 103);
            this.bFiltraInDipartimenti.Name = "bFiltraInDipartimenti";
            this.bFiltraInDipartimenti.Size = new System.Drawing.Size(75, 23);
            this.bFiltraInDipartimenti.TabIndex = 5;
            this.bFiltraInDipartimenti.Text = "FILTRA";
            this.bFiltraInDipartimenti.UseVisualStyleBackColor = true;
            this.bFiltraInDipartimenti.Click += new System.EventHandler(this.bFiltraInDipartimenti_Click);
            // 
            // tbCognResponsInDipartimenti
            // 
            this.tbCognResponsInDipartimenti.Location = new System.Drawing.Point(70, 66);
            this.tbCognResponsInDipartimenti.Name = "tbCognResponsInDipartimenti";
            this.tbCognResponsInDipartimenti.Size = new System.Drawing.Size(127, 20);
            this.tbCognResponsInDipartimenti.TabIndex = 4;
            // 
            // tbNomeCittaInDipartimenti
            // 
            this.tbNomeCittaInDipartimenti.Location = new System.Drawing.Point(70, 27);
            this.tbNomeCittaInDipartimenti.Name = "tbNomeCittaInDipartimenti";
            this.tbNomeCittaInDipartimenti.Size = new System.Drawing.Size(127, 20);
            this.tbNomeCittaInDipartimenti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cognome\r\nReponsabile:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome città:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRA PER:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 274);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewDipartimenti
            // 
            this.dataGridViewDipartimenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDipartimenti.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewDipartimenti.Name = "dataGridViewDipartimenti";
            this.dataGridViewDipartimenti.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewDipartimenti.TabIndex = 0;
            this.dataGridViewDipartimenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDipartimenti_CellDoubleClick);
            this.dataGridViewDipartimenti.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDipartimenti_CellEndEdit);
            // 
            // tabPageImpiegati
            // 
            this.tabPageImpiegati.Controls.Add(this.panel4);
            this.tabPageImpiegati.Controls.Add(this.panel3);
            this.tabPageImpiegati.Controls.Add(this.dataGridViewImpiegati);
            this.tabPageImpiegati.Location = new System.Drawing.Point(4, 22);
            this.tabPageImpiegati.Name = "tabPageImpiegati";
            this.tabPageImpiegati.Size = new System.Drawing.Size(793, 427);
            this.tabPageImpiegati.TabIndex = 0;
            this.tabPageImpiegati.Text = "IMPIEGATI";
            this.tabPageImpiegati.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(3, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 239);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.mtbStipendioInImpiegati);
            this.panel3.Controls.Add(this.bResetInImpiegati);
            this.panel3.Controls.Add(this.bFiltraInImpiegati);
            this.panel3.Controls.Add(this.cbNomeDipartInImpiegati);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbSegnoStipendioInImpiegati);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbCognomeInImpiegati);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 168);
            this.panel3.TabIndex = 2;
            // 
            // mtbStipendioInImpiegati
            // 
            this.mtbStipendioInImpiegati.Location = new System.Drawing.Point(114, 58);
            this.mtbStipendioInImpiegati.Mask = "99999";
            this.mtbStipendioInImpiegati.Name = "mtbStipendioInImpiegati";
            this.mtbStipendioInImpiegati.Size = new System.Drawing.Size(82, 20);
            this.mtbStipendioInImpiegati.TabIndex = 0;
            this.mtbStipendioInImpiegati.ValidatingType = typeof(int);
            // 
            // bResetInImpiegati
            // 
            this.bResetInImpiegati.Location = new System.Drawing.Point(5, 134);
            this.bResetInImpiegati.Name = "bResetInImpiegati";
            this.bResetInImpiegati.Size = new System.Drawing.Size(110, 23);
            this.bResetInImpiegati.TabIndex = 11;
            this.bResetInImpiegati.Text = "RESET VALORI";
            this.bResetInImpiegati.UseVisualStyleBackColor = true;
            this.bResetInImpiegati.Click += new System.EventHandler(this.bResetInImpiegati_Click);
            // 
            // bFiltraInImpiegati
            // 
            this.bFiltraInImpiegati.Location = new System.Drawing.Point(121, 134);
            this.bFiltraInImpiegati.Name = "bFiltraInImpiegati";
            this.bFiltraInImpiegati.Size = new System.Drawing.Size(75, 23);
            this.bFiltraInImpiegati.TabIndex = 10;
            this.bFiltraInImpiegati.Text = "FILTRA";
            this.bFiltraInImpiegati.UseVisualStyleBackColor = true;
            this.bFiltraInImpiegati.Click += new System.EventHandler(this.bFiltraInImpiegati_Click);
            // 
            // cbNomeDipartInImpiegati
            // 
            this.cbNomeDipartInImpiegati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeDipartInImpiegati.FormattingEnabled = true;
            this.cbNomeDipartInImpiegati.Location = new System.Drawing.Point(70, 89);
            this.cbNomeDipartInImpiegati.Name = "cbNomeDipartInImpiegati";
            this.cbNomeDipartInImpiegati.Size = new System.Drawing.Size(126, 21);
            this.cbNomeDipartInImpiegati.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nome\r\ndipartimento:";
            // 
            // cbSegnoStipendioInImpiegati
            // 
            this.cbSegnoStipendioInImpiegati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSegnoStipendioInImpiegati.FormattingEnabled = true;
            this.cbSegnoStipendioInImpiegati.Items.AddRange(new object[] {
            " ",
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this.cbSegnoStipendioInImpiegati.Location = new System.Drawing.Point(70, 58);
            this.cbSegnoStipendioInImpiegati.Name = "cbSegnoStipendioInImpiegati";
            this.cbSegnoStipendioInImpiegati.Size = new System.Drawing.Size(38, 21);
            this.cbSegnoStipendioInImpiegati.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stipendio:";
            // 
            // tbCognomeInImpiegati
            // 
            this.tbCognomeInImpiegati.Location = new System.Drawing.Point(70, 27);
            this.tbCognomeInImpiegati.Name = "tbCognomeInImpiegati";
            this.tbCognomeInImpiegati.Size = new System.Drawing.Size(127, 20);
            this.tbCognomeInImpiegati.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cognome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "FILTRA PER:";
            // 
            // dataGridViewImpiegati
            // 
            this.dataGridViewImpiegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpiegati.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewImpiegati.Name = "dataGridViewImpiegati";
            this.dataGridViewImpiegati.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewImpiegati.TabIndex = 1;
            // 
            // tabPageProgetti
            // 
            this.tabPageProgetti.Controls.Add(this.panel7);
            this.tabPageProgetti.Controls.Add(this.panel8);
            this.tabPageProgetti.Controls.Add(this.dataGridViewProgetti);
            this.tabPageProgetti.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgetti.Name = "tabPageProgetti";
            this.tabPageProgetti.Size = new System.Drawing.Size(793, 427);
            this.tabPageProgetti.TabIndex = 2;
            this.tabPageProgetti.Text = "PROGETTI";
            this.tabPageProgetti.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(3, 206);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 210);
            this.panel7.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.tbCognResponsInProgetti);
            this.panel8.Controls.Add(this.tbNomeInProgetti);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.mtbBilancioInProgetti);
            this.panel8.Controls.Add(this.bResetInProgetti);
            this.panel8.Controls.Add(this.bFiltraInProgetti);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.cbSegnoBilancioInProgetti);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Controls.Add(this.tbSiglaInProgetti);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 197);
            this.panel8.TabIndex = 4;
            // 
            // tbCognResponsInProgetti
            // 
            this.tbCognResponsInProgetti.Location = new System.Drawing.Point(70, 124);
            this.tbCognResponsInProgetti.Name = "tbCognResponsInProgetti";
            this.tbCognResponsInProgetti.Size = new System.Drawing.Size(127, 20);
            this.tbCognResponsInProgetti.TabIndex = 14;
            // 
            // tbNomeInProgetti
            // 
            this.tbNomeInProgetti.Location = new System.Drawing.Point(70, 58);
            this.tbNomeInProgetti.Name = "tbNomeInProgetti";
            this.tbNomeInProgetti.Size = new System.Drawing.Size(127, 20);
            this.tbNomeInProgetti.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Nome:";
            // 
            // mtbBilancioInProgetti
            // 
            this.mtbBilancioInProgetti.Location = new System.Drawing.Point(114, 89);
            this.mtbBilancioInProgetti.Mask = "99999";
            this.mtbBilancioInProgetti.Name = "mtbBilancioInProgetti";
            this.mtbBilancioInProgetti.Size = new System.Drawing.Size(82, 20);
            this.mtbBilancioInProgetti.TabIndex = 0;
            this.mtbBilancioInProgetti.ValidatingType = typeof(int);
            // 
            // bResetInProgetti
            // 
            this.bResetInProgetti.Location = new System.Drawing.Point(5, 163);
            this.bResetInProgetti.Name = "bResetInProgetti";
            this.bResetInProgetti.Size = new System.Drawing.Size(110, 23);
            this.bResetInProgetti.TabIndex = 11;
            this.bResetInProgetti.Text = "RESET VALORI";
            this.bResetInProgetti.UseVisualStyleBackColor = true;
            this.bResetInProgetti.Click += new System.EventHandler(this.bResetInProgetti_Click);
            // 
            // bFiltraInProgetti
            // 
            this.bFiltraInProgetti.Location = new System.Drawing.Point(121, 163);
            this.bFiltraInProgetti.Name = "bFiltraInProgetti";
            this.bFiltraInProgetti.Size = new System.Drawing.Size(75, 23);
            this.bFiltraInProgetti.TabIndex = 10;
            this.bFiltraInProgetti.Text = "FILTRA";
            this.bFiltraInProgetti.UseVisualStyleBackColor = true;
            this.bFiltraInProgetti.Click += new System.EventHandler(this.bFiltraInProgetti_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cognome\r\nresponsabile:";
            // 
            // cbSegnoBilancioInProgetti
            // 
            this.cbSegnoBilancioInProgetti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSegnoBilancioInProgetti.FormattingEnabled = true;
            this.cbSegnoBilancioInProgetti.Items.AddRange(new object[] {
            " ",
            "<",
            "<=",
            "=",
            ">=",
            ">"});
            this.cbSegnoBilancioInProgetti.Location = new System.Drawing.Point(70, 89);
            this.cbSegnoBilancioInProgetti.Name = "cbSegnoBilancioInProgetti";
            this.cbSegnoBilancioInProgetti.Size = new System.Drawing.Size(38, 21);
            this.cbSegnoBilancioInProgetti.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Bilancio";
            // 
            // tbSiglaInProgetti
            // 
            this.tbSiglaInProgetti.Location = new System.Drawing.Point(70, 27);
            this.tbSiglaInProgetti.Name = "tbSiglaInProgetti";
            this.tbSiglaInProgetti.Size = new System.Drawing.Size(127, 20);
            this.tbSiglaInProgetti.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Sigla:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "FILTRA PER:";
            // 
            // dataGridViewProgetti
            // 
            this.dataGridViewProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgetti.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewProgetti.Name = "dataGridViewProgetti";
            this.dataGridViewProgetti.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewProgetti.TabIndex = 1;
            // 
            // tabPagePartecipazioni
            // 
            this.tabPagePartecipazioni.Controls.Add(this.panel5);
            this.tabPagePartecipazioni.Controls.Add(this.panel6);
            this.tabPagePartecipazioni.Controls.Add(this.dataGridViewPartecipazioni);
            this.tabPagePartecipazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartecipazioni.Name = "tabPagePartecipazioni";
            this.tabPagePartecipazioni.Size = new System.Drawing.Size(793, 427);
            this.tabPagePartecipazioni.TabIndex = 1;
            this.tabPagePartecipazioni.Text = "PARTECIPAZIONI";
            this.tabPagePartecipazioni.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.bResetInPartecipazioni);
            this.panel5.Controls.Add(this.bFiltraInPartecipazioni);
            this.panel5.Controls.Add(this.tbCognomeInPartecipazioni);
            this.panel5.Controls.Add(this.tbNomeProgInPartecipazioni);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 133);
            this.panel5.TabIndex = 4;
            // 
            // bResetInPartecipazioni
            // 
            this.bResetInPartecipazioni.Location = new System.Drawing.Point(6, 103);
            this.bResetInPartecipazioni.Name = "bResetInPartecipazioni";
            this.bResetInPartecipazioni.Size = new System.Drawing.Size(110, 23);
            this.bResetInPartecipazioni.TabIndex = 6;
            this.bResetInPartecipazioni.Text = "RESET VALORI";
            this.bResetInPartecipazioni.UseVisualStyleBackColor = true;
            this.bResetInPartecipazioni.Click += new System.EventHandler(this.bResetInPartecipazioni_Click);
            // 
            // bFiltraInPartecipazioni
            // 
            this.bFiltraInPartecipazioni.Location = new System.Drawing.Point(122, 103);
            this.bFiltraInPartecipazioni.Name = "bFiltraInPartecipazioni";
            this.bFiltraInPartecipazioni.Size = new System.Drawing.Size(75, 23);
            this.bFiltraInPartecipazioni.TabIndex = 5;
            this.bFiltraInPartecipazioni.Text = "FILTRA";
            this.bFiltraInPartecipazioni.UseVisualStyleBackColor = true;
            this.bFiltraInPartecipazioni.Click += new System.EventHandler(this.bFiltraInPartecipazioni_Click);
            // 
            // tbCognomeInPartecipazioni
            // 
            this.tbCognomeInPartecipazioni.Location = new System.Drawing.Point(70, 66);
            this.tbCognomeInPartecipazioni.Name = "tbCognomeInPartecipazioni";
            this.tbCognomeInPartecipazioni.Size = new System.Drawing.Size(127, 20);
            this.tbCognomeInPartecipazioni.TabIndex = 4;
            // 
            // tbNomeProgInPartecipazioni
            // 
            this.tbNomeProgInPartecipazioni.Location = new System.Drawing.Point(70, 27);
            this.tbNomeProgInPartecipazioni.Name = "tbNomeProgInPartecipazioni";
            this.tbNomeProgInPartecipazioni.Size = new System.Drawing.Size(127, 20);
            this.tbNomeProgInPartecipazioni.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cognome\r\nImpiegato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome\r\nprogetto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "FILTRA PER:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(3, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 274);
            this.panel6.TabIndex = 3;
            // 
            // dataGridViewPartecipazioni
            // 
            this.dataGridViewPartecipazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartecipazioni.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewPartecipazioni.Name = "dataGridViewPartecipazioni";
            this.dataGridViewPartecipazioni.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewPartecipazioni.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDipartimenti.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).EndInit();
            this.tabPageImpiegati.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
            this.tabPageProgetti.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).EndInit();
            this.tabPagePartecipazioni.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDipartimenti;
        private System.Windows.Forms.TabPage tabPageImpiegati;
        private System.Windows.Forms.DataGridView dataGridViewDipartimenti;
        private System.Windows.Forms.TabPage tabPagePartecipazioni;
        private System.Windows.Forms.TabPage tabPageProgetti;
        private System.Windows.Forms.DataGridView dataGridViewImpiegati;
        private System.Windows.Forms.DataGridView dataGridViewPartecipazioni;
        private System.Windows.Forms.DataGridView dataGridViewProgetti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCognResponsInDipartimenti;
        private System.Windows.Forms.TextBox tbNomeCittaInDipartimenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bResetIndipartimenti;
        private System.Windows.Forms.Button bFiltraInDipartimenti;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCognomeInImpiegati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNomeDipartInImpiegati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSegnoStipendioInImpiegati;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bResetInImpiegati;
        private System.Windows.Forms.Button bFiltraInImpiegati;
        private System.Windows.Forms.MaskedTextBox mtbStipendioInImpiegati;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bResetInPartecipazioni;
        private System.Windows.Forms.Button bFiltraInPartecipazioni;
        private System.Windows.Forms.TextBox tbCognomeInPartecipazioni;
        private System.Windows.Forms.TextBox tbNomeProgInPartecipazioni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbCognResponsInProgetti;
        private System.Windows.Forms.TextBox tbNomeInProgetti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mtbBilancioInProgetti;
        private System.Windows.Forms.Button bResetInProgetti;
        private System.Windows.Forms.Button bFiltraInProgetti;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSegnoBilancioInProgetti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbSiglaInProgetti;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

