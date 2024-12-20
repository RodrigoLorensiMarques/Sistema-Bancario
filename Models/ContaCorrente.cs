using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaCorrente :ContaBancaria
    {
        public decimal Credito { get; set; }
        public List<ContaCorrente> ContasCorrente { get; set; } = new List<ContaCorrente>();


        public List<ContaCorrente> AbrirConta(string Nome, string Senha, string Tipo, List<string> NumerosContasBancarias)
        {   
            ContaCorrente NovaContaCorrente = new ContaCorrente();
            NovaContaCorrente.NomeProprietario = Nome;
            NovaContaCorrente.Senha = Senha;
            NovaContaCorrente.Numero = NovaContaCorrente.GerarNumeroConta(NumerosContasBancarias);
            NovaContaCorrente.TipoConta = Tipo;
            NovaContaCorrente.Saldo = 0;
            NovaContaCorrente.Credito = 500;

            ContasCorrente.Add(NovaContaCorrente);
            Console.WriteLine("Conta corrente criada com sucesso!");
            Console.WriteLine($"Número da conta: {NovaContaCorrente.Numero}");
            Console.WriteLine($"Seu crédito é de {NovaContaCorrente.Credito}");

            return ContasCorrente;
        }


        public void UsarCredito()
        {

        }

        public void AcessarContaCorrente (string NumeroConta, string SenhaConta, string TipoConta, List<ContaCorrente> ContasCorrente)
        {   
            for (int i=0; i<ContasCorrente.Count();i++ )
            {   
                if (ContasCorrente[i].Numero == NumeroConta)
                {
                    if (ContasCorrente[i].Senha == SenhaConta)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Acesso liberado!");
                        ContaBancaria Acesso = new ContaBancaria();
                        Acesso = ContasCorrente[i];
                        Acesso.AbrirMenu(Acesso);
                    }

                    else
                    {
                        Console.WriteLine("Senha Incorreta!");
                    }
                }
                else
                {
                    Console.WriteLine("Conta não localizada");
                }

            }
        }
    }
}