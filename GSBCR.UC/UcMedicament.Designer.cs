namespace GSBCR.UC
{
    partial class UcMedicament
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepot = new System.Windows.Forms.TextBox();
            this.txtCommercial = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomFamille = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.richtxtComposition = new System.Windows.Forms.RichTextBox();
            this.richtxtEffets = new System.Windows.Forms.RichTextBox();
            this.richtxtIndications = new System.Windows.Forms.RichTextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.btnVoirRapport = new System.Windows.Forms.Button();
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
            this.rAPPORTVISITEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gSB_Visite_JEANNETTEDataSet = new GSBCR.UC.GSB_Visite_JEANNETTEDataSet();
            this.rAPPORT_VISITETableAdapter = new GSBCR.UC.GSB_Visite_JEANNETTEDataSetTableAdapters.RAPPORT_VISITETableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Visite_JEANNETTEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dépot Légal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Commercial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Famille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Composition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Effets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contre-indications";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prix échantillon";
            // 
            // txtDepot
            // 
            this.txtDepot.CausesValidation = false;
            this.txtDepot.Location = new System.Drawing.Point(139, 20);
            this.txtDepot.Name = "txtDepot";
            this.txtDepot.Size = new System.Drawing.Size(100, 20);
            this.txtDepot.TabIndex = 7;
            this.txtDepot.TabStop = false;
            // 
            // txtCommercial
            // 
            this.txtCommercial.CausesValidation = false;
            this.txtCommercial.Location = new System.Drawing.Point(139, 65);
            this.txtCommercial.Name = "txtCommercial";
            this.txtCommercial.Size = new System.Drawing.Size(100, 20);
            this.txtCommercial.TabIndex = 8;
            this.txtCommercial.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomFamille);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Location = new System.Drawing.Point(139, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txtNomFamille
            // 
            this.txtNomFamille.CausesValidation = false;
            this.txtNomFamille.Location = new System.Drawing.Point(122, 19);
            this.txtNomFamille.Name = "txtNomFamille";
            this.txtNomFamille.Size = new System.Drawing.Size(315, 20);
            this.txtNomFamille.TabIndex = 1;
            this.txtNomFamille.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.CausesValidation = false;
            this.txtCode.Location = new System.Drawing.Point(16, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.TabStop = false;
            // 
            // richtxtComposition
            // 
            this.richtxtComposition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtComposition.CausesValidation = false;
            this.richtxtComposition.Location = new System.Drawing.Point(139, 193);
            this.richtxtComposition.Name = "richtxtComposition";
            this.richtxtComposition.Size = new System.Drawing.Size(443, 123);
            this.richtxtComposition.TabIndex = 10;
            this.richtxtComposition.TabStop = false;
            this.richtxtComposition.Text = "";
            // 
            // richtxtEffets
            // 
            this.richtxtEffets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtEffets.CausesValidation = false;
            this.richtxtEffets.Location = new System.Drawing.Point(139, 321);
            this.richtxtEffets.Name = "richtxtEffets";
            this.richtxtEffets.Size = new System.Drawing.Size(443, 123);
            this.richtxtEffets.TabIndex = 11;
            this.richtxtEffets.TabStop = false;
            this.richtxtEffets.Text = "";
            // 
            // richtxtIndications
            // 
            this.richtxtIndications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtIndications.CausesValidation = false;
            this.richtxtIndications.Location = new System.Drawing.Point(139, 453);
            this.richtxtIndications.Name = "richtxtIndications";
            this.richtxtIndications.Size = new System.Drawing.Size(443, 123);
            this.richtxtIndications.TabIndex = 12;
            this.richtxtIndications.TabStop = false;
            this.richtxtIndications.Text = "";
            // 
            // txtPrix
            // 
            this.txtPrix.CausesValidation = false;
            this.txtPrix.Location = new System.Drawing.Point(139, 596);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(133, 20);
            this.txtPrix.TabIndex = 13;
            this.txtPrix.TabStop = false;
            // 
            // btnVoirRapport
            // 
            this.btnVoirRapport.Location = new System.Drawing.Point(312, 596);
            this.btnVoirRapport.Name = "btnVoirRapport";
            this.btnVoirRapport.Size = new System.Drawing.Size(140, 20);
            this.btnVoirRapport.TabIndex = 14;
            this.btnVoirRapport.Text = "Voir Rapport Médicament";
            this.btnVoirRapport.UseVisualStyleBackColor = true;
            this.btnVoirRapport.Click += new System.EventHandler(this.btnVoirRapport_Click);
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
            this.rAPMED2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rAPPORTVISITEBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(51, 622);
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
            this.dataGridView1.Size = new System.Drawing.Size(590, 223);
            this.dataGridView1.TabIndex = 22;
            // 
            // rAPMATRICULEDataGridViewTextBoxColumn
            // 
            this.rAPMATRICULEDataGridViewTextBoxColumn.DataPropertyName = "RAP_MATRICULE";
            this.rAPMATRICULEDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.rAPMATRICULEDataGridViewTextBoxColumn.Name = "rAPMATRICULEDataGridViewTextBoxColumn";
            this.rAPMATRICULEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPNUMDataGridViewTextBoxColumn
            // 
            this.rAPNUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_NUM";
            this.rAPNUMDataGridViewTextBoxColumn.HeaderText = "Numéro Rapport";
            this.rAPNUMDataGridViewTextBoxColumn.Name = "rAPNUMDataGridViewTextBoxColumn";
            this.rAPNUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPPRANUMDataGridViewTextBoxColumn
            // 
            this.rAPPRANUMDataGridViewTextBoxColumn.DataPropertyName = "RAP_PRANUM";
            this.rAPPRANUMDataGridViewTextBoxColumn.HeaderText = "Numéro Rapport";
            this.rAPPRANUMDataGridViewTextBoxColumn.Name = "rAPPRANUMDataGridViewTextBoxColumn";
            this.rAPPRANUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPDATEDataGridViewTextBoxColumn
            // 
            this.rAPDATEDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATE";
            this.rAPDATEDataGridViewTextBoxColumn.HeaderText = "Date Rapport";
            this.rAPDATEDataGridViewTextBoxColumn.Name = "rAPDATEDataGridViewTextBoxColumn";
            this.rAPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPDATVISITDataGridViewTextBoxColumn
            // 
            this.rAPDATVISITDataGridViewTextBoxColumn.DataPropertyName = "RAP_DATVISIT";
            this.rAPDATVISITDataGridViewTextBoxColumn.HeaderText = "Date Visite";
            this.rAPDATVISITDataGridViewTextBoxColumn.Name = "rAPDATVISITDataGridViewTextBoxColumn";
            this.rAPDATVISITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPETATDataGridViewTextBoxColumn
            // 
            this.rAPETATDataGridViewTextBoxColumn.DataPropertyName = "RAP_ETAT";
            this.rAPETATDataGridViewTextBoxColumn.HeaderText = "Etat";
            this.rAPETATDataGridViewTextBoxColumn.Name = "rAPETATDataGridViewTextBoxColumn";
            this.rAPETATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPCONFIANCEDataGridViewTextBoxColumn
            // 
            this.rAPCONFIANCEDataGridViewTextBoxColumn.DataPropertyName = "RAP_CONFIANCE";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.HeaderText = "Confiance";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.Name = "rAPCONFIANCEDataGridViewTextBoxColumn";
            this.rAPCONFIANCEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPBILANDataGridViewTextBoxColumn
            // 
            this.rAPBILANDataGridViewTextBoxColumn.DataPropertyName = "RAP_BILAN";
            this.rAPBILANDataGridViewTextBoxColumn.HeaderText = "Bilan";
            this.rAPBILANDataGridViewTextBoxColumn.Name = "rAPBILANDataGridViewTextBoxColumn";
            this.rAPBILANDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMOTIFDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIF";
            this.rAPMOTIFDataGridViewTextBoxColumn.HeaderText = "Motif";
            this.rAPMOTIFDataGridViewTextBoxColumn.Name = "rAPMOTIFDataGridViewTextBoxColumn";
            this.rAPMOTIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMOTIFAUTREDataGridViewTextBoxColumn
            // 
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.DataPropertyName = "RAP_MOTIFAUTRE";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.HeaderText = "Autre Motif";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.Name = "rAPMOTIFAUTREDataGridViewTextBoxColumn";
            this.rAPMOTIFAUTREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_NOMREMPL";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "Nom Remplaçant";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPPNOMREMPLDataGridViewTextBoxColumn
            // 
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.DataPropertyName = "RAP_PNOMREMPL";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.HeaderText = "Prénom Remplaçant";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.Name = "rAPPNOMREMPLDataGridViewTextBoxColumn";
            this.rAPPNOMREMPLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMED1DataGridViewTextBoxColumn
            // 
            this.rAPMED1DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED1";
            this.rAPMED1DataGridViewTextBoxColumn.HeaderText = "Médicament 1";
            this.rAPMED1DataGridViewTextBoxColumn.Name = "rAPMED1DataGridViewTextBoxColumn";
            this.rAPMED1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPMED2DataGridViewTextBoxColumn
            // 
            this.rAPMED2DataGridViewTextBoxColumn.DataPropertyName = "RAP_MED2";
            this.rAPMED2DataGridViewTextBoxColumn.HeaderText = "Médicament 2";
            this.rAPMED2DataGridViewTextBoxColumn.Name = "rAPMED2DataGridViewTextBoxColumn";
            this.rAPMED2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAPPORTVISITEBindingSource
            // 
            this.rAPPORTVISITEBindingSource.DataMember = "RAPPORT_VISITE";
            this.rAPPORTVISITEBindingSource.DataSource = this.gSB_Visite_JEANNETTEDataSet;
            // 
            // gSB_Visite_JEANNETTEDataSet
            // 
            this.gSB_Visite_JEANNETTEDataSet.DataSetName = "GSB_Visite_JEANNETTEDataSet";
            this.gSB_Visite_JEANNETTEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rAPPORT_VISITETableAdapter
            // 
            this.rAPPORT_VISITETableAdapter.ClearBeforeFill = true;
            // 
            // UcMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoirRapport);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.richtxtIndications);
            this.Controls.Add(this.richtxtEffets);
            this.Controls.Add(this.richtxtComposition);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCommercial);
            this.Controls.Add(this.txtDepot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcMedicament";
            this.Size = new System.Drawing.Size(852, 848);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rAPPORTVISITEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gSB_Visite_JEANNETTEDataSet)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepot;
        private System.Windows.Forms.TextBox txtCommercial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomFamille;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.RichTextBox richtxtComposition;
        private System.Windows.Forms.RichTextBox richtxtEffets;
        private System.Windows.Forms.RichTextBox richtxtIndications;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnVoirRapport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rAPPORTVISITEBindingSource;
        private GSB_Visite_JEANNETTEDataSet gSB_Visite_JEANNETTEDataSet;
        private GSB_Visite_JEANNETTEDataSetTableAdapters.RAPPORT_VISITETableAdapter rAPPORT_VISITETableAdapter;
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
    }
}
