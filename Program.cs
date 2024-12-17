using Sistema_Bancario.Models;

Console.Clear();

List<ContaCorrente> ContasCorrente = new List<ContaCorrente>();
List<ContaPoupanca> ContasPoupanca = new List<ContaPoupanca>();


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
    ContasCorrente = NovaCorrente.AbrirConta(NomeProprietario, SenhaConta, TipoConta);
    
}

else if (TipoConta == "2")
{   TipoConta = "poupança";
    ContaPoupanca NovaPoupanca = new ContaPoupanca();
    ContasPoupanca = NovaPoupanca.AbrirConta(NomeProprietario, SenhaConta, TipoConta);
}

Console.WriteLine("-------------------");

Console.WriteLine("*** Acesse sua conta *** ");
Console.Write("Digite o número da sua conta: ");
int NumeroConta = int.Parse(Console.ReadLine());
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
}

else
{
    Console.WriteLine("Não existe tipo de conta associado a esse valor! ");
}
