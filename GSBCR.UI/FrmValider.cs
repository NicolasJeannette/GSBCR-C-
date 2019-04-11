using GSBCR.BLL;
using GSBCR.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBCR.UI
{
    public partial class FrmValider : Form
    {
        public FrmValider(RAPPORT_VISITE visiteur)
        {
            InitializeComponent();

            ucValider1.Visible = false;
            comboBox1.SelectedIndex = -1;

            if(Manager.ChargerRapportVisiteurFinis(visiteur.RAP_MATRICULE).Count != 0)
            {
                foreach (RAPPORT_VISITE Manager in Manager.ChargerRapportVisiteurFinis(visiteur.RAP_MATRICULE))
                {
                    comboBox1.Items.Add(Manager.RAP_NUM);
                }
            }

            else
            {
                MessageBox.Show("Fin");
                this.Close();
            }
            
            

        }

        private void FrmValider_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if(comboBox1.SelectedIndex != -1)
            {
                RAPPORT_VISITE rap = (RAPPORT_VISITE)comboBox1.SelectedItem ;
                ucValider1.lerapport =rap ;
                ucValider1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }
}
