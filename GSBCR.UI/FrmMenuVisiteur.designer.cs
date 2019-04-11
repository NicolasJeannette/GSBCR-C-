namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnVoirValide = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnPraticien = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnDeco = new System.Windows.Forms.Button();
            this.btnChangeMdp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(154, 162);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(200, 23);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau rapport de visite";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 333);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnVoirValide
            // 
            this.btnVoirValide.Location = new System.Drawing.Point(154, 218);
            this.btnVoirValide.Name = "btnVoirValide";
            this.btnVoirValide.Size = new System.Drawing.Size(200, 21);
            this.btnVoirValide.TabIndex = 7;
            this.btnVoirValide.Text = "Voir Rapport Validé";
            this.btnVoirValide.UseVisualStyleBackColor = true;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(154, 191);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(200, 21);
            this.btnModif.TabIndex = 8;
            this.btnModif.Text = "Modifier Rapport Visite";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnPraticien
            // 
            this.btnPraticien.Location = new System.Drawing.Point(154, 245);
            this.btnPraticien.Name = "btnPraticien";
            this.btnPraticien.Size = new System.Drawing.Size(200, 21);
            this.btnPraticien.TabIndex = 9;
            this.btnPraticien.Text = "Consulter Praticien";
            this.btnPraticien.UseVisualStyleBackColor = true;
            this.btnPraticien.Click += new System.EventHandler(this.btnPraticien_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(154, 272);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(200, 21);
            this.btnMed.TabIndex = 10;
            this.btnMed.Text = "Consulter Médicament";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnDeco
            // 
            this.btnDeco.Location = new System.Drawing.Point(12, 376);
            this.btnDeco.Name = "btnDeco";
            this.btnDeco.Size = new System.Drawing.Size(93, 23);
            this.btnDeco.TabIndex = 11;
            this.btnDeco.Text = "Se déconnecter";
            this.btnDeco.UseVisualStyleBackColor = true;
            this.btnDeco.Click += new System.EventHandler(this.btnDeco_Click);
            // 
            // btnChangeMdp
            // 
            this.btnChangeMdp.Location = new System.Drawing.Point(405, 362);
            this.btnChangeMdp.Name = "btnChangeMdp";
            this.btnChangeMdp.Size = new System.Drawing.Size(110, 37);
            this.btnChangeMdp.TabIndex = 12;
            this.btnChangeMdp.Text = "Changer mot de passe";
            this.btnChangeMdp.UseVisualStyleBackColor = true;
            this.btnChangeMdp.Click += new System.EventHandler(this.btnChangeMdp_Click);
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.btnChangeMdp);
            this.Controls.Add(this.btnDeco);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnPraticien);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnVoirValide);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenuVisiteur";
            this.Text = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnVoirValide;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnPraticien;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnDeco;
        private System.Windows.Forms.Button btnChangeMdp;
    }
}