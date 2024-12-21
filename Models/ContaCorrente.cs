using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaCorrente :ContaBancaria
    {
        public ContaCorrente (string nome, string senha, string numero)
        {
            NomeProprietario = nome;
            Senha = senha;
            Numero = numero;
            TipoConta = "corrente";
            Credito = 500;
        }

        public ContaCorrente ()
        {

        }


        public decimal Credito { get; set; }


        public decimal UsarCredito()
        {
            Console.Write("Qual valor de crédito deseja utilizar? ");
            decimal valor = decimal.Parse(Console.ReadLine());

            if (valor <1)
            {
                Console.WriteLine("O valor de deve ser maior que R$0,00 ");
            }

            else
            {
                if (valor < Credito)
                {
                Credito = Credito - valor;
                Console.WriteLine("Crédito utilizado!");
                }

                else
                {
                    Console.WriteLine("O seu crédito é insuficiente para essa operação");
                }
            }
            return Credito;    
        }   
    }
}