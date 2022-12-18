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
    public partial class ListCrystalien : Form
    {
        public ListCrystalien()
        {
            InitializeComponent();
        }

        private void ListCrystalien_Load(object sender, EventArgs e)
        {
            adoNET Ado = new adoNET();
            string Query = "select * form Crystalien;";
            Ado.Command.CommandText = Query;
            Ado.Command.Connection = Ado.Connection;
            Ado.Adapter.Fill(Ado.DsCartage);
            Ado.DtCrystalien = Ado.DsCartage.Tables[Name="Crystalien"];
            this.dataGridView1.DataSource= Ado.DtCrystalien;
        }

    }
}
