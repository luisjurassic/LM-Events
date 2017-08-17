using LM_Events.DataObjectBase.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidatorEvento
    {
        public ListaDeErros ValidarEvento(DBEvento s)
        {
            ListaDeErros result = new ListaDeErros();

            if (s.TipoEvento_id == 0)
            {
                result.AddErro("O tipo de evento deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(s.NomeEvento))
            {
                result.AddErro("O nome do evento deve ser informado.");
            }
            else if (s.NomeEvento == "Nome do evento...")
            {
                result.AddErro("O nome do evento deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(s.HoraInicio)))
            {
                result.AddErro("A hora de inicio do evento deve ser informada.");
            }
            if (s.HoraInicio == "  :")
            {
                result.AddErro("A hora de inicio do evento deve ser informada.");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(s.HoraFim)))
            {
                result.AddErro("A hora do fim do evento deve ser informada.");
            }
            if (s.HoraFim == "  :")
            {
                result.AddErro("A hora do fim do evento deve ser informada.");
            }
            if (string.IsNullOrWhiteSpace(Convert.ToString(s.ValorEvento)))
            {
                result.AddErro("O valor do evento deve ser informado.");
            }
            return result;
        }
    }
}
