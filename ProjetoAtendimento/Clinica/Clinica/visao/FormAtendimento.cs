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
    public partial class FormAtendimento : Form
    {
        public FormAtendimento()
        {
            InitializeComponent();
            txtIdPaciente.ReadOnly = true;
            txtIdadePaciente.ReadOnly = true;
            txtNomePaciente.ReadOnly = true;
            this.SelectPacientes();
            this.SelectConsultas();
        }


        public void SelectPacientes()
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "SELECT idpaciente, nome, datediff(yy, DataNascimento, getdate()) as Idade FROM PACIENTE ORDER BY idpaciente DESC";
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
            finally
            {
                conn.Close();
            }
        }

        public void SelectConsultas()
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "SELECT c.idconsulta, p.nome, datediff(yy, p.DataNascimento, getdate()) as Idade, p.telefone, c.NomeMedico as Medico, c.DataConsulta, c.Historico, c.ExamesRealizados as Exames, c.MedicamentosUtilizados as Medicamentos FROM " +
                             "Consulta c INNER JOIN paciente p ON c.idPaciente = p.idPaciente ORDER BY c.idconsulta DESC";
                SqlCommand sqlSelect = new SqlCommand(sql, conn);
                SqlDataReader reader = sqlSelect.ExecuteReader();
                DataTable dtTable = new DataTable();
                dtTable.Load(reader);
                dtConsultas.DataSource = dtTable;
                reader.Close();
            }
            catch
            {
                statusBar.Text = "Consultas listadas!";
            }
            finally
            {
                conn.Close();
            }
        }

        private void gridPacientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridPacientes.Rows.Count > 0)
            {
                txtIdPaciente.Text = gridPacientes.SelectedRows[0].Cells[0].Value.ToString();
                txtNomePaciente.Text = gridPacientes.SelectedRows[0].Cells[1].Value.ToString();
                txtIdadePaciente.Text = gridPacientes.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
         SqlConnection conn = Conexao.getConexao();
         try
         {
             string sql = "INSERT INTO consulta (idConsulta, idPaciente, DataConsulta, NomeMedico, ExamesRealizados, MedicamentosUtilizados, Alergico, Historico) VALUES"+
                                               "(@idConsulta, @idPaciente, @DataConsulta, @NomeMedico, @ExamesRealizados, @MedicamentosUtilizados, @Alergico, @Historico)";
             SqlCommand Inserir = new SqlCommand(sql, conn);
             Inserir.Parameters.AddWithValue("@idConsulta", txtIdConsulta.Text);
             Inserir.Parameters.AddWithValue("@idPaciente", txtIdPaciente.Text);
             Inserir.Parameters.AddWithValue("@DataConsulta", Convert.ToDateTime(calendarioConsulta.SelectionRange.Start.ToLongDateString()));
             Inserir.Parameters.AddWithValue("@NomeMedico", cbMedico.Text);
             string linhaExame = "";
             int total = ckExames.Items.Count;
             for (int i = 0; i < total; i++)
             {
                 // verifica se o checklist esta selecionado
                 if (ckExames.GetItemCheckState(i) == CheckState.Checked)
                 {
                     linhaExame += ckExames.Items[i].ToString() + ",";
                 }
             }
             Inserir.Parameters.AddWithValue("@ExamesRealizados", linhaExame);
             string linhaMedicamentos = "";
             int total2 = ckMedicamentos.Items.Count;
             for (int i = 0; i < total2; i++)
             {
                 // verifica se o checklist esta selecionado
                 if (ckMedicamentos.GetItemCheckState(i) == CheckState.Checked)
                 {
                     linhaMedicamentos += ckMedicamentos.Items[i].ToString() + ",";
                 }
             }
             Inserir.Parameters.AddWithValue("@MedicamentosUtilizados", linhaMedicamentos);
             if(rbAlergicoSim.Checked)
                 Inserir.Parameters.AddWithValue("@Alergico", "S");
             else
                 Inserir.Parameters.AddWithValue("@Alergico", "N");
             Inserir.Parameters.AddWithValue("@Historico", txtHistorico.Text);
             Inserir.ExecuteNonQuery();
             MessageBox.Show("Consulta cadastrada com sucesso!");
             this.SelectConsultas();
             this.Limpar();
         }
         catch(SqlException ex)
         {
             MessageBox.Show("Erro ao cadastrar " + ex);
         }
         finally 
         {
             conn.Close();
         }
        }

        public void Limpar()
        {
            txtHistorico.Text = "";
            txtIdPaciente.Text = "";
            txtIdConsulta.Text = "";
            cbMedico.SelectedIndex = 0;
            rbAlergicoNao.Checked = false;          
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "UPDATE consulta SET DataConsulta = @DataConsulta, NomeMedico = @NomeMedico, ExamesRealizados = @ExamesRealizados, MedicamentosUtilizados = @MedicamentosUtilizados, Alergico = @Alergico, Historico = @Historico " +
                                                  "WHERE idConsulta = @idConsulta";
                SqlCommand Editar = new SqlCommand(sql, conn);
                Editar.Parameters.AddWithValue("@idConsulta", txtIdConsulta.Text);
                Editar.Parameters.AddWithValue("@DataConsulta", Convert.ToDateTime(calendarioConsulta.SelectionRange.Start.ToLongDateString()));
                Editar.Parameters.AddWithValue("@NomeMedico", cbMedico.Text);
                string linhaExame = "";
                int total = ckExames.Items.Count;
                for (int i = 0; i < total; i++)
                {
                    // verifica se o checklist esta selecionado
                    if (ckExames.GetItemCheckState(i) == CheckState.Checked)
                    {
                        linhaExame += ckExames.Items[i].ToString() + ",";
                    }
                }
                Editar.Parameters.AddWithValue("@ExamesRealizados", linhaExame);
                string linhaMedicamentos = "";
                int total2 = ckMedicamentos.Items.Count;
                for (int i = 0; i < total2; i++)
                {
                    // verifica se o checklist esta selecionado
                    if (ckMedicamentos.GetItemCheckState(i) == CheckState.Checked)
                    {
                        linhaMedicamentos += ckMedicamentos.Items[i].ToString() + ",";
                    }
                }
                Editar.Parameters.AddWithValue("@MedicamentosUtilizados", linhaMedicamentos);
                if (rbAlergicoSim.Checked)
                    Editar.Parameters.AddWithValue("@Alergico", "S");
                else
                    Editar.Parameters.AddWithValue("@Alergico", "N");
                Editar.Parameters.AddWithValue("@Historico", txtHistorico.Text);
                Editar.ExecuteNonQuery();
                MessageBox.Show("Alteração feita com sucesso!");
                this.SelectConsultas();
                this.Limpar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao Alteração " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtConsultas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtConsultas.Rows.Count > 0)
            {
                txtIdConsulta.Text = dtConsultas.SelectedRows[0].Cells[0].Value.ToString();
                cbMedico.Text = dtConsultas.SelectedRows[0].Cells[4].Value.ToString();
                calendarioConsulta.SelectionStart = Convert.ToDateTime(dtConsultas.SelectedRows[0].Cells[5].Value.ToString());
                txtHistorico.Text = dtConsultas.SelectedRows[0].Cells[6].Value.ToString();
                string exame = dtConsultas.SelectedRows[0].Cells[7].Value.ToString();
                
                /*string[] selecionados = exame.Split(',');
                string teste = "";
                for (int i = 0; i < selecionados.Count(); i++ )
                {
                    if (ckExames.Text == selecionados[i]){
                        ckExames.SetItemChecked(i, true);
                        }
                    //teste += selecionados[i]+" - ";
                }
                //MessageBox.Show(teste);*/
            }
            txtIdConsulta.ReadOnly = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdadePaciente.Text = "";
            txtIdConsulta.Text = "";
            txtIdadePaciente.Text = "";
            txtHistorico.Text = "";
            txtNomePaciente.Text = "";
            cbMedico.SelectedIndex = 0;
            rbAlergicoNao.Checked = false;
            rbAlergicoSim.Checked = false;
            int total2 = ckMedicamentos.Items.Count;
            int total = ckExames.Items.Count;
            for (int i = 0; i < total2; i++)
            {
                ckMedicamentos.SetItemChecked(i, false);
            }
            for (int i = 0; i < total; i++)
            {
                ckExames.SetItemChecked(i, false);
            }
            txtIdConsulta.ReadOnly = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.getConexao();
            try
            {
                string sql = "DELETE FROM consulta WHERE idconsulta = @idconsulta";
                SqlCommand Deletar = new SqlCommand(sql, conn);
                Deletar.Parameters.AddWithValue("@idconsulta", txtIdConsulta.Text);
                Deletar.ExecuteNonQuery();
                MessageBox.Show("Consulta excluido do id = " + txtIdConsulta.Text);
                this.SelectPacientes();
                this.SelectConsultas();
                txtIdConsulta.ReadOnly = true;
                statusBar.Text = "Consulta excluida com sucesso!";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
