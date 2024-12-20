using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaPoupanca :ContaBancaria
    {
        public List<ContaPoupanca> ContasPoupanca { get; set; } = new List<ContaPoupanca>();
        public List<ContaPoupanca> AbrirConta(string Nome, string Senha, string Tipo, List<string> NumerosContasBancarias)
        {  
            ContaPoupanca NovaContaPoupanca = new ContaPoupanca();
            NovaContaPoupanca.NomeProprietario = Nome;
            NovaContaPoupanca.Senha = Senha;
            NovaContaPoupanca.Numero = NovaContaPoupanca.GerarNumeroConta(NumerosContasBancarias);
            NovaContaPoupanca.TipoConta = Tipo;
            NovaContaPoupanca.Saldo = 0;

            ContasPoupanca.Add(NovaContaPoupanca);

            Console.WriteLine("Conta poupança criada com sucesso!");
            Console.WriteLine($"Número da conta: {NovaContaPoupanca.Numero}");

            return ContasPoupanca;
        }

        public void AcessarContaPoupanca (string NumeroConta, string SenhaConta, string TipoConta, List<ContaPoupanca> ContasPoupanca)
        {   
            for (int i=0; i<ContasPoupanca.Count();i++ )
            {   
                if (ContasPoupanca[i].Numero == NumeroConta)
                {
                    if (ContasPoupanca[i].Senha == SenhaConta)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Acesso liberado!");
                        ContaBancaria Acesso = new ContaBancaria();
                        Acesso = ContasPoupanca[i];
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