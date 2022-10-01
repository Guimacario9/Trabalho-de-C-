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

namespace Clinica.visao
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
            this.SelectPacientes();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();

            try
            {
                string sql = "INSERT INTO PACIENTE (idPaciente, nome, telefone, sexo, convenio, DataNascimento, profissao, tiposangue)"+
                                                    "VALUES (@idpaciente, @nome, @telefone, @sexo, @convenio, @DataNascimento, @profissao, @tiposangue)";
                SqlCommand sqlGravar = new SqlCommand(sql, conn);
                sqlGravar.Parameters.AddWithValue("@idpaciente", txtId.Text);
                sqlGravar.Parameters.AddWithValue("@nome", txtNome.Text);
                sqlGravar.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                
                if(rbMasculino.Checked)
                    sqlGravar.Parameters.AddWithValue("@sexo", "M");
                else
                    sqlGravar.Parameters.AddWithValue("@sexo", "F");

                sqlGravar.Parameters.AddWithValue("@convenio", cbConvenio.Text);
                sqlGravar.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(calendarioPaciente.SelectionRange.Start.ToLongDateString()));
                sqlGravar.Parameters.AddWithValue("@profissao", cbProfissao.Text);

                if(rbTipoAmais.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "A+");
                else if(rbTipoBmais.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "B+");
                else if (rbTipoABmais.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "AB+");
                else if(rbTipoOmais.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "O+");
                else if (rbTipoAmenos.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "A-");
                else if (rbTipoBmenos.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "B-");
                else if (rbTipoABmenos.Checked)
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "B-");
                else
                    sqlGravar.Parameters.AddWithValue("@tiposangue", "O-");
                
                sqlGravar.ExecuteNonQuery();//executar
                MessageBox.Show("Paciente cadastrado com sucesso!");
                this.SelectPacientes();
                this.Limpar();

            }
            catch(SqlException ex)
            {
                MessageBox.Show("Erro ao cadastrar " + ex);
            }
            finally {
                conn.Close();
            }

        }

        public void SelectPacientes() {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "SELECT * FROM PACIENTE";
                SqlCommand sqlSelect = new SqlCommand(sql, conn);
                SqlDataReader reader = sqlSelect.ExecuteReader();
                DataTable dtTable = new DataTable();
                dtTable.Load(reader);
                gridPacientes.DataSource = dtTable;
                reader.Close();
            }
            catch
            {
                statusBar.Text = "Pacientes listados!";
            }
            finally {
                conn.Close();
            }
        }
        public void Limpar() {
            txtNome.Text = "";
            txtId.Text = "";
            txtTelefone.Text = "";
            cbConvenio.SelectedIndex = 0;
            cbProfissao.SelectedIndex = 0;
            rbFeminino.Checked = false;
            rbMasculino.Checked = false;
            rbTipoAmais.Checked = false;
            rbTipoABmais.Checked = false;
            rbTipoBmais.Checked = false;
            rbTipoOmais.Checked = false;
            rbTipoAmenos.Checked = false;
            rbTipoABmenos.Checked = false;
            rbTipoBmenos.Checked = false;
            rbTipoOmenos.Checked = false;
            txtId.ReadOnly = false;
        }
        private void calendarioPaciente_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show("dat " + Convert.ToDateTime(calendarioPaciente.SelectionRange.Start.ToLongDateString()));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            this.SelectPacientes();
        }

        private void gridPacientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridPacientes.Rows.Count > 0)
            {
                txtId.Text = gridPacientes.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = gridPacientes.SelectedRows[0].Cells[1].Value.ToString();
                txtTelefone.Text = gridPacientes.SelectedRows[0].Cells[2].Value.ToString();
                //rbMasculino.Checked = gridPacientes.SelectedRows[0].Cells[3].Value.ToString();
                cbConvenio.Text = gridPacientes.SelectedRows[0].Cells[4].Value.ToString();
                calendarioPaciente.SelectionStart = Convert.ToDateTime(gridPacientes.SelectedRows[0].Cells[5].Value.ToString());
                cbProfissao.Text = gridPacientes.SelectedRows[0].Cells[6].Value.ToString();
                rbMasculino.Checked = true;
                //rbTipoAmais.Checked = true;
                string sangue = gridPacientes.SelectedRows[0].Cells[7].Value.ToString();
                if (sangue == "A+")
                    rbTipoAmais.Checked = true;
                else if (sangue == rbTipoBmais.Text)
                    rbTipoBmais.Checked = true;
                else if (sangue == rbTipoBmais.Text)
                    rbTipoBmais.Checked = true;
                else if (sangue == rbTipoABmais.Text)
                    rbTipoABmais.Checked = true;
                else if (sangue == rbTipoOmais.Text)
                    rbTipoOmais.Checked = true;
                else if (sangue == rbTipoAmenos.Text)
                    rbTipoAmenos.Checked = true;
                else if (sangue == rbTipoBmenos.Text)
                    rbTipoBmenos.Checked = true;
                else if (sangue == rbTipoABmenos.Text)
                    rbTipoABmenos.Checked = true;
                else
                    rbTipoOmenos.Checked = true;
                txtId.ReadOnly = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();

            try
            {
                string sql = "UPDATE paciente SET nome = @nome , telefone = @telefone, sexo = @sexo, convenio = @convenio, DataNascimento = @DataNascimento, profissao = @profissao, tiposangue = @tiposangue WHERE idpaciente = @idpaciente";
                SqlCommand sqlEditar = new SqlCommand(sql, conn);
                sqlEditar.Parameters.AddWithValue("@idpaciente", txtId.Text);
                sqlEditar.Parameters.AddWithValue("@nome", txtNome.Text);
                sqlEditar.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                if (rbMasculino.Checked)
                    sqlEditar.Parameters.AddWithValue("@sexo", "M");
                else
                    sqlEditar.Parameters.AddWithValue("@sexo", "F");

                sqlEditar.Parameters.AddWithValue("@convenio", cbConvenio.Text);
                sqlEditar.Parameters.AddWithValue("@DataNascimento", Convert.ToDateTime(calendarioPaciente.SelectionRange.Start.ToLongDateString()));
                sqlEditar.Parameters.AddWithValue("@profissao", cbProfissao.Text);

                if (rbTipoAmais.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "A+");
                else if (rbTipoBmais.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "B+");
                else if (rbTipoABmais.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "AB+");
                if (rbTipoOmais.Checked)
                     sqlEditar.Parameters.AddWithValue("@tiposangue", "O+");
                else if (rbTipoAmenos.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "A-");
                else if (rbTipoBmenos.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "B-");
                else if (rbTipoABmenos.Checked)
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "AB-");
                else
                    sqlEditar.Parameters.AddWithValue("@tiposangue", "O-");

                sqlEditar.ExecuteNonQuery();//executar
                MessageBox.Show("Edicao realizada com sucesso!");
                statusBar.Text = "Edicao realizada com sucesso!";
                this.SelectPacientes();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao editar " + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "DELETE FROM paciente WHERE idpaciente = @idpaciente";
                SqlCommand Deletar = new SqlCommand(sql, conn);
                Deletar.Parameters.AddWithValue("@idpaciente", txtId.Text);
                Deletar.ExecuteNonQuery();
                MessageBox.Show("Paciente excluido do id = " + txtId.Text);
                this.SelectPacientes();
                txtId.ReadOnly = true;
                statusBar.Text = "Paciente excluido com sucesso!";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao excluir " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void gridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}
