using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaBancaria
    {
        public string NomeProprietario { get; set; }
        public string Numero { get; set; }
        public string Senha { get; set; }
        public decimal Saldo { get; set; } = 0;
        public string TipoConta { get; set; }


        public decimal Sacar ()
        {    
            decimal valor = 0;
            Console.Write("Digite o valor que deseja sacar: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor <1)
            {
                Console.WriteLine("O valor de saque deve ser maior que R$0,00 ");
            }

            else
            {
                if (valor < Saldo)
                {
                Saldo = Saldo - valor;
                Console.WriteLine("Saque realizado com sucesso!");
                }

                else
                {
                    Console.WriteLine("O seu saldo é insuficiente para essa operação");
                }
            }

            return Saldo;
        }

        public decimal Depositar()
        {
            decimal valor = 0;
            Console.Write("Digite o valor que desejada depositar: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor <1)
            {
                Console.WriteLine("O valor para deposito deve ser maior do que R$0,00");
            }

            else
            {
                Saldo = valor;
                Console.WriteLine($"Depósito de R${valor} realizado com sucesso!");
            }
            return Saldo;
        }

        public List<ContaBancaria> Transferir (List<ContaBancaria> contas)
        {
            Console.Write("Digite o número da conta que deseja transferir: ");
            string numeroContaDestino =Console.ReadLine();

            Console.Write("Digite o valor que deseja transferir: ");
            decimal valor = decimal.Parse(Console.ReadLine());

            if (valor <1)
            {
                Console.WriteLine("O valor deve ser maior do que R$0.00");
            }
            
            else if (valor > Saldo)
            {
                Console.WriteLine("O saldo é insuficiente para realizar essa operação.");
            }

            bool contaLocalizada = false;
            ContaBancaria contaDestino = new ContaBancaria();
            foreach (ContaBancaria item in contas)
            {
                if (item.Numero == numeroContaDestino)
                {
                    contaLocalizada = true;
                    contaDestino = item;
                }
            }
            if (contaLocalizada ==true)
            {
                contaDestino.Saldo +=valor;
                Saldo -= valor;
                Console.WriteLine($"\nTransferencia de R${valor} realizada para {contaDestino.NomeProprietario}!");
            }

            else
            {
                Console.WriteLine("Conta destino não localizada! ");
            }

            return contas;
        }

    }
}