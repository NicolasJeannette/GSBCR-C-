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

        public UCValider()
        {
            InitializeComponent();
        }

        public RAPPORT_VISITE lerapport
        {
            get { return lerapport; }
            set
            {
                lerapport = value;
                if (lerapport != null)
                {
                   rapport_actualiser();
                }

            }
        }

        private void rapport_actualiser()
        {
            numRap.Text = Convert.ToString(lerapport.RAP_NUM);
            numPrat.Text = Convert.ToString(lerapport.RAP_PRANUM);
            datVisit.Text = Convert.ToDateTime(lerapport.RAP_DATVISIT).ToString();
            motifVisit.Text = lerapport.RAP_MOTIF;
            etatRap.Text = lerapport.RAP_ETAT;
            codeMed.Text = lerapport.LeMedicament1.ToString() + lerapport.LeMedicament2.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRATICIEN n = new PRATICIEN();

            MessageBox.Show(

                n.PRA_NOM ,
                n.PRA_PRENOM
                
                );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MEDICAMENT n = new MEDICAMENT();

            MessageBox.Show(

                n.MED_COMPOSITION,
                n.MED_EFFETS
 


                );
        }
    }
}
