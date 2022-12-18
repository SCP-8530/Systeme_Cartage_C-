using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final
{
    internal class adoNET
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataTable dtCrystalien;
        private DataTable dtFee;
        private DataTable dtMission;
        private DataSet dsCartage;

        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnectionString { get => connectionString; }
        public DataTable DtCrystalien { get => dtCrystalien; set => dtCrystalien = value; }
        public DataTable DtFee { get => dtFee; set => dtFee = value; }
        public DataTable DtMission { get => dtMission; set => dtMission = value; }
        public DataSet DsCartage { get => dsCartage; set => dsCartage = value; }

        public adoNET()
        {
            connectionString = "Data Source=MSI;Initial Catalog=Cartage;";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsCartage = new DataSet();
            dtCrystalien = new DataTable();
            dtFee = new DataTable();
            dtMission = new DataTable();
        }
    }
}
