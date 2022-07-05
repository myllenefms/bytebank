using ByteBank.Contas;
using ByteBank.Pessoas;

Console.WriteLine("Bem-vindo ao ByteBank");

Cliente cliente1 = new Cliente();
cliente1.nome = "Myllene Mendes";
cliente1.profissao = "Desenvolvedor";
cliente1.CPF = "12345678932";
cliente1.dataNascimento = DateTime.Parse("11/23/2000");

Cliente cliente2 = new Cliente();
cliente2.nome = "Pedro Gonçalves";
cliente2.profissao = "Professor";
cliente2.CPF = "78951632469";
cliente2.dataNascimento = DateTime.Parse("05/07/1997");

Cliente cliente3 = new Cliente();
cliente3.nome = "Amelia Mendes";
cliente3.profissao = "Costureira";
cliente3.CPF = "45612398433";
cliente3.dataNascimento = DateTime.Parse("07/25/1981");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = cliente1;
conta1.agencia = "12345";
conta1.numConta = "23569874";

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = cliente2;
conta2.agencia = "12345";
conta2.numConta = "45698135";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = cliente3;
conta3.agencia = "12345";
conta3.numConta = "78963512";

Console.WriteLine($"Cliente 1: \n {conta1.titular.nome} \n Conta {conta1.numConta} \n Agencia {conta1.agencia}" +
    $"\n Saldo {conta1.saldo} \n");
Console.WriteLine($"Cliente 2: \n {conta2.titular.nome} \n Conta {conta2.numConta} \n Agencia {conta2.agencia}" +
    $"\n Saldo {conta2.saldo} \n");
Console.WriteLine($"Cliente 3: \n {conta3.titular.nome} \n Conta {conta3.numConta} \n Agencia {conta3.agencia}" +
    $"\n Saldo {conta3.saldo} \n");

conta1.Depositar(500);
conta2.Depositar(25);
Console.WriteLine($"Saldo Conta1: {conta1.saldo} \n Saldo Conta2: {conta2.saldo} \n");

bool transferido = conta1.Transferir(200, conta3);
Console.WriteLine($"Transferência Efetuada? {transferido} \n Saldo Conta1: {conta1.saldo} \n Saldo Conta3: {conta3.saldo} \n"); 

bool sacado = conta3.Sacar(100);
Console.WriteLine($"Saque efetuado? {sacado} \n Saldo Conta 3: {conta3.saldo} \n");


