using System.Diagnostics.Contracts;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using VS_Code.Models;


List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RJ");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

























// Console.WriteLine("Percorrendo a lista com o FOR");
// for(int contador = 0; contador < listaString.Count; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");

// }

// Console.WriteLine("Percorrendo a lista com o FOREACH");
// int contadorForeach = 0;
// foreach(string item in listaString)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} - {item}");
//     contadorForeach++;
// }


















// int[] arrayInteiros = new int[4];

// arrayInteiros[0] =  72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;


// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);


// //Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);



// Console.WriteLine("Percorrendo o Array com o FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
// }














// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForeach} = {valor}");
//     contadorForeach++;
// }










// string? opcao;
// bool exibirMenu = true;
// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digitel a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {

//      case "1":
//      Console.WriteLine("Cadastro de cliente");
//      break;

//      case "2":
//      Console.WriteLine("Busca de cliente");
//      break;

//      case "3":
//      Console.WriteLine("Apagar cliente");
//      break;

//      case "4":
//      Console.WriteLine("Encerrar");
//      exibirMenu = false;
//      //Environment.Exit(0);

//      break;

//      default:
//      Console.WriteLine("Opção inválida");
//      break; 


//     }
// }











// do while

// int soma = 0, numero = 0;

// do{
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;


// }  while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

















// while 

//  int numero = 5;
//  int contador = 1;

//  while (contador <= 10)
//  {
//      Console.WriteLine($"{contador}* Execução: {numero} x {contador} = {numero} * {contador}");
//      contador++;

//      if (contador == 6)
//      {
//         break;
//      }
//  } 








// Introdução ao FOR

//  int numero = 5;

//  for(int contador = 0; contador <= 10; contador++)
//  {
//      Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//  }










//Calculadora

//Calculadora calc = new Calculadora();

//calc.RaizQuadrada(9);






// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);





//calc.Potencia(3, 3);


// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2,2);











// Operador NOT 


// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar outro dia");
// }












// Operador AND

// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7)
// {
// Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }












// Operador OR

// bool eMaiorDeIdade = true;
// bool possuiAutorizacaoDoResponsavel = false;

// if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada Liberada");

// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }








// Switch Case



// Console.WriteLine("Digite uma letra");
//   string? letra = Console.ReadLine();

//   switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":

//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;

// }



// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//   Console.WriteLine("Vogal");
// }
// else
// { 
//     Console.WriteLine("Não é uma Vogal");
// }








//  if (letra == "a")
//  {
//     Console.WriteLine("Vogal");

// }

// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }

// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }











// IF aninhado

// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possívelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possívelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");

// }
// else if (possívelVenda)
// {
//     Console.WriteLine("Venda Realizada.");

// }
// else
// {
//     Console.WriteLine("Desculpe, Não temos a quantidade desejada em estoque.");
// }








// Operador condicional

// int quantidadeEmEstoque = 10;

// int quantidadeCompra = 4;

// bool possívelVenda = quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {quantidadeEmEstoque >= quantidadeCompra}");


// if (quantidadeEmEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda Realizada.");

// }
// else
// {
//     Console.WriteLine("Desculpe, Não temos a quantidade desejada em Estoque.");
// }












// Convertendo de maneira segura

// string a =  "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão Realizada com sucesso!");







// Ordem de Operadores

// double a = 4 / 2 + 2;

// double a = 4 / (2 + 2);

// Console.WriteLine(a);





// Cast Implícito

// int a = 5;
// double b = a;

// int a = 5;
// int b = a;

// long a = long.MaxValue;
// long b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;


// Console.WriteLine(b);





//Conversão para String

// int inteiro = 5;
// string a = inteiro.ToString();



// Console.WriteLine(a);







// Cast - Casting

//int a = Convert.ToInt32("5");

//int a = int.Parse("5");

//Console.WriteLine(a);






// atribuição

// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;

// Console.WriteLine(c);






//  datetime

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// declarando variáveis 

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine(" Valor da variável altura: " + altura);
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da varável condicao: " + condicao);





// classe

//Pessoa pessoa1 = new Pessoa();

//pessoa1.Nome = "Cremilda";
//pessoa1.Idade = 50;
//pessoa1.Apresentar();
    
