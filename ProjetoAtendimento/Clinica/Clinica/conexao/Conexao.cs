using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.conexao
{
    class Conexao
    {
        private static string connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Clinica";

        private static SqlConnection conn = null;

        //metodo para obter a conexao com o BD
        public static SqlConnection getConexao() 
        {
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
               // MessageBox.Show("Conexao aberta");
            }
            catch (SqlException ex)
            {
                conn = null;
                MessageBox.Show("Erro de conexao" + ex);
            }
            return conn;
        }
    }
}

