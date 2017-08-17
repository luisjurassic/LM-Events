using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ListaDeErros
    {
         public List<string> erros = new List<string>();

        public void AddErro(string erro)
        {
            erros.Add(erro);
        }

        public bool IsValid
        {
            get
            {
                return erros.Count == 0;//se não tiver nenhum erro é válido
            }
        }
    
    }
}
