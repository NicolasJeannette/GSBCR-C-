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
            this.boxRapport = new System.Windows.Forms.TextBox();
            this.boxPraticien = new System.Windows.Forms.TextBox();
            this.boxDateVisite = new System.Windows.Forms.TextBox();
            this.boxMotifVisite = new System.Windows.Forms.TextBox();
            this.boxEtatRapport = new System.Windows.Forms.TextBox();
            this.boxMedicament = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro de Rapport";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro du Praticien Visité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date de la Visite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motif de la Visite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Etat du rapport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Codes des Médicaments Présentés";
            // 
            // boxRapport
            // 
            this.boxRapport.Location = new System.Drawing.Point(289, 87);
            this.boxRapport.Name = "boxRapport";
            this.boxRapport.Size = new System.Drawing.Size(191, 20);
            this.boxRapport.TabIndex = 6;
            // 
            // boxPraticien
            // 
            this.boxPraticien.Location = new System.Drawing.Point(289, 118);
            this.boxPraticien.Name = "boxPraticien";
            this.boxPraticien.Size = new System.Drawing.Size(191, 20);
            this.boxPraticien.TabIndex = 7;
            // 
            // boxDateVisite
            // 
            this.boxDateVisite.Location = new System.Drawing.Point(289, 154);
            this.boxDateVisite.Name = "boxDateVisite";
            this.boxDateVisite.Size = new System.Drawing.Size(191, 20);
            this.boxDateVisite.TabIndex = 8;
            // 
            // boxMotifVisite
            // 
            this.boxMotifVisite.Location = new System.Drawing.Point(289, 192);
            this.boxMotifVisite.Name = "boxMotifVisite";
            this.boxMotifVisite.Size = new System.Drawing.Size(191, 20);
            this.boxMotifVisite.TabIndex = 9;
            // 
            // boxEtatRapport
            // 
            this.boxEtatRapport.Location = new System.Drawing.Point(289, 231);
            this.boxEtatRapport.Name = "boxEtatRapport";
            this.boxEtatRapport.Size = new System.Drawing.Size(191, 20);
            this.boxEtatRapport.TabIndex = 10;
            // 
            // boxMedicament
            // 
            this.boxMedicament.Location = new System.Drawing.Point(289, 269);
            this.boxMedicament.Name = "boxMedicament";
            this.boxMedicament.Size = new System.Drawing.Size(191, 20);
            this.boxMedicament.TabIndex = 11;
            // 
            // UCValider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.boxMedicament);
            this.Controls.Add(this.boxEtatRapport);
            this.Controls.Add(this.boxMotifVisite);
            this.Controls.Add(this.boxDateVisite);
            this.Controls.Add(this.boxPraticien);
            this.Controls.Add(this.boxRapport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UCValider";
            this.Size = new System.Drawing.Size(596, 404);
            this.Load += new System.EventHandler(this.UCValider_Load);
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
        private System.Windows.Forms.TextBox boxRapport;
        private System.Windows.Forms.TextBox boxPraticien;
        private System.Windows.Forms.TextBox boxDateVisite;
        private System.Windows.Forms.TextBox boxMotifVisite;
        private System.Windows.Forms.TextBox boxEtatRapport;
        private System.Windows.Forms.TextBox boxMedicament;
    }
}
