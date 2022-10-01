using Clinica.conexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.visao.Telas_de_Cadastros
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "INSERT INTO USUARIO(username,password) values(@username,@password)";
                SqlCommand sqlGravar = new SqlCommand(sql, conn);
                // sqlGravar.Parameters.AddWithValue("@Idusuario",txtId.Text);
                sqlGravar.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlGravar.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlGravar.ExecuteNonQuery();//executar
                MessageBox.Show("Usuario cadastrado com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnCadastro_Click(this, e);
            }
        }
    }
}
