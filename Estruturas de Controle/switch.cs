/*
Criado em 21/04/2026...

Finalmente cheguei em switch, uma estrutura de controle que organiza melhor o código que if, 314159 else if's e else. É isso, hoje eu vou falar (ou na verdade escrever né, mas enfim) sobre isso
*/


// o switch case tem duas formas de declarar, uma é mais verbosa e explícita, enquanto a outra é tão moderna que faz inveja até em dev Python


using static System.Console; // já expliquei isso em outros arquivos, pra usar Writeline() direto


// exemplo de código simples (que funciona)


Write("Digite o primeiro número: ");
var input1 = ReadLine();

Write("Digite um operador aritmético: ");
var inputOpt = ReadLine();

Write("Digite o segundo número: ");
var input2 = ReadLine();

string[] validOpt = ["+", "-", "*", "/", "%"];


// validações pra ninguém me chamar de preguiçoso

if (string.IsNullOrWhiteSpace(input1) || string.IsNullOrWhiteSpace(input2) || string.IsNullOrWhiteSpace(inputOpt))
{
    WriteLine("Não pode enviar input vazio!");
    return;
}

if (!decimal.TryParse(input1, out decimal num1) || !decimal.TryParse(input2, out decimal num2))
{
    WriteLine("Tá achando que isso aqui é equação pra colocar letra no lugar de número?");
    return;
}

if (!validOpt.Contains(inputOpt))
{
    WriteLine("Operador inválido...");
    return;
}


// feito isso, agora temos a parte do switch case:


// jeito mais estruturado
switch (inputOpt)
{
    case "+":
        WriteLine($"Resultado: {num1 + num2}");
        break;

    case "-":
        WriteLine($"Resultado: {num1 - num2}");
        break;

    case "*":
        WriteLine($"Resultado: {num1 * num2}");
        break;

    case "/":
        WriteLine($"Resultado: {num1 / num2}");
        break;

    case "%":
        WriteLine($"Resultado: {num1 % num2}");
        break;

    default:
        // nada aqui porque tem validação no começo
        break;

}


// forma mais simples
decimal result = inputOpt switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    "/" => num1 / num2,
    "%" => num1 % num2,
    _ => 0
};

// esse '_' no final é o default, pode ser null ou string.Empty e é obrigatório retornar algum valor, mesmo que vazio

WriteLine($"Resultado: {result}");


// com isso temos o primeiro exemplo básico de switch case e switch, tipo calculadora bem estruturada ou calculadora em poucas linhas


// agora switch e switch case com operadores, onde isso fica tão poderoso que finalmente o C# para de parecer C++ com GC


decimal points = 7.5m;

// obs legal: os operadores lógicos dentro do switch são escritos por extenso igual linguagens fáceis tipo Python, Ruby e Lua. Sendo eles o or, and e not
switch (points)
{
    case < 5m:
        WriteLine("reprovado");
        break;

    case > 5m and < 7m:
        WriteLine("recuperação");
        break;

    default:
        WriteLine("aprovado");
        break;
}


// e agora a forma simples
string result2 = points switch
{
    < 5m => "reprovado",
    >= 5m and < 7m => "recuperação",
    _ => "aprovado"
};

WriteLine(result2);


// obs²: or, not e and por extenso não funcionam exatamente igual aos operadores lógicos em if/else if/else, prefira usar sempre com símbolos em condicionais e no switch use por extenso


/*

minhas notas:

- eu acho que o C# deve ter algum bom motivo pra or, not e and funcionarem um pouco diferente de ||, ! e && nas condicionais, mas ainda não busquei saber, deve ser coisa do pattern matching

- mas mesmo assim, isso é um baita recurso moderno e bem útil, só que nem tanta gente conhece

- é isso, até que esse arquivo saiu um pouco longo

*/