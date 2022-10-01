using Clinica.modal.DAO;
using Clinica.modal.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.controller
{
    class UsuarioCTR
    {
        public bool selectUsuario(string nomeUser, string senhaUser)
        {
            bool situacaoUser = false;
            try
            {
                UsuarioDTO userDTO = new UsuarioDTO();
                userDTO.Username = nomeUser;
                userDTO.Password = senhaUser;

                UsuarioDAO userDAO = new UsuarioDAO();
                if (userDAO.selectUsuario(userDTO) != null)
                {
                    situacaoUser = true;
                }
            }
            catch (SqlException erroCTR)
            {
                MessageBox.Show("Erro no metodo selectUsuarioCTR:" + erroCTR);
                situacaoUser = false;
            }
            return situacaoUser;
        }
    }
}
