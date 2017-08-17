﻿using LM_Events.DataObjectBase;

namespace LM_Events.Validator
{
    class ValidaPessoaFisica
    {
        public ListaDeErros Validar(DBPessoaFisica f)
        {
            ListaDeErros result = new ListaDeErros();


            //Verifica se o nome foi informado
            if (f.TipoCadastro_id == 0)
            {
                result.AddErro("O Tipo de cadastro deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(f.Nome))
            {
                result.AddErro("O nome deve ser informado.");
            }
            //Verifica se o nome possui mais do que 4 letras ou menos do que 50
            else if (f.Nome.Length < 4 || f.Nome.Length > 50)
            {
                result.AddErro("O nome deve conter entre 4 e 50 caracteres.");
            }
            if (string.IsNullOrWhiteSpace(f.CPF))
            {
                result.AddErro("O CPF deve ser informado.");
            }
            //Válida o CPF
            else if (!(ValidaCPF.IsCpf(f.CPF)))
            {
                result.AddErro("Cpf invalido.");
            }
            
            if (f.EstadoCivil_id == 0)
            {
                result.AddErro("O Estado Civil deve ser informado.");
            }
            
            if (string.IsNullOrWhiteSpace(f.TelefoneResidencial))
            {
                result.AddErro("O número de Telefone Fixo deve ser informado.");
            }
            if (string.IsNullOrWhiteSpace(f.Sexo))
            {
                result.AddErro("O sexo deve ser informado.");
            }
           
            return result;
        }
    }
}
