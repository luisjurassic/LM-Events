using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidaAtualizarEvento
    {
        public ListaDeErros ValidarEvento(DBEvento s)
        {
            ListaDeErros result = new ListaDeErros();

            if (string.IsNullOrWhiteSpace(Convert.ToString(s.TipoEvento_id)))
            {
                result.AddErro("O tipo de evento deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(s.NomeEvento))
            {
                result.AddErro("O nome do evento deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(s.HoraInicio)))
            {
                result.AddErro("A data de enceramento deve ser informada.");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(s.HoraFim)))
            {
                result.AddErro("A data de inicio deve ser informada.");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(s.ValorEvento)))
            {
                result.AddErro("O valor do evento deve ser informado.");
            }
            return result;
        }
    }
}
