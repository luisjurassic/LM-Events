using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidaAtualizarEndereco
    {
        public ListaDeErros Validar(DBEndereco f)
        {
            ListaDeErros result = new ListaDeErros();

            if (string.IsNullOrWhiteSpace(f.CEP))
            {
                result.AddErro("O CEP deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(f.Rua))
            {
                result.AddErro("O nome da Rua deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(f.Bairro))
            {
                result.AddErro("O nome do Bairro deve ser informado.");
            }
            
            if (f.Cidade_id == 0)
            {
                result.AddErro("O nome da Cidade deve ser informado.");
            }
            if (f.Estado_id == 0)
            {
                result.AddErro("A Unidade Federatíva deve ser informada.");
            }
            return result;
        }
    }
}
