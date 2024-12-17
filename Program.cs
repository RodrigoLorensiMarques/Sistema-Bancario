using Sistema_Bancario.Models;

Console.Clear();




Console.Write("Digite o nome do proprietário: ");
string NomeProprietario = Console.ReadLine();
Console.Write("Defina uma senha para a conta: ");
string SenhaConta = Console.ReadLine();
Console.Write("A conta será tipo [1]Corrente ou [2]Poupança?");
string TipoConta = Console.ReadLine();
if (TipoConta == "1")
{
    TipoConta = "corrente";
    ContaCorrente NovaCorrente = new ContaCorrente();
    NovaCorrente.AbrirConta(NomeProprietario, SenhaConta, TipoConta);
}

else if (TipoConta == "2")
{   TipoConta = "poupança";
    ContaPoupanca NovaPoupanca = new ContaPoupanca();
    NovaPoupanca.AbrirConta(NomeProprietario, SenhaConta, TipoConta);
}


Console.Write("*** Acesse sua conta *** ");
Console.Write("Digite o número da sua conta: ");
int NumeroConta = int.Parse(Console.ReadLine());
Console.Write("O tipo da conta é [1]Corrente ou [2]Poupança?");
TipoConta = Console.ReadLine();
if (TipoConta == "1")
{
    TipoConta = "corrente";
}

else if (TipoConta == "2")
{   TipoConta = "poupança";
}

Console.Write("Digite a senha para sua conta: ");
SenhaConta = Console.ReadLine();