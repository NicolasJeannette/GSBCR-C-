using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmPraticien : Form
    {
        private string id;
        public FrmPraticien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*FrmMenuVisiteur frm = new FrmMenuVisiteur();
            frm.matricule = id;
            dataGridView1.DataSource = Manager.ChargerRapportPraticien(id)*/
        }
    }
}
