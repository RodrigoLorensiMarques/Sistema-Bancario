using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaPoupanca :ContaBancaria
    {

        public ContaPoupanca (string nome, string senha, string numero)
        {
            NomeProprietario = nome;
            Senha = senha;
            Numero = numero;
            TipoConta = "poupanca";
        }

        public ContaPoupanca()
        {

        }   
    }
}