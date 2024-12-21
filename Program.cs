using System.Net;
using System.Reflection.Emit;
using Sistema_Bancario.Models;

Banco Banco = new Banco();

Console.Clear();



char opc;

    Console.WriteLine("Bem Vindo! \n");
do
{
    Console.WriteLine("O que você deseja? ");
    Console.WriteLine("[1] Criar Nova Conta ");
    Console.WriteLine("[2] Acessar conta ");
    Console.WriteLine("[0] Finalizar programa");
    Console.Write("\nDigite a opção desejada: ");
    opc = char.Parse(Console.ReadLine());

    switch (opc)
    {
        case '1':
            Console.Write("\nDigite o nome do proprietário da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Defina uma senha para conta: ");
            string senha = Console.ReadLine();
            Console.Write("\n[1] Corrente \n[2] Poupança \nEscolha um tipo de conta: ");
            char tipoConta = char.Parse(Console.ReadLine());
            if (tipoConta == '1')
            {
                Banco.CriarContaCorrente(nome, senha);
                Console.ReadLine();
                Console.Clear();
            }

            else if (tipoConta == '2')
            {
                Banco.CriarContaPoupanca(nome, senha);
                Console.ReadLine();
                Console.Clear();
            }

            else 
            {
                Console.WriteLine("Essa opção não existe!");
            }

            break;

        case '2':
            Console.Write("Digite o número da sua conta: ");
            string numero = Console.ReadLine();
            Console.Write("Digite a senha da sua conta: ");
            senha = Console.ReadLine();

            Banco.AcessarConta(numero, senha);
            break;

        case '0':
            Console.Clear();
            break;
        
        default:
            Console.WriteLine("Essa opção não existe!");
        break;
    }
}
while (opc != '0');
