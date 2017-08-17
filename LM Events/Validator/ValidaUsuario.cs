using LM_Events.DataObjectBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LM_Events.Validator
{
    class ValidaUsuario
    {
        public ListaDeErros validaUsuario(DBUsuario s)
        {
            ListaDeErros result = new ListaDeErros();

            if (s.Permissao_id == 0)
            {
                result.AddErro("Nivel de permissão deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(s.Nome))
            {
                result.AddErro("O nome deve ser informado.");
            }
            else if (s.Nome.Length <4 || s.Nome.Length > 30)
            {
                result.AddErro("O nome deve conter entre 4 e 30 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(s.Email))
            {
                result.AddErro("O email deve ser informado.");
            }
            else if (s.Email.Length <10 || s.Email.Length >50)
            {
                result.AddErro("O email deve conter entre 10 e 50 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(s.Usuario))
            {
                result.AddErro("O usuário deve ser informado.");
            }
            else if (s.Usuario.Length <6 || s.Usuario.Length > 15)
            {
                result.AddErro("O usuário deve conter entre 6 e 15 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(s.Senha))
            {
                result.AddErro("A senha deve ser informada.");
            }
            else if (string.IsNullOrWhiteSpace(s.ConfirmaSenha))
            {
                result.AddErro("A confirmação de senha deve ser informada.");
            }
            else if (s.Senha != s.ConfirmaSenha)
            {
                result.AddErro("Senhas são diferentes.");
            }          
            if (File.Exists(s.ImagemPerfil))
            {
                DialogResult rlt = MessageBox.Show("Imagem de perfil já existe, dejesa substituir?", "Informação!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rlt == DialogResult.Yes)
                {
                    File.Delete(s.ImagemPerfil);
                }
            }
            return result;
        }
    }
}
