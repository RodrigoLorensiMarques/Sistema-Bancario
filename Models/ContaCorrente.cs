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

        public void AbrirConta(string Nome, string Senha, string Tipo)
        {   
            ContaCorrente NovaContaCorrente = new ContaCorrente();

            NovaContaCorrente.NomeProprietario = Nome;
            NovaContaCorrente.Senha = Senha;
            NovaContaCorrente.Numero = NovaContaCorrente.GerarNumeroConta();
            NovaContaCorrente.TipoConta = Tipo;
            NovaContaCorrente.Saldo = 0;

            NovaContaCorrente.Credito = 500;

            ContasCorrente.Add(NovaContaCorrente);

            Console.WriteLine("Conta corrente criada com sucesso!");

        }


        public void UsarCredito()
        {

        }




    }
}