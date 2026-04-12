/*
Depois de tanto tempo, finalmente saí do assunto das variáveis, agora dá pra ir pra uma parte um pouco mais prática além de só... Criar valores :/
*/


/*
O que é isso: no C#, os operadores basicamente são símbolos especiais que fazem coisas. Uau, que definição maravilhosa... Menos específico é impossível, mas, exemplificando, nós temos operadores aritméticos, de comparação, lógicos e atribuição (tem uns outros aí também mas eu não sei não).

Abaixo eu vou dar vários exemplos desses operadores
*/


// operadores aritméticos... Os mais fáceis


/*
São eles: + (mais), - (menos), * (vezes), / (dividido), % (módulo ou resto de divisão), ++ e -- (incrementa/decrementa 1)

Mil exemplos abaixo:
*/

int sum = 2 + 5; // sum = 7

int notSum = 2 - 5; // notSum = -3, sim, o C# faz jogo de sinal

int multiply = 12 * 12; // multiply = 144

int notMultiply = 144 / 12; // notMultiply = 12

int module = 12 % 6; // como 12 / 6 = 2 exatamente e não sobra nada (resto da divisão), module = 0 


// agora os de incremento e decremento

int C = 1;

C--; // 0

C++; // agora é 1... Mas eu acho que essa operação me lembra de algo perigoso


// comparação (o amor do if else)


// sem brincadeira... Os operadores de comparação... Comparam! Uau, totalmente fora do esperado. Sâo eles: == (é igual), != (não é igual), < (menor que). > (maior que), <= (menor ou igual que) e >= (maior ou igual que). Tudo retorna bool, então é 0 pegadinhas... Mil exemplos abaixo também:


bool comparison;

comparison = 20 == 10; // isso é false, 20 não é igual a 10

comparison = 20 != 10; // true, é verdade que 20 não é 10

comparison = 0 < 1; // true, zero é menor do que um

comparison = 0 > 1; // aí é false, zero não é maior do que um

comparison = 10 >= 10; // true, 10 não é maior mas é igual

comparison = 20 <= 20; // também true, 20 não é menor mas é igual

// também tem "is" e "is not", mas nesse caso não se aplica porque o pattern matching é mais rígido, como 20 e 10 são valores fixos no código que não variam (diferente de variáveis, que se chamam assim porque variam :o), o C# faz um warning de código inútil, já que 20 nunca vai ser 10 e nem é uma variável que pode ter o valor 10.


// operadores lógicos, onde o filho chora e a mãe também


/*
usados nas condições, os operadores lógicos são: && (AND), || (OR) e ! (NOT)

eles são simples, mas podem ser combinados... E bem, isso pode gerar uns probleminhas tensos de entender às vezes. Exemplo:
*/


string text = "lorem ipsum";

if (!text.ToLower().Equals("lorem ipsum") && text.Length >= 5 || text is "admin") // esse if completo verifica se o texto em lower case NÃO é igual a lorem ipsum E se o tamanho é maior ou igual do que 5 OU se o texto é admin (e depois do || só vale a próxima condição)
{
    Console.WriteLine("alguma condição foi atendida");
}


// acho que esse único exemplo basta


// por fim... Atribuição


int n = 20; // atribuição mais simples, n = 20

n += 5; // e essa outra aqui

/*
É como se fosse x = x + 5. E sim, funciona com -, *, / e %, isso resulta em %= e /=, nunca testei além de + ou -, mas sempre é o valor da variável operação outro valor, tipo x *= 5 é x = x * 5

*/


/*

minhas notas:

- programar fica mais foda depois de entender isso

- agora eu posso bater no node com gosto, só quem sabe o que é coerção de tipos vai entender... '5' == 5 sendo true é maligno 💀

- chora node, ter que comparar com === é estranho

- ok, chega de xingar o node, mas sem zoas, operadores são muito úteis

*/