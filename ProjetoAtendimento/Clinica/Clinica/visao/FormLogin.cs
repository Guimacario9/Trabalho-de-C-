using Clinica.controller;
using Clinica.visao.Telas_de_Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.visao
{
    public partial class FormLogin : Form
    {
        FormSplash formSplash;
        UsuarioCTR userCTR;
        public FormLogin()
        {
            InitializeComponent();
            userCTR = new UsuarioCTR();
            formSplash = new FormSplash();
            this.Hide();
            formSplash.ShowDialog();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnOk_Click(this, e);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //chmar o metodo selectUsuario da classe UsuarioCTR (controller)
            if (userCTR.selectUsuario(txtUsername.Text, txtPassword.Text))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                this.Hide();
                FormPrincipal formPcp = new FormPrincipal();
                formPcp.ShowDialog();
            }
            else
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Usuario Não Localizado!!!");
            }
        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            //Para o timer
            timerPrincipal.Stop();
            //Fecha o formSplash
            formSplash.Close();
            //Mostra o formLogin
            this.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroUsuario frmusuario = new FormCadastroUsuario();
            frmusuario.Show();
        }
    }
}
