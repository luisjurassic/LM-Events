using LM_Events.DataAcessLayer;
using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidaAtualizarDesconto
    {
        public ListaDeErros ValidarDescontos(DBDescontos descontos)
        {
            ListaDeErros result = new ListaDeErros();

            if (string.IsNullOrWhiteSpace(descontos.Descricao))
            {
                result.AddErro("Tipo de desconto não informado. Favor digitar um tipo de desconto.");
            }
            else if (descontos.Descricao.Length < 4 || descontos.Descricao.Length > 20)
            {
                result.AddErro("Tipo de desconto deve conter entre 4 e 20 caracteres.");
            }
           
            if (descontos.PcentDesconto <= 0)
            {
                result.AddErro("Porcentagem não informada. Digite a procentagem desejada.");
            }
            return result;
        }
    }
}
