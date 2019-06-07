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

namespace GSBCR.UCTEST
{
    public partial class Form2 : Form
    {
        private VISITEUR leVisiteur;
        public Form2(string id, string mdp)
        {
            InitializeComponent();
            leVisiteur = Manager.ChargerVisiteur(id,mdp);
            List<VISITEUR> lesVisiteurs = new List<VISITEUR>();
            lesVisiteurs = Manager.Chargerlesvisiteurs(leVisiteur.SEC_CODE);
            bindingSource1.DataSource = lesVisiteurs;
            cbxVisiteur.DataSource = bindingSource1;
            cbxVisiteur.DisplayMember = "VIS_NOM";
            cbxVisiteur.SelectedIndex = -1;
           /* bindingSource2.DataSource = Manager.Chargerlesregions(leVisiteur.SEC_CODE);
            cbxReg.DataSource = bindingSource2;
            cbxReg.DisplayMember = "REG_NOM";*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VISITEUR vs = new VISITEUR();
            vs = (VISITEUR)cbxVisiteur.SelectedItem;
            REGION r = new REGION();
            r = (REGION)cbxReg.SelectedItem;
            TRAVAILLER t = new TRAVAILLER();
            t.VIS_MATRICULE = vs.VIS_MATRICULE;
            t.JJMMAA = DateTime.Today;
            t.REG_CODE = r.REG_CODE;
            t.TRA_ROLE = "Délégué";
            Manager.CreateTravailler(t);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {
        }
    }
}
