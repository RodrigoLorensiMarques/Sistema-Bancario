using System.Net;
using System.Reflection.Emit;
using Sistema_Bancario.Models;

Console.Clear();
List<ContaCorrente> ContasCorrente = new List<ContaCorrente>();
List<ContaPoupanca> ContasPoupanca = new List<ContaPoupanca>();

string Opc = "";

do
{

    Console.WriteLine("Bem Vindo! ");
    Console.WriteLine("O que você deseja? ");
    Console.WriteLine("[1] Criar Nova Conta ");
    Console.WriteLine("[2] Acessar conta ");
    Console.WriteLine("[3] Finalizar programa");
    Console.Write("Digite a opção desejada: ");
    Opc = Console.ReadLine();

    switch (Opc)
    {
        case "1":
            List<string> NumerosContasBancarias = new List<string>();
            Console.Write("Digite o nome do proprietário: ");
            string NomeProprietario = Console.ReadLine();
            Console.Write("Defina uma senha para a conta: ");
            string SenhaConta = Console.ReadLine();
            Console.Write("A conta será tipo [1] Corrente ou [2] Poupança? ");
            string TipoConta = Console.ReadLine();
            if (TipoConta == "1")
            {
                TipoConta = "corrente";
                ContaCorrente NovaCorrente = new ContaCorrente();
                ContasCorrente = NovaCorrente.AbrirConta(NomeProprietario, SenhaConta, TipoConta, NumerosContasBancarias);
            }

            else if (TipoConta == "2")
            {   TipoConta = "poupança";
                ContaPoupanca NovaPoupanca = new ContaPoupanca();
                ContasPoupanca = NovaPoupanca.AbrirConta(NomeProprietario, SenhaConta, TipoConta, NumerosContasBancarias);
            }
            break;

        case "2":
            Console.Write("Digite o número da sua conta: ");
            string NumeroConta = Console.ReadLine();
            Console.Write("Digite a senha para sua conta: ");
            SenhaConta = Console.ReadLine();

            Console.Write("O tipo da conta é [1] Corrente ou [2] Poupança? ");
            TipoConta = Console.ReadLine();
            if (TipoConta == "1")
            {
                TipoConta = "corrente";
                ContaCorrente Corrente = new ContaCorrente();
                Corrente.AcessarContaCorrente(NumeroConta, SenhaConta, TipoConta, ContasCorrente);
            }

            else if (TipoConta == "2")
            {   
                TipoConta = "poupança";
                ContaPoupanca Poupanca = new ContaPoupanca();
                Poupanca.AcessarContaPoupanca(NumeroConta, SenhaConta, TipoConta, ContasPoupanca);
            }
            else
            {
                Console.WriteLine("Não existe tipo de conta associado a esse valor! ");
            }
            break;
        
        default:
            Console.WriteLine("Essa opção não existe!");
        break;
    }
}
while (Opc != "3");


