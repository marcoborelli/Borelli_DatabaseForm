namespace Borelli_DatabaseForm {
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCognomeInImpiegati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewImpiegati = new System.Windows.Forms.DataGridView();
            this.tabPagePartecipazioni = new System.Windows.Forms.TabPage();
            this.dataGridViewPartecipazioni = new System.Windows.Forms.DataGridView();
            this.tabPageProgetti = new System.Windows.Forms.TabPage();
            this.dataGridViewProgetti = new System.Windows.Forms.DataGridView();
            this.cbSegnoStipendioInImpiegati = new System.Windows.Forms.ComboBox();
            this.cbNomeDipartInImpiegati = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bResetInImpiegati = new System.Windows.Forms.Button();
            this.bFiltraInImpiegati = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtbStipendioInImpiegati = new System.Windows.Forms.MaskedTextBox();
            this.tabControl1.SuspendLayout();
            this.tabDipartimenti.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).BeginInit();
            this.tabPageImpiegati.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            this.tabPagePartecipazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).BeginInit();
            this.tabPageProgetti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabDipartimenti);
            this.tabControl1.Controls.Add(this.tabPageImpiegati);
            this.tabControl1.Controls.Add(this.tabPagePartecipazioni);
            this.tabControl1.Controls.Add(this.tabPageProgetti);
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
            // tabPagePartecipazioni
            // 
            this.tabPagePartecipazioni.Controls.Add(this.dataGridViewPartecipazioni);
            this.tabPagePartecipazioni.Location = new System.Drawing.Point(4, 22);
            this.tabPagePartecipazioni.Name = "tabPagePartecipazioni";
            this.tabPagePartecipazioni.Size = new System.Drawing.Size(793, 427);
            this.tabPagePartecipazioni.TabIndex = 1;
            this.tabPagePartecipazioni.Text = "PARTECIPAZIONI";
            this.tabPagePartecipazioni.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPartecipazioni
            // 
            this.dataGridViewPartecipazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartecipazioni.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewPartecipazioni.Name = "dataGridViewPartecipazioni";
            this.dataGridViewPartecipazioni.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewPartecipazioni.TabIndex = 1;
            // 
            // tabPageProgetti
            // 
            this.tabPageProgetti.Controls.Add(this.dataGridViewProgetti);
            this.tabPageProgetti.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgetti.Name = "tabPageProgetti";
            this.tabPageProgetti.Size = new System.Drawing.Size(793, 427);
            this.tabPageProgetti.TabIndex = 2;
            this.tabPageProgetti.Text = "PROGETTI";
            this.tabPageProgetti.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProgetti
            // 
            this.dataGridViewProgetti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgetti.Location = new System.Drawing.Point(209, 3);
            this.dataGridViewProgetti.Name = "dataGridViewProgetti";
            this.dataGridViewProgetti.Size = new System.Drawing.Size(575, 413);
            this.dataGridViewProgetti.TabIndex = 1;
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
            // bResetInImpiegati
            // 
            this.bResetInImpiegati.Location = new System.Drawing.Point(5, 134);
            this.bResetInImpiegati.Name = "bResetInImpiegati";
            this.bResetInImpiegati.Size = new System.Drawing.Size(110, 23);
            this.bResetInImpiegati.TabIndex = 11;
            this.bResetInImpiegati.Text = "RESET VALORI";
            this.bResetInImpiegati.UseVisualStyleBackColor = true;
            // 
            // bFiltraInImpiegati
            // 
            this.bFiltraInImpiegati.Location = new System.Drawing.Point(121, 134);
            this.bFiltraInImpiegati.Name = "bFiltraInImpiegati";
            this.bFiltraInImpiegati.Size = new System.Drawing.Size(75, 23);
            this.bFiltraInImpiegati.TabIndex = 10;
            this.bFiltraInImpiegati.Text = "FILTRA";
            this.bFiltraInImpiegati.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(3, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 239);
            this.panel4.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabDipartimenti.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).EndInit();
            this.tabPageImpiegati.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
            this.tabPagePartecipazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).EndInit();
            this.tabPageProgetti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).EndInit();
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
    }
}

