using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaPoupanca :ContaBancaria
    {
        public List<ContaPoupanca> ContasPoupanca { get; set; } = new List<ContaPoupanca>();
        public List<ContaPoupanca> AbrirConta(string Nome, string Senha, string Tipo)
        {  
            ContaPoupanca NovaContaPoupanca = new ContaPoupanca();
            NovaContaPoupanca.NomeProprietario = Nome;
            NovaContaPoupanca.Senha = Senha;
            NovaContaPoupanca.Numero = NovaContaPoupanca.GerarNumeroConta();
            NovaContaPoupanca.TipoConta = Tipo;
            NovaContaPoupanca.Saldo = 0;

            ContasPoupanca.Add(NovaContaPoupanca);

            Console.WriteLine("Conta poupança criada com sucesso!");

            return ContasPoupanca;
        }
        
    }


    
}