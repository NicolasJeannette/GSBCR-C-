using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;



using System.Data.SqlClient;

namespace GSBCR.UC
{
    public partial class UcPraticien : UserControl
    {
   

        private PRATICIEN lePraticien = null;
       
        private List<RAPPORT_VISITE> leRapport;
        
        
        public UcPraticien()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Visible = false;
        }
        public PRATICIEN LePraticien
        {
            get { return lePraticien; }
            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPraticien_actualiser();
                }

            }
        }
       
        private void ucPraticien_actualiser()
        {
            txtNUM.Text = Convert.ToString(lePraticien.PRA_NUM);
            txtNOM.Text = lePraticien.PRA_NOM;
            txtPRENOM.Text = lePraticien.PRA_PRENOM;
            txtADRESSE.Text = lePraticien.PRA_ADRESSE;
            txtCP.Text = lePraticien.PRA_CP;
            txtVILLE.Text = lePraticien.PRA_VILLE;
            txtCOEFF.Text =  Convert.ToString(lePraticien.PRA_COEFNOTORIETE);
            txtCODE.Text = lePraticien.TYP_CODE;
            
           
            
            if(txtCODE.Text == "MH")
            {
                txtType.Text = "Médecin Hospitalier";
                txtTypeLieu.Text = "Hopital ou clinique";
            }
            if (txtCODE.Text == "MV")
            {
                txtType.Text = "Médecine de Ville";
                txtTypeLieu.Text = "Cabinet";
            }
            if (txtCODE.Text == "PH")
            {
                txtType.Text = "Pharmacien Hospitalier";
                txtTypeLieu.Text = "Hopital ou clinique";
            }
            if (txtCODE.Text == "PO")
            {
                txtType.Text = "Pharmacien Officine";
                txtTypeLieu.Text = "Pharmacie";
            }
            if (txtCODE.Text == "PS")
            {
                txtType.Text = "Personnel de santé";
                txtTypeLieu.Text = "Centre Paramédical";
            }
        }

        
     
        private void btnVoirRapport_Click(object sender, EventArgs e)
        {
           
            leRapport =  Manager.ChargerRapportPraticien(MatriculeText.Text,Convert.ToInt32(txtNUM.Text));
            dataGridView1.DataSource = leRapport;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = " ";
                    }
                }
              
            }




        }

    }
}
