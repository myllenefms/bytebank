using ByteBank;
using ByteBank.Contas;
using ByteBank.Pessoas;

Console.WriteLine("Bem-vindo ao RH do ByteBank");

Funcionario func1 = new Funcionario("Carlos Dias", DateTime.Parse("05/26/2000"));
Funcionario func2 = new Funcionario("Melissa Silva", DateTime.Parse("11/25/2018"));
Funcionario func3 = new Funcionario("Beatriz Sousa", DateTime.Parse("07/01/2007"));

Console.WriteLine("Cadastro");
Console.WriteLine($"Funcionário 1: \n ID: {func1.id} \n Nome: {func1.nome} \n Data de Admissão: {func1.dataAdmissao} \n " +
    $"Tempo de Empresa: {func1.tempoDeEmpresa} \n Salário: R${func1.salario} \n");
Console.WriteLine($"Funcionário 2: \n ID: {func2.id} \n Nome: {func2.nome} \n Data de Admissão: {func2.dataAdmissao} \n " +
    $"Tempo de Empresa: {func2.tempoDeEmpresa} \n Salário: R${func2.salario} \n");
Console.WriteLine($"Funcionário 3: \n ID: {func3.id} \n Nome: {func3.nome} \n Data de Admissão: {func3.dataAdmissao} \n " +
    $"Tempo de Empresa: {func3.tempoDeEmpresa} \n Salário: R${func3.salario} \n");
Console.WriteLine("------------------------------------------------------");

func1.Promover(func1.tempoDeEmpresa);
func2.Promover(func2.tempoDeEmpresa);
func3.Promover(func3.tempoDeEmpresa);

Console.WriteLine("Promoção");
Console.WriteLine($"Funcionário 1: \n ID: {func1.id} \n Nome: {func1.nome} \n Data de Admissão: {func1.dataAdmissao} \n " +
    $"Tempo de Empresa: {func1.tempoDeEmpresa} \n Salário: R${func1.salario} \n");
Console.WriteLine($"Funcionário 2: \n ID: {func2.id} \n Nome: {func2.nome} \n Data de Admissão: {func2.dataAdmissao} \n " +
    $"Tempo de Empresa: {func2.tempoDeEmpresa} \n Salário: R${func2.salario} \n");
Console.WriteLine($"Funcionário 3: \n ID: {func3.id} \n Nome: {func3.nome} \n Data de Admissão: {func3.dataAdmissao} \n " +
    $"Tempo de Empresa: {func3.tempoDeEmpresa} \n Salário: R${func3.salario} \n");
Console.WriteLine("------------------------------------------------------");

func1.Bonificar(func1.tempoDeEmpresa);
func2.Bonificar(func2.tempoDeEmpresa);
func3.Bonificar(func3.tempoDeEmpresa);

Console.WriteLine("Bonificação");
Console.WriteLine($"Funcionário 1: \n ID: {func1.id} \n Nome: {func1.nome} \n Data de Admissão: {func1.dataAdmissao} \n " +
    $"Tempo de Empresa: {func1.tempoDeEmpresa} \n Salário: R${func1.salario} \n");
Console.WriteLine($"Funcionário 2: \n ID: {func2.id} \n Nome: {func2.nome} \n Data de Admissão: {func2.dataAdmissao} \n " +
    $"Tempo de Empresa: {func2.tempoDeEmpresa} \n Salário: R${func2.salario} \n");
Console.WriteLine($"Funcionário 3: \n ID: {func3.id} \n Nome: {func3.nome} \n Data de Admissão: {func3.dataAdmissao} \n " +
    $"Tempo de Empresa: {func3.tempoDeEmpresa} \n Salário: R${func3.salario} \n");
Console.WriteLine("-----------------------------------------------------");
