// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!\n\n");


//Treinamento utilizando variáveis de interpolação e concatenação de texto e formatação de texto
string herber = "É os guri";
string mensagem = "da Painzuda";
// utilizando o caractere especial "@" - conseguimos criar um literal de cadeia de caracteres que mantenha toda a formatação de espaço e ignore a "\" (barra invertida) como um caractere especial reservado do C#
string site = @"www.paingaming.com.br e entre no \diretorio";  
//Aqui ja temos um exemplo do caractere especial "$" para podermos adicionar template string em nossas varíaveis, podendo adicionar o conteúdo de outras varíaveis em uma nova string.
//Também vemos exemplos de como utilizar os comandos "\n" para pular 1 linha e "\t" para pular 1 tabulação
string visiteSite = $"Visite o site da painzuda\n\t{site}\n{herber} {mensagem}\n";

Console.WriteLine(visiteSite);

//Aqui temos a prática do conteúdo estudado.
string bandas = "1 - Arctic Monkeys\n2 - Strokes\n3 - The Killers\n4 - Foster the People\n5 - Franz Ferdinand";
string indieGeneration = @"Visite o site do grupo Indie Generation www.indiegeneration.com.br\discos\top-5\indie";
string lista = $"Atualmente o nosso top bandas é o seguinte:\n\n{bandas}para mais conteúdo\n\n{indieGeneration}\n\t\"We Make it our on way\"\n\n ";

Console.WriteLine(lista);

//Lembrando que os dois comandos podem ser utilizados juntos exemplo: string exemplo = $@"Comando {teste} \ {teste2}" e ambos podem ser utilizados direto no método do WriteLine

//Aprendendo a utilizar operações matemáticas no c#endregion

int firstNumber = 12;
int secondNumber = 7;
//Isso aqui vai somar os números, se cada um tivesse na sua propria template string, eles estariam apenas concatenados mostrando como resultado " 12 + 7 " e não 19 que é o resultado da soma.
Console.WriteLine($"{firstNumber+secondNumber}\n"); 

string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient); //Essa divisão não terá os caracteres após a vírgula visto que o número foi declarado como inteiro.

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal Quotient: {decimalQuotient}\n\n"); //Essa divisão terá os caracteres após a vírgula já que o número foi declarado como decimal.

int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;  //Aqui os números foram declarados como inteiro, mas estão sendo convertidos para decimal na segunda variável, isso não afeta o valor das varíaveis originais.
Console.WriteLine(quotient2);

//Nesse exemplo abaixo utilizando o caractere "%" temos a sobra de uma divisão, no primeiro exemplo será 0 pois 200 é divisível por 5, e no segundo exemplo será 2 pois é o que sobra da divisão de 7 com 5(considerando como inteiro).
Console.WriteLine($"Modulus of 200 / 5 : {200%5}");
Console.WriteLine($"Modulus of 7 / 5 : {7%5}");

/*
Em matemática, PEMDAS é um acrônimo que ajuda os alunos a se lembrar da ordem das operações. A ordem é:

Parêntese (o que estiver dentro do parêntese é executado primeiro)
Exponentes
Multiplicação e Divisão (da esquerda para a direita)
Adição e Subtração (da esquerda para a direita)
*/

//Exemplos para incrementar valores
int value = 1;
value++;
Console.WriteLine("First: " + value); // O Valor aqui será 2 devido ao incremento anterior
Console.WriteLine($"Second: {value++}"); // O valor continua 2 pois o incremento foi feito DEPOIS do valor ser apresentado
Console.WriteLine("Third: " + value); // Aqui temos o incremento que foi feito anteriormente, mostrando o valor de 3
Console.WriteLine("Fourth: " + (++value)); // Aqui temos o incremento ANTES do valor ser apresentado, portanto é 4.

int value2 = 0;     
value2 = value2 + 5; // Incrementando 5 no valor.
value2 += 5;        // Somando +5 no valor, o valor agora é 10. Isso pode ser feito também com outros operadores *= /= -= e também pode ser usado o ++ e o --


//Transformando a temperatura de Fahrenheit para Celsius e arredondando o valor utilizando o método Math.Round 
int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * (5.0m/9);
decimal celsiusRound = Math.Round(celsius,1);

Console.WriteLine($"The temperature is {celsiusRound} Celsius.");