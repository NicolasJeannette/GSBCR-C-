namespace GSBCR.UI
{
    partial class FrmMotDePasse
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
            this.txtCurrentMdp = new System.Windows.Forms.TextBox();
            this.txtConfirmMdp = new System.Windows.Forms.TextBox();
            this.txtNewMdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.lblNiveau = new System.Windows.Forms.Label();
            this.pbNiveau = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtCurrentMdp
            // 
            this.txtCurrentMdp.Location = new System.Drawing.Point(166, 47);
            this.txtCurrentMdp.Name = "txtCurrentMdp";
            this.txtCurrentMdp.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentMdp.TabIndex = 0;
            // 
            // txtConfirmMdp
            // 
            this.txtConfirmMdp.Location = new System.Drawing.Point(166, 127);
            this.txtConfirmMdp.Name = "txtConfirmMdp";
            this.txtConfirmMdp.PasswordChar = '*';
            this.txtConfirmMdp.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmMdp.TabIndex = 1;
            this.txtConfirmMdp.TextChanged += new System.EventHandler(this.txtConfirmMdp_TextChanged);
            // 
            // txtNewMdp
            // 
            this.txtNewMdp.Location = new System.Drawing.Point(166, 89);
            this.txtNewMdp.Name = "txtNewMdp";
            this.txtNewMdp.PasswordChar = '*';
            this.txtNewMdp.Size = new System.Drawing.Size(100, 20);
            this.txtNewMdp.TabIndex = 2;
            this.txtNewMdp.TextChanged += new System.EventHandler(this.txtNewMdp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nouveau mot de passe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirmation mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mot de passe actuel";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(32, 205);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 6;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(363, 205);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // lblNiveau
            // 
            this.lblNiveau.AutoSize = true;
            this.lblNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveau.Location = new System.Drawing.Point(336, 110);
            this.lblNiveau.Name = "lblNiveau";
            this.lblNiveau.Size = new System.Drawing.Size(43, 16);
            this.lblNiveau.TabIndex = 8;
            this.lblNiveau.Text = "label";
            // 
            // pbNiveau
            // 
            this.pbNiveau.ForeColor = System.Drawing.Color.Olive;
            this.pbNiveau.Location = new System.Drawing.Point(306, 130);
            this.pbNiveau.Name = "pbNiveau";
            this.pbNiveau.Size = new System.Drawing.Size(100, 23);
            this.pbNiveau.TabIndex = 10;
            // 
            // FrmMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.pbNiveau);
            this.Controls.Add(this.lblNiveau);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewMdp);
            this.Controls.Add(this.txtConfirmMdp);
            this.Controls.Add(this.txtCurrentMdp);
            this.Name = "FrmMotDePasse";
            this.Text = "FrmMotDePasse";
            this.Load += new System.EventHandler(this.FrmMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentMdp;
        private System.Windows.Forms.TextBox txtConfirmMdp;
        private System.Windows.Forms.TextBox txtNewMdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblNiveau;
        private System.Windows.Forms.ProgressBar pbNiveau;
    }
}