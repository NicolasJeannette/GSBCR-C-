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
           

            foreach(RAPPORT_VISITE Manager in Manager.ChargerRapportVisiteurFinis(visiteur.RAP_MATRICULE))
            {
                MessageBox.Show(Manager.RAP_NUM.ToString());
                comboBox1.Items.Add(Manager.RAP_NUM.ToString());
            }
            Manager.ChargerRapportVisiteurFinis(visiteur.RAP_MATRICULE);
        }

        private void FrmValider_Load(object sender, EventArgs e)
        {

        }
    }
}
