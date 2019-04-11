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
    public partial class FrmMotDePasse : Form
    {
        VISITEUR visiteur;
        private string matricule;
        public FrmMotDePasse(string matr)
        {
            InitializeComponent();
            this.matricule= matr;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            visiteur = Manager.ChargerVisiteur(matricule, txtCurrentMdp.Text);
            if (txtCurrentMdp.Text=="" || txtCurrentMdp.Text.Trim()==" ")
            {
                MessageBox.Show("Veuillez saisir votre mot de passe actuel");
            }
            else if (txtNewMdp.Text=="" || txtNewMdp.Text.Trim() == " ")
            {
                MessageBox.Show("Veuillez saisir un nouveau mot passe");
            }
            else if (txtConfirmMdp.Text=="" || txtConfirmMdp.Text.Trim() == " ")
            {
                MessageBox.Show("Veuillez resaisir un nouveau mot passe");
            }
            else if (txtCurrentMdp.Text==txtNewMdp.Text)
            {
                MessageBox.Show("Veuillez saisir un mot passe différent de l'actuel");
            }
            
            else if (visiteur==null)
            {
                MessageBox.Show("Le mot de passe actuel ne correspond pas");
            }
            else if (txtConfirmMdp.Text!=txtNewMdp.Text)
            {
                MessageBox.Show("les deux nouveaux mots de passe ne sont pas identiques");
            }
            else
            {

            }
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        { }
           


        private void FrmMotDePasse_Load(object sender, EventArgs e)
        {
          /*  pbNiveau.Value = 0;
            Timer refreshTimer = new Timer();
            refreshTimer.Interval = 100;
            refreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            refreshTimer.Start();*/
        }

        private void txtNewMdp_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmMdp_TextChanged(object sender, EventArgs e)
        {

            string mdp = txtConfirmMdp.Text;
            if (String.IsNullOrEmpty(txtConfirmMdp.Text))
            {
                lblNiveau.Text = "faible";
                pbNiveau.Value = 0;
            }

            else if (txtConfirmMdp.Text.Contains(txtConfirmMdp.Text.ToUpper()) && txtConfirmMdp.Text.All(char.IsNumber) && txtConfirmMdp.Text.Contains(txtConfirmMdp.Text.ToLower()))
            {
                lblNiveau.ForeColor = Color.DarkRed;
                lblNiveau.Text = "faible";
                pbNiveau.BackColor = Color.DarkRed;
                pbNiveau.Value = 10;
            }
            else if (txtConfirmMdp.Text.All(char.IsNumber))
            {
                lblNiveau.ForeColor = Color.DarkRed;
                lblNiveau.Text = "moyen";
                pbNiveau.BackColor = Color.Yellow;
                pbNiveau.Value = 50;
            }
            else
            {
                lblNiveau.ForeColor = Color.Green;
                lblNiveau.Text = "fort";
                pbNiveau.BackColor = Color.Green;
                pbNiveau.Value = 100;

            }
        }
    }
    }

