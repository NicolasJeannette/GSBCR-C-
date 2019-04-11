using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmConnexion : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION vaff;
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string mdp = txt_Mdp.Text;
            leVisiteur = Manager.ChargerVisiteur(id,mdp);
            vaff = Manager.ChargerAffectationVisiteur(id);
            if (txt_ID.Text=="" || txt_Mdp.Text == "")
            {
                MessageBox.Show("Veuillez renseigner le matricule/le mot de passe");
            }
            else if (vaff==null)
            {
                MessageBox.Show("Cet identifiant n'existe pas");
            }
            else if (leVisiteur == null)
            {
                MessageBox.Show("Le mot de passe est erroné");
            }
            else
            {
                this.Visible = false;
                FrmMenuVisiteur frmMV = new FrmMenuVisiteur(id, mdp);
                frmMV.ShowDialog();
                
            }


            
            
        }
    }
}
