using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Final
{
    //INSPIRATION : https://learn.microsoft.com/fr-fr/troubleshoot/developer/visualstudio/csharp/language-compilers/create-sql-server-database-programmatically
    internal static class SqlClass
    {
        string strConnection = "Serveur=localhost; database = Cartage";

        /// <summary>
        /// Ajoute une donne dans une table
        /// </summary>
        /// <param name="p_table">table a selectionner</param>
        /// <returns></returns>
        SqlCommand SqlSave(string p_table, string p_commande)
        {
            strConnection.Open();
            SqlCommand cmd = new SqlCommand()
        }
    }
}
