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
    public partial class ListMission : Form
    {
        public ListMission()
        {
            InitializeComponent();
        }

        private void ListMission_Load(object sender, EventArgs e)
        {
            adoNET Ado = new adoNET();
            string Query = "select * form Mission;";
            Ado.Command.CommandText = Query;
            Ado.Command.Connection = Ado.Connection;
            Ado.Adapter.Fill(Ado.DsCartage);
            Ado.DtMission = Ado.DsCartage.Tables[Name="Mission"];
            this.dataGridView1.DataSource = Ado.DtMission;
        }
    }
}
