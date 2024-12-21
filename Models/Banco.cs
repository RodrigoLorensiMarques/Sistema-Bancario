using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Bancario.Models
{
    public class Banco : ContaBancaria
    {
        private List<string> _numerosContasBancarias = new List<string>();
        private List<ContaBancaria> _contas = new List<ContaBancaria>();

        public string GerarNumeroConta ()
        {
            bool numeroEmUso = true;
            string cadeiaGerada = "";

            while (numeroEmUso)
            {
                numeroEmUso = false;

                Random rnd = new Random();
                for (int i=0; i<5; i++)
                {  
                    int numeroGerado = rnd.Next(0,9);
                    cadeiaGerada+= numeroGerado.ToString() ;
                }

                if (_numerosContasBancarias.Contains(cadeiaGerada))
                {
                    numeroEmUso = true;
                }
            }
            _numerosContasBancarias.Add(cadeiaGerada);
            return cadeiaGerada;
        }

        public void CriarContaCorrente(string nome, string senha)
        {
            Numero = GerarNumeroConta();
            ContaCorrente novaContaCorrente = new ContaCorrente(nome, senha, Numero);
            _contas.Add(novaContaCorrente);
            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine($"O número da sua conta é {novaContaCorrente.Numero}");
        }

        public void CriarContaPoupanca(string nome, string senha)
        {
            Numero = GerarNumeroConta();
            ContaPoupanca novaContaPoupanca = new ContaPoupanca(nome, senha, Numero);
            _contas.Add(novaContaPoupanca);
            Console.WriteLine("\nConta criada com sucesso!");
            Console.WriteLine($"O número da sua conta é {novaContaPoupanca.Numero}");
        }

        public void AcessarConta(string numero, string senha)
        {
            bool contaLocalizada = false;
            for (int i=0; i<_contas.Count(); i++)
            {
                if (_contas[i].Numero == numero)
                {
                    contaLocalizada = true;
                    if (_contas[i].Senha == senha)
                    {   
                        ContaBancaria AcessarConta = _contas[i];
                        AbrirMenu(AcessarConta);
                    }

                    else
                    {
                        Console.WriteLine("Senha incorreta!");
                    }
                }
            }

            if (contaLocalizada == false)
                {
                    Console.WriteLine("Conta não localizada!");
                }
        }

        public void AbrirMenu(ContaBancaria conta)
        {   ContaCorrente corrente = new ContaCorrente();
            ContaPoupanca poupanca = new ContaPoupanca();

            int opc = 0;
            Console.WriteLine("");
            Console.WriteLine($"Bem vindo {conta.NomeProprietario}!");
            do
            {
                Console.WriteLine("");
                Console.WriteLine("[1] Verificar saldo");
                Console.WriteLine("[2] Depositar");
                Console.WriteLine("[3] Sacar");
                Console.WriteLine("[4] Transferir");
            
                if (conta.TipoConta == "corrente")
                {
                    Console.WriteLine("[5] Verificar Crédito");
                    Console.WriteLine("[6] Usar Crédito");
                }
                Console.WriteLine("[0] Sair");

                Console.Write("Digite a opção desejada: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"O saldo da sua conta é de R${conta.Saldo}");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        conta.Saldo = conta.Depositar();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        conta.Saldo = conta.Sacar();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        conta.Transferir(_contas);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 5:
                        corrente = (ContaCorrente)conta;
                        Console.WriteLine($"Seu crédito atual é de R${corrente.Credito}");
                        Console.ReadLine();
                        Console.Clear();
                        break;    


                    case 6:
                        corrente.Credito = corrente.UsarCredito();
                        Console.ReadLine();
                        Console.Clear();
                        break; 

                    case 0:
                        Console.Clear();
                        break;                    

                    default:
                        Console.WriteLine("Essa opção não existe!");
                        Console.Clear();
                        break;
                }
             }
            while (opc !=0) ;

        }
    }
}