using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class ContaPoupanca :ContaBancaria
    {


        
        public void AbrirContaPoupanca (ContaBancaria ContaGenerica, List<ContaBancaria>ContasBancarias)
        {   
            ContaPoupanca NovaContaPoupanca = new ContaPoupanca();

            NovaContaPoupanca = (ContaPoupanca)ContaGenerica;

            ContasBancarias.Add(NovaContaPoupanca);

        }
        
    }


    
}