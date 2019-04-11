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

namespace GSBCR.UC
{
    public partial class UCValider : UserControl
    {
        private RAPPORT_VISITE laVisite = null;
        public UCValider()
        {
            InitializeComponent();
        }
        public RAPPORT_VISITE valider
        {
            get { return valider; }
            set
            {
                valider = value;
                if (valider != null)
                {
                    ucValider_actualiser();
                }

            }
        }
        private void ucValider_actualiser()
        {
        /*    
            boxRapport.Text = Convert.ToString(laVisite.RAP_NUM);
          //  boxPraticien.Text = laVisite.;
            boxDateVisite.Text = Convert.ToString(laVisite.RAP_DATVISIT);
            boxMotifVisite.Text = laVisite.RAP_MOTIF;
            boxEtatRapport.Text = laVisite.RAP_ETAT;
            boxMedicament.Text = laVisite.RAP_MED1 + " " + laVisite.RAP_MED2;
*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCValider_Load(object sender, EventArgs e)
        {

        }
    }
}
