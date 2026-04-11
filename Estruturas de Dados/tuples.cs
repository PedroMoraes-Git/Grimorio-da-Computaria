/*
tuplas... Uma estrutura de dados muito poderosa, talvez até um pouco mais do que os dicionários em certos casos... Hoje eu vou escrever sobre elas
*/


// declarando tuplas, tem muitas formas de fazer isso...


(bool success, string message) result = (success: true, message: "action of doing nothing was successful."); // essa é talvez a forma mais verbosa de se declarar uma tupla, é o que melhor se aproxima de um result pattern

var otherResult = (true, "nothing^2"); // sem muita vantagem aparente, também dá pra fazer isso

(bool, string) otherOtherResult = (true, "nothing tetration 2"); // também tem como fazer assim

(bool success, string message) otherOtherOtherResult = (true, "messsage"); // outra forma

var betterResult = (success: true, message: "no message"); // na minha humilde opinião, essa forma de declarar é a melhor 


// outro exemplo


Dictionary<string, List<int>> dictionary = new()
{
    ["key1"] = [12345, 54321],
    ["key2"] = [54321, 12345]
};

var resultData = (successSearch: true, data: dictionary, date: DateTime.Now);


// acessando os valores 


string messageWithName = result.message; // nesse caso, como o valor foi nomeado, acessa pelo nome da tupla, ponto e nome do valor, até parece classe

string messageWithoutName = otherResult.Item2; // e se for preguiçoso na hora de declarar, acessa os valores dessa forma feia usando Item1, Item2 e até o infinito e além (ou até acabar a RAM)


/*pelo menos tem autocomplete, é mais seguro do que listas e dicionários*/


// alterando os valores


otherOtherResult.Item1 = false; // é bem simples alterar os valores, só reatribuir

betterResult = (false, "no ideia"); // e dá pra reatribuir tudo junto também


// imutabilidade, onde mais dói D:


/*
infelizmente, não é possível adicionar ou remover valores depois de criar uma tupla. As tuplas tem estrutura imutável, semelhante aos arrays, então podemos apenas reatribuir. A solução para isso é meio gambiarra, mas, dá pra criar novas tuplas baseadas nas antigas, o que permite aumentar ou diminuir o tamanho de forma manual.
*/


var newTuple = (betterResult.message); // "removido" um valor
var otherNewTuple = (betterResult.success, betterResult.message, date: DateTime.Now); // "adicionado" um valor


/*
nota sobre as tuplas: geralmente a vantagem de usar tuplas é a velocidade (alocação na stack) e simplicidade vs dicionários ou classes. Geralmente o melhor proveito delas é em escopo privado de funções, já que simplificar um result pattern é bem poderoso porque acaba evitando erros inesperados e 5 milhões de try-catch repetidos
*/

/*
nota 2, agora sobre result pattern: sem chatice de conceitos complexos, result pattern é basicamente o retorno de uma função que diz se deu bom ou ruim junto da mensagem de erro, por exemplo:

(isSuccess: false,
data: null,
message: "User not found")

quem disser que é mais do que isso tá mentindo... Na verdade não, mas sendo sincero, boa parte é overengineering.
*/

/*
nota 3, agora sobre stack: eu não sei explicar isso de forma tão boa, mas basicamente é um lugar pequeno da memória extremamente rápido e gerenciado automaticamente. O tamanho é menor (alguns MB) e funciona como uma pilha, o último dado inserido é o primeiro a ser removido (LIFO), aí é rápido pra caramba porque a CPU gerencia a memória sequencialmente. Stack é um negócio meio doido que tá mais presente em linguagens de baixo nível, eu só citei porque é legal saber que alguns ms de velocidade vem daí
*/


/*

minhas notas (eba, finalmente):

- nem dá pra comparar com o node porque não tem tuplas lá, F

- não use recursão nas tuplas (referenciar ela mesma dentro de si), ou o StackOverflow sem ser o site vai te amaldiçoar. Sim, eu testei isso, o C# não é tão alto nível assim quanto parece

- qualquer coisa mais complexa deveria usar dicionários ou classes, aí fica a dúvida né, escolher o tipo/estrutura de dados corretamente no meio de 14709 formas de fazer

*/