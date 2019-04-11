namespace GSBCR.UI
{
    partial class FrmPraticien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rAPMATRICULEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPRANUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPDATVISITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPETATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPCONFIANCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPBILANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPNOMREMPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPMED2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMedicament2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leMotifVisiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lePraticienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rAPMATRICULEDataGridViewTextBoxColumn,
            this.rAPNUMDataGridViewTextBoxColumn,
            this.rAPPRANUMDataGridViewTextBoxColumn,
            this.rAPDATEDataGridViewTextBoxColumn,
            this.rAPDATVISITDataGridViewTextBoxColumn,
            this.rAPETATDataGridViewTextBoxColumn,
            this.rAPCONFIANCEDataGridViewTextBoxColumn,
            this.rAPBILANDataGridViewTextBoxColumn,
            this.rAPMOTIFDataGridViewTextBoxColumn,
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn,
            this.rAPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPPNOMREMPLDataGridViewTextBoxColumn,
            this.rAPMED1DataGridViewTextBoxColumn,
            this.rAPMED2DataGridViewTextBoxColumn,
            this.leMedicament1DataGridViewTextBoxColumn,
            this.leMedicament2DataGridViewTextBoxColumn,
            this.leMotifVisiteDataGridViewTextBoxColumn,
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn,
            this.lePraticienDataGridViewTextBoxColumn,
            this.leVisiteurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(74, 126);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(781, 223);
            this.dataGridView1.TabIndex = 22;
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            this.rAPMATRICULEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPMATRICULEDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            this.rAPNUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPNUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            this.rAPPRANUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAPPRANUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            this.rAPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            this.rAPDATVISITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            this.rAPETATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            this.rAPBILANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            this.rAPMOTIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            this.rAPMED1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            this.rAPMED2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leMedicament1DataGridViewTextBoxColumn
            // 
            this.leMedicament1DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.HeaderText = "LeMedicament1";
            this.leMedicament1DataGridViewTextBoxColumn.Name = "leMedicament1DataGridViewTextBoxColumn";
            this.leMedicament1DataGridViewTextBoxColumn.ReadOnly = true;
            this.leMedicament1DataGridViewTextBoxColumn.Visible = false;
            // 
            // leMedicament2DataGridViewTextBoxColumn
            // 
            this.leMedicament2DataGridViewTextBoxColumn.DataPropertyName = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.HeaderText = "LeMedicament2";
            this.leMedicament2DataGridViewTextBoxColumn.Name = "leMedicament2DataGridViewTextBoxColumn";
            this.leMedicament2DataGridViewTextBoxColumn.ReadOnly = true;
            this.leMedicament2DataGridViewTextBoxColumn.Visible = false;
            // 
            // leMotifVisiteDataGridViewTextBoxColumn
            // 
            this.leMotifVisiteDataGridViewTextBoxColumn.DataPropertyName = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.HeaderText = "LeMotifVisite";
            this.leMotifVisiteDataGridViewTextBoxColumn.Name = "leMotifVisiteDataGridViewTextBoxColumn";
            this.leMotifVisiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.leMotifVisiteDataGridViewTextBoxColumn.Visible = false;
            // 
            // lesEchantillonsOffertsDataGridViewTextBoxColumn
            // 
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.DataPropertyName = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.HeaderText = "LesEchantillonsOfferts";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Name = "lesEchantillonsOffertsDataGridViewTextBoxColumn";
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.ReadOnly = true;
            this.lesEchantillonsOffertsDataGridViewTextBoxColumn.Visible = false;
            // 
            // lePraticienDataGridViewTextBoxColumn
            // 
            this.lePraticienDataGridViewTextBoxColumn.DataPropertyName = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.HeaderText = "LePraticien";
            this.lePraticienDataGridViewTextBoxColumn.Name = "lePraticienDataGridViewTextBoxColumn";
            this.lePraticienDataGridViewTextBoxColumn.ReadOnly = true;
            this.lePraticienDataGridViewTextBoxColumn.Visible = false;
            // 
            // leVisiteurDataGridViewTextBoxColumn
            // 
            this.leVisiteurDataGridViewTextBoxColumn.DataPropertyName = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.HeaderText = "LeVisiteur";
            this.leVisiteurDataGridViewTextBoxColumn.Name = "leVisiteurDataGridViewTextBoxColumn";
            this.leVisiteurDataGridViewTextBoxColumn.ReadOnly = true;
            this.leVisiteurDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(GSBCR.modele.RAPPORT_VISITE);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Voir rapport";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(761, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 24;
            this.button2.Text = "Retour";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Visiteur : ";
            // 
            // FrmPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 371);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmPraticien";
            this.Text = "FrmPraticien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMATRICULEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPRANUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPDATVISITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPETATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPCONFIANCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPBILANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMOTIFAUTREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPNOMREMPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPMED2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMedicament2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leMotifVisiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesEchantillonsOffertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lePraticienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leVisiteurDataGridViewTextBoxColumn;
    }
}