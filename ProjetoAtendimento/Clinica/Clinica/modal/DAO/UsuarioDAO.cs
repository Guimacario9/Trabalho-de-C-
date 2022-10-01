using Clinica.conexao;
using Clinica.modal.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.modal.DAO
{
    class UsuarioDAO
    {
        // criar os metodos CRUD
        public UsuarioDTO selectUsuario(UsuarioDTO usuario)
        {
            SqlConnection conn = Conexao.getConexao();
            UsuarioDTO userDTO = new UsuarioDTO();
            try
            {
                String sqlSelect = @"SELECT Username, Password FROM USUARIO WHERE Username = @USERNAME AND
                                    Password = @PASSWORD";
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, conn);
                //PAR NomeDoParametro e o valor
                sqlCmd.Parameters.AddWithValue("@USERNAME", usuario.Username);
                sqlCmd.Parameters.AddWithValue("@PASSWORD", usuario.Password);
                sqlCmd.ExecuteNonQuery();
                SqlDataReader sqlLeitor = sqlCmd.ExecuteReader();
                if (sqlLeitor.Read())
                {
                    //0 e 1 são indices da numeração que foi passada no select
                    userDTO.Username = sqlLeitor[0].ToString();
                    userDTO.Password = sqlLeitor[1].ToString();
                }
                else
                {
                    userDTO = null;
                }
            }
            catch (SqlException erroSQL)
            {
                MessageBox.Show("Erro no metodo Select Usuario:" + erroSQL.Message);
            }
            finally
            {
                conn.Close();
            }
            return userDTO;
        }
    }
}
