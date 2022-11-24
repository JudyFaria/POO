using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.PaceriaComercial;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitários;
using Microsoft.VisualBasic;

//Console.WriteLine("Boas Vindas ao ByteBank Administração");

//GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

//Funcionario lucas = new Funcionario("123.456.789-00", 2000);
//lucas.Nome = "Lucas";


//Diretor ana = new Diretor("098.765.432-10", 5000);
//ana.Nome = "Ana";

//Funcionario caique = new Diretor("678.986.567-98", 5000);
//caique.Nome = "Caique";

//Console.WriteLine("Bonificação - Funcionário(a) Lucas: " + lucas.getBonificacao());
//Console.WriteLine("Bonificação - Diretor(a) Ana: " + ana.getBonificacao());
//Console.WriteLine("Bonificação - Diretor(a) Caique: " + caique.getBonificacao());


//gerenciador.Registrar(lucas);
//gerenciador.Registrar(ana);
//gerenciador.Registrar(caique);

//Console.WriteLine("Total de Bonificações: " + gerenciador.getBonificacao());

//Console.WriteLine("Total de Funcionários: " + Funcionario.totalDeFuncionarios);


//lucas.AumentarSalario();
//Console.WriteLine("Novo salário lucas: " + lucas.Salario);

//caique.AumentarSalario();
//Console.WriteLine("Novo salário caique: " + caique.Salario);


//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

    Diretor ana = new Diretor("123.456.789-79");
    ana.Nome = "Ana";
    Console.WriteLine(ana.Nome + ana.getBonificacao());

    Desenvolvedor judy = new Desenvolvedor("147.258.369-01");
    judy.Nome = "Judy";
    Console.WriteLine(judy.Nome + judy.getBonificacao());

    Designer igor = new Designer("789.456.123.31");
    igor.Nome = "Igor";
    Console.WriteLine(igor.Nome + igor.getBonificacao());

    GerenteDeContas roberta = new GerenteDeContas("193.728.645-00");
    roberta.Nome = "Roberta";
    Console.WriteLine(roberta.Nome + roberta.getBonificacao());

    Auxiliar lucas = new Auxiliar("654.285.357-19");
    lucas.Nome = "Lucas";
    Console.WriteLine(lucas.Nome + lucas.getBonificacao());


    gerenciador.Registrar(lucas);
    gerenciador.Registrar(roberta);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(judy);


    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor ana = new Diretor("123.456.789-79");
    ana.Nome = "Ana";
    ana.Login = "ana.totvs";
    ana.Senha = "123";


    GerenteDeContas roberta = new GerenteDeContas("193.728.645-00");
    roberta.Nome = "Roberta";
    roberta.Login = "roberta.totvs";
    roberta.Senha = "321";

    ParceiroComercial irineu = new ParceiroComercial();
    irineu.Login = "irineu.parceiro";
    irineu.Senha = "123";


    sistemaInterno.Logar(ana,"ana.totvs","123");
    sistemaInterno.Logar(roberta, "roberta.totvs", "321" );
    sistemaInterno.Logar(irineu, "irineu.parceiro", "120");
   
}

