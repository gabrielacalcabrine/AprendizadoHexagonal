namespace AplicacaoHexagonal.Domain.ValueObject
{
    public class CNPJ
        {
            public string Valor { get; }

            public CNPJ(string cnpj)
            {
                if (!ValidarCNPJ(cnpj))
                {
                    throw new ArgumentException("CNPJ inválido");
                }

                Valor = cnpj;
            }

            // Método para validar o CNPJ
            private bool ValidarCNPJ(string cnpj)
            {
                // Lógica de validação do CNPJ            
               
                if (string.IsNullOrWhiteSpace(cnpj) || cnpj.Length != 14 || TemDigitosRepetidos(cnpj))
                {
                    return false;
                }

                // Mais regras de validação podem ser implementadas aqui

                return true;
            }

            // Verifica se o CNPJ possui dígitos repetidos
            private bool TemDigitosRepetidos(string cnpj)
            {
                return cnpj[0..14].Distinct().Count() == 1;
            }
        }
    }


