using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaCorrente :ContaBancaria
    {
        
        public decimal Credito { get; set; }




        public void AbrirContaCorrente (ContaBancaria ContaGenerica, List<ContaBancaria>ContasBancarias)
        {   
            ContaCorrente NovaContaCorrente = new ContaCorrente();

            NovaContaCorrente = (ContaCorrente)ContaGenerica;

            NovaContaCorrente.Credito = 500;

            ContasBancarias.Add(NovaContaCorrente);

        }


        public void UsarCredito()
        {

        }




    }
}