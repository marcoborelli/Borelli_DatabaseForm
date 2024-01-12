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
            this.dataGridViewDipartimenti = new System.Windows.Forms.DataGridView();
            this.tabPageImpiegati = new System.Windows.Forms.TabPage();
            this.dataGridViewImpiegati = new System.Windows.Forms.DataGridView();
            this.tabPagePartecipazioni = new System.Windows.Forms.TabPage();
            this.dataGridViewPartecipazioni = new System.Windows.Forms.DataGridView();
            this.tabPageProgetti = new System.Windows.Forms.TabPage();
            this.dataGridViewProgetti = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNomeCittaInDipartimenti = new System.Windows.Forms.TextBox();
            this.tbCognResponsInDipartimenti = new System.Windows.Forms.TextBox();
            this.bFiltraInDipartimenti = new System.Windows.Forms.Button();
            this.bResetIndipartimenti = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabDipartimenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).BeginInit();
            this.tabPageImpiegati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).BeginInit();
            this.tabPagePartecipazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).BeginInit();
            this.tabPageProgetti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tabPageImpiegati.Controls.Add(this.dataGridViewImpiegati);
            this.tabPageImpiegati.Location = new System.Drawing.Point(4, 22);
            this.tabPageImpiegati.Name = "tabPageImpiegati";
            this.tabPageImpiegati.Size = new System.Drawing.Size(793, 427);
            this.tabPageImpiegati.TabIndex = 0;
            this.tabPageImpiegati.Text = "IMPIEGATI";
            this.tabPageImpiegati.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(3, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 274);
            this.panel1.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FILTRA PER:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cognome\r\nReponsabile:";
            // 
            // tbNomeCittaInDipartimenti
            // 
            this.tbNomeCittaInDipartimenti.Location = new System.Drawing.Point(70, 27);
            this.tbNomeCittaInDipartimenti.Name = "tbNomeCittaInDipartimenti";
            this.tbNomeCittaInDipartimenti.Size = new System.Drawing.Size(127, 20);
            this.tbNomeCittaInDipartimenti.TabIndex = 3;
            // 
            // tbCognResponsInDipartimenti
            // 
            this.tbCognResponsInDipartimenti.Location = new System.Drawing.Point(70, 66);
            this.tbCognResponsInDipartimenti.Name = "tbCognResponsInDipartimenti";
            this.tbCognResponsInDipartimenti.Size = new System.Drawing.Size(127, 20);
            this.tbCognResponsInDipartimenti.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipartimenti)).EndInit();
            this.tabPageImpiegati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpiegati)).EndInit();
            this.tabPagePartecipazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartecipazioni)).EndInit();
            this.tabPageProgetti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgetti)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}

