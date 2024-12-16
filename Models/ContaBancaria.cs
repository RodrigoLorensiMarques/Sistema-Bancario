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


        public int GerarNumeroConta ()
        {
            return Numero = 0;
        }


        public void AbrirConta (string TipoConta, string Nome, string Senha, List<ContaBancaria>ContasBancarias)
        {
            ContaBancaria NovaConta = new ContaBancaria();

            NovaConta.NomeProprietario = Nome;
            NovaConta.Numero = NovaConta.GerarNumeroConta();
            NovaConta.Senha = Senha;
            NovaConta.Saldo = 0;
            NovaConta.TipoConta = TipoConta;

            if (TipoConta.ToLower() == "corrente")
            {   
                ContaCorrente NovaContaCorrente = new ContaCorrente();
                NovaContaCorrente.AbrirContaCorrente(NovaConta, ContasBancarias);
            }

            else 
            {
                ContaPoupanca NovaContaPoupanca = new ContaPoupanca();
                NovaContaPoupanca.AbrirContaPoupanca(NovaConta, ContasBancarias); 
            }

        }


        public void AcessarConta (int NumeroConta, string SenhaConta, List<ContaBancaria>ContasBancarias)
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
        }

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
                        Conta.Transferir();
                        break;

                    case 5:
                        ContaCorrente Corrente = new ContaCorrente();
                        Corrente = (ContaCorrente)Conta;
                        Console.WriteLine(Corrente.Credito);
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
                Console.WriteLine("O valor para deposito deve ser maior do que R$0");
            }

            else
            {
                Conta.Saldo = ValorDeposito;
                Console.WriteLine($"Depósito de R${ValorDeposito} realizado com sucesso!");
            }
        }

        public void Transferir ()
        {

        }

    }
}