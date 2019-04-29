namespace GSBCR.UC
{
    partial class UCValider
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numRap = new System.Windows.Forms.TextBox();
            this.numPrat = new System.Windows.Forms.TextBox();
            this.datVisit = new System.Windows.Forms.TextBox();
            this.motifVisit = new System.Windows.Forms.TextBox();
            this.etatRap = new System.Windows.Forms.TextBox();
            this.codeMed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de Rapport";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de Praticien Visité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de Visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif De la Visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Etat du Rapport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codes des Medicaments";
            // 
            // numRap
            // 
            this.numRap.Location = new System.Drawing.Point(263, 123);
            this.numRap.Name = "numRap";
            this.numRap.Size = new System.Drawing.Size(252, 20);
            this.numRap.TabIndex = 7;
            // 
            // numPrat
            // 
            this.numPrat.Location = new System.Drawing.Point(263, 171);
            this.numPrat.Name = "numPrat";
            this.numPrat.Size = new System.Drawing.Size(252, 20);
            this.numPrat.TabIndex = 8;
            // 
            // datVisit
            // 
            this.datVisit.Location = new System.Drawing.Point(263, 219);
            this.datVisit.Name = "datVisit";
            this.datVisit.Size = new System.Drawing.Size(252, 20);
            this.datVisit.TabIndex = 9;
            // 
            // motifVisit
            // 
            this.motifVisit.Location = new System.Drawing.Point(263, 252);
            this.motifVisit.Name = "motifVisit";
            this.motifVisit.Size = new System.Drawing.Size(252, 20);
            this.motifVisit.TabIndex = 10;
            // 
            // etatRap
            // 
            this.etatRap.Location = new System.Drawing.Point(263, 316);
            this.etatRap.Name = "etatRap";
            this.etatRap.Size = new System.Drawing.Size(252, 20);
            this.etatRap.TabIndex = 11;
            // 
            // codeMed
            // 
            this.codeMed.Location = new System.Drawing.Point(263, 359);
            this.codeMed.Name = "codeMed";
            this.codeMed.Size = new System.Drawing.Size(252, 20);
            this.codeMed.TabIndex = 12;
            // 
            // UCValider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.codeMed);
            this.Controls.Add(this.etatRap);
            this.Controls.Add(this.motifVisit);
            this.Controls.Add(this.datVisit);
            this.Controls.Add(this.numPrat);
            this.Controls.Add(this.numRap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCValider";
            this.Size = new System.Drawing.Size(650, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numRap;
        private System.Windows.Forms.TextBox numPrat;
        private System.Windows.Forms.TextBox datVisit;
        private System.Windows.Forms.TextBox motifVisit;
        private System.Windows.Forms.TextBox etatRap;
        private System.Windows.Forms.TextBox codeMed;
    }
}
