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
        }
        public decimal Credito { get; set; } = 500;

        public void UsarCredito()
        {

        }

        
        
        
    }
}