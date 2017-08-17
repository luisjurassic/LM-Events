using LM_Events.DataObjectBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_Events.Validator
{
    class ValidaAtualizarPessoaJuridica
    {
        public ListaDeErros ValidarEmpresa(DBPessoaJuridica validaEmpesa)
        {

            ListaDeErros result = new ListaDeErros();
            
            if (string.IsNullOrWhiteSpace(validaEmpesa.NomeFantasia))
            {
                result.AddErro("O Nome da empresa deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(validaEmpesa.RazaoSocial))
            {
                result.AddErro("A Razão Social deve ser informada.");
            }
            if (string.IsNullOrWhiteSpace(validaEmpesa.InscricaoEstadual))
            {
                result.AddErro("A Inscrição Estadual deve ser informada.");
            }
            if (validaEmpesa.RamoAtividade_id == 0)
            {
                result.AddErro("O ramo de atividade não foi informado.");
            }
            
            if (string.IsNullOrWhiteSpace(validaEmpesa.Telefone))
            {
                result.AddErro("O Telefone deve ser informado.");
            }
           
            return result;
        }
    }
}
