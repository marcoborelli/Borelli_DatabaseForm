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
            this.tabPageImpiegati = new System.Windows.Forms.TabPage();
            this.tabPagePartecipazioni = new System.Windows.Forms.TabPage();
            this.tabPageProgetti = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            // 
            // tabDipartimenti
            // 
            this.tabDipartimenti.Controls.Add(this.dataGridViewDipartimenti);
            this.tabDipartimenti.Location = new System.Drawing.Point(4, 22);
            this.tabDipartimenti.Name = "tabDipartimenti";
            this.tabDipartimenti.Size = new System.Drawing.Size(793, 427);
            this.tabDipartimenti.TabIndex = 0;
            this.tabDipartimenti.Text = "DIPARTIMENTI";
            this.tabDipartimenti.UseVisualStyleBackColor = true;
            // 
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
            // tabPageProgetti
            // 
            this.tabPageProgetti.Controls.Add(this.dataGridViewProgetti);
            this.tabPageProgetti.Location = new System.Drawing.Point(4, 22);
            this.tabPageProgetti.Name = "tabPageProgetti";
            this.tabPageProgetti.Size = new System.Drawing.Size(793, 427);
            this.tabPageProgetti.TabIndex = 2;
            this.tabPageProgetti.Text = "PROGETTI";
            this.tabPageProgetti.UseVisualStyleBackColor = true;
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDipartimenti;
        private System.Windows.Forms.TabPage tabPageImpiegati;
        private System.Windows.Forms.TabPage tabPagePartecipazioni;
        private System.Windows.Forms.TabPage tabPageProgetti;
    }
}

