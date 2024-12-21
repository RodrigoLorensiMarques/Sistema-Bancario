using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class Banco : ContaBancaria
    {
        private List<string> _NumerosContasBancarias;
        private List<ContaBancaria> _Contas = new List<ContaBancaria>();
        public Banco(List<string>NumerosContasBancarias, List<ContaBancaria>Contas)
        {
            _NumerosContasBancarias = NumerosContasBancarias;
        }

        public string GerarNumeroConta ()
        {
            bool NumeroEmUso = true;
            string CadeiaGerada = "";

            while (NumeroEmUso)
            {
                NumeroEmUso = false;

                Random rnd = new Random();
                for (int i=0; i<5; i++)
                {  
                    int NumeroGerado = rnd.Next(0,9);
                    CadeiaGerada+= NumeroGerado.ToString() ;
                }

                if (_NumerosContasBancarias.Contains(CadeiaGerada))
                {
                    NumeroEmUso = true;
                }
            }
            _NumerosContasBancarias.Add(CadeiaGerada);

            Console.WriteLine(_NumerosContasBancarias.Count()); 
            return CadeiaGerada;
        }


        public void CriarContaCorrente(string nome, string senha)
        {
            Numero = GerarNumeroConta();
            ContaCorrente NovaContaCorrente = new ContaCorrente(nome, Senha, Numero);
            _Contas.Add(NovaContaCorrente);
            Console.WriteLine("Conta Criada");
            Console.WriteLine("QTD: " + _Contas.Count());
        }

        public void CriarContaPoupanca()
        {

        }

        public void AcessarConta()
        {

        }






    }
}