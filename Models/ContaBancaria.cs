using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaBancaria
    {
        public string NomeProprietario { get; set; }
        public int Numero { get; set; }
        public string Senha { get; set; }
        public decimal Saldo { get; set; }
        public string TipoConta { get; set; }

        private List<int> NumerosContasBancarias;


        public int GerarNumeroConta ()
        {
            return Numero = 0;
        }


        /*public void AcessarConta (int NumeroConta, string SenhaConta, string TipoConta)
        {   
            for (int i=0; i<ContasBancarias.Count();i++ )
            {   
                if (ContasBancarias[i].Numero == NumeroConta)
                {
                    if (ContasBancarias[i].Senha == SenhaConta)
                    {
                        Console.WriteLine("Acesso liberado!");
                        ContaBancaria Acesso = new ContaBancaria();
                        Acesso = ContasBancarias[i];
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
        }*/

        public void AbrirMenu(ContaBancaria Conta)
        {
            int Opc = 0;
            do
            {
                Console.WriteLine($"Bem vindo {Conta.NomeProprietario}!");
                Console.WriteLine("");
                Console.WriteLine("[1] Verificar saldo");
                Console.WriteLine("[2] Depositar");
                Console.WriteLine("[3] Sacar");
                Console.WriteLine("[4] Transferir");

                if (Conta.TipoConta == "corrente")
                {
                    Console.WriteLine("[5] Verificar Credito");
                }

                Console.WriteLine("Digite a opção desejada: ");
                Opc = int.Parse(Console.ReadLine());

                switch (Opc)
                {
                    case 1:
                        Console.WriteLine($"O saldo da sua conta é {Conta.Saldo}");
                        break;
                    case 2:
                        decimal ValorDeposito = 0;
                        Console.Write("Digite o valor que desejada depositar: ");
                        ValorDeposito = decimal.Parse(Console.ReadLine());
                        Conta.Depositar(Conta, ValorDeposito);
                        break;
                    case 3:
                        decimal ValorSaque = 0;
                        Console.Write("Digite o valor que deseja sacar: ");
                        ValorSaque = decimal.Parse(Console.ReadLine());
                        Conta.Sacar(Conta, ValorSaque);
                        break;
                    case 4:
                        Console.Write("Digite o número da conta que deseja transferir: ");
                        int NumeroContaDestino = int.Parse(Console.ReadLine());

                        Console.Write("Digite o valor que deseja transferir: ");
                        decimal ValorTED = decimal.Parse(Console.ReadLine());


                        //Conta.Transferir(Conta, NumeroContaDestino, ValorTED);
                        break;

                    case 5:
                        ContaCorrente Corrente = new ContaCorrente();
                        Corrente = (ContaCorrente)Conta;
                        Console.WriteLine($"Seu crédito atual é de R${Corrente.Credito}");
                        break;                  

                    default:
                        Console.WriteLine("Essa opção não existe!");
                        break;
                }
             
             }
            while (true) ;

        }


        public void Sacar (ContaBancaria Conta, decimal ValoraSaque)
        {
            if (ValoraSaque <1)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$0 ");
            }

            else
            {
                if (ValoraSaque < Conta.Saldo)
                {
                Conta.Saldo = Conta.Saldo - Saldo;
                Console.WriteLine("Saque realizado com sucesso!");
                }

                else
                {
                    Console.WriteLine("O seu saldo é insuficiente para essa operação");
                }
            }
        }


        public void Depositar(ContaBancaria Conta, decimal ValorDeposito)
        {
            if (ValorDeposito <1)
            {
                Console.WriteLine("O valor para deposito deve ser maior do que R$0,00");
            }

            else
            {
                Conta.Saldo = ValorDeposito;
                Console.WriteLine($"Depósito de R${ValorDeposito} realizado com sucesso!");
            }
        }

        /*public void Transferir (ContaBancaria ContaOrigem, int NumeroContaDestino, decimal ValorTED)
        {
            if (ValorTED <1)
            {
                Console.WriteLine("O valor deve ser maior do que R$0.00");
            }
            
            else if (ValorTED > ContaOrigem.Saldo)
            {
                Console.WriteLine("O saldo é insuficiente para realizar essa operação.");
            }

            bool ContaLocalizada = false;
            ContaBancaria ContaDestino = new ContaBancaria();
            foreach (ContaBancaria item in ContasBancarias)
            {
                if (item.Numero == NumeroContaDestino)
                {
                    ContaLocalizada = true;
                    ContaDestino = item;
                }
            }

            if (ContaLocalizada ==true)
            {
                ContaDestino.Saldo +=ValorTED;
            }

            else
            {
                Console.WriteLine("Conta destino não localizada! ");
            }


        }*/

    }
}