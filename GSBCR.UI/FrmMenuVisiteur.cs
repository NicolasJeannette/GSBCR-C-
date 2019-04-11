using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.DAL;
using GSBCR.BLL;
using GSBCR.UCTEST;

namespace GSBCR.UI
{
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public string matricule;
        public FrmMenuVisiteur(string id,string mdp)
        {
           
            matricule = id;
            
            InitializeComponent();
            //le visiteur doit être passé en paramètre par le menu de connexion
            //Ici initialiser le visiteur en dur
            //visiteur
            leVisiteur = Manager.ChargerVisiteur(id, mdp);
            //délégue
            //leVisiteur = Manager.ChargerVisiteur("r58", "0CC56730");
            try
            {
                leProfil = Manager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
            labelMatricule.Text = leProfil.VIS_MATRICULE;
            btnNouveau.Visible = false;
            btnModif.Visible = false;
            btnVoirValide.Visible = false;
            btnPraticien.Visible = true;
            btnMed.Visible = true;

            if (leProfil.TRA_ROLE == "Visiteur")
            {
                btnNouveau.Visible = true;
                btnModif.Visible = true;
                btnVoirValide.Visible = true;
               
            }
            if (leProfil.TRA_ROLE == "Délégué")
            {
                //Btn voir les nouveaux rapports visite   (Option)
                //btn voir les visiteurs de son équipe      (Option)
                btnNouveau.Visible = true;
                btnModif.Visible = true;
                btnVoirValide.Visible = true;

            }
            if (leProfil.TRA_ROLE == "Responsable")
            {
                //Btn voir les visiteurs de son équipe      (Option)
                //btn gérer les visiteurs et les délégués       (Option)

            }



        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true,"ajout");
            f.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnPraticien_Click(object sender, EventArgs e)
        {
            Form1 fp = new Form1(matricule);
            fp.cbxMedoc.Visible = false;
            fp.titre.Visible = true;
            fp.titre.Text = "Consultation Praticien";
            fp.cbxPraticien.Visible = true;
            
            fp.ShowDialog();
            
        }

        private void btnMed_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(matricule);
            fm.cbxPraticien.Visible = false;
            
            fm.titre.Visible = true;
            fm.titre.Text = "Consultation Médicament";
            fm.cbxMedoc.Visible = true;
            fm.ShowDialog();
            
        }

        private void btnDeco_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmConnexion frm = new FrmConnexion();
            frm.Show();
           

        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true, "modification");
            f.ShowDialog();
        }

        private void btnVoirValide_Click(object sender, EventArgs e)
        {
            FrmValider v = new FrmValider();
            v.ShowDialog();
        }
    }
}
