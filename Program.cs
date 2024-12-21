using System.Net;
using System.Reflection.Emit;
using Sistema_Bancario.Models;

Console.Clear();

/*

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
            break;

        case "2":
            break;
        
        default:
            Console.WriteLine("Essa opção não existe!");
        break;
    }
}
while (Opc != "3");
*/

List<string> Numeros = new List<string>();
List<ContaBancaria> ContasBancarias = new List<ContaBancaria>();

Banco Banco = new Banco(Numeros, ContasBancarias);

for (int i=0; i<3; i++)
{
    Banco.CriarContaCorrente("Rodrigo", "teste");
}


