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
                if (txtConfirmMdp.TextLength<=6)
                {
                    MessageBox.Show("Le mot de passe doit contenir au minimum six caractères!");
                }
                else
                {
                    visiteur.vis_mdp = txtConfirmMdp.Text;
                    Manager.ChangerMDP(visiteur);
                    MessageBox.Show("Le mot de passe a été modifiée!");
                    this.Close();

                }
               

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
            
            
            if (String.IsNullOrEmpty(txtConfirmMdp.Text))
            {
                lblNiveau.Text = "Faible";
                pbNiveau.Value = 0;
            }

            else{
                bool maj=false, min=false, num=false;
                char[] caractere = txtConfirmMdp.Text.ToArray();
                char[] caractereMAJ = txtConfirmMdp.Text.ToUpper().ToArray();
                char[] caractereMIN = txtConfirmMdp.Text.ToLower().ToArray();
                char[] chiffre = { '1', '2', '3', '4', '5', '6','7', '8', '9' };

                for (int i = 0; i < txtConfirmMdp.Text.Length; i++)
                {
                    if (char.IsLower(caractere[i]))
                    {
                        maj = true;
                    }
                    if(char.IsUpper(caractere[i]))
                    {
                        min = true;
                    }
                    for (int j = 0; j < chiffre.Length; j++)
                    {
                        if (caractere[i] == Convert.ToChar(chiffre[j]))
                        {
                            num = true;
                        }
                    }
                    
                }


               
                if (min==true && maj==true && num==true)
                {
                    lblNiveau.ForeColor = Color.Green;
                    lblNiveau.Text = "Fort";
                    pbNiveau.BackColor = Color.Yellow;
                    pbNiveau.Value = 100;
                }
                else if (maj == true && min == true || maj == true && num == true || min == true && num == true)
                {
                    lblNiveau.ForeColor = Color.DarkRed;
                    lblNiveau.Text = "Moyen";
                    pbNiveau.BackColor = Color.Yellow;
                    pbNiveau.Value = 50;
                }
                else
                    {
                        lblNiveau.ForeColor = Color.DarkRed;
                        lblNiveau.Text = "Faible";
                        pbNiveau.BackColor = Color.DarkRed;
                        pbNiveau.Value = 10;
                    }
                    
                
               
                
            }

        }
    }
    }

