using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ML_Deconneter.Visible = false;
        }
        public void ChangerMenu(string value)
        {
            if (value == "connection")
            {
                this.ML_Connecter.Visible = false;
                this.ML_NewCompte.Visible = false;
                this.ML_Deconneter.Visible = true;
                this.M_Login.Text = "";
            }
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionForm formulaire = new ConnectionForm();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void ML_NewCompte_Click(object sender, EventArgs e)
        {
            CreationForm formulaire = new CreationForm();
            formulaire.MdiParent = this;
            formulaire.Show();
        }
    }
}
