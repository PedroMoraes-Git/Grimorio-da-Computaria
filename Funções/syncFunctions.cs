/*
Criado em 25/04/2026...

Bom dia, boa tarde ou boa noite pra 0 pessoas que estiverem lendo porque esse repo é desconhecido, hoje eu vou escrever sobre funções (só funções não assíncronas por enquanto).

Funções são uma forma de executar código várias vezes sem precisar ficar reescrevendo, elas podem ser void (não retornam valores) ou sempre retornarem um dado, szeja estrutura ou tipo.

As funções variam bastante em questão de precisar criar objeto (não static) ou não precisar, públicas, privadas ou protegidas, ou que retornam/não retornam valores, mas o OOP que chore porque eu só vou falar do "básico" por enquanto
*/


using static System.Console; // já expliquei isso em outros arquivos


// começando com exemplos básicos


void Function() // função que não recebe e não retorna valores
{
    WriteLine("função executada");
}

string FunctionWithReturn() // função que sempre retorna uma string e não recebe nenhum valor
{
    return "valor";
}


// esses são alguns dos exemplos da sintaxe. Usamos uma keyword pra definir o comportamento da função, nomeamos ela e usamos parênteses


Function(); // chamando/usando a função

string message = FunctionWithReturn(); // o valor retornado pela função é atribuído a essa variável


// funções que recebem valores (parâmetros)


decimal SumTwoNumbers(decimal num1, decimal num2) // parâmetros: decimal num1 e decimal num2, a função espera receber esses valores e só funciona se for chamada recebendo-os. Essa função recebe valor decimal e retorna valor decimal
{
    return num1 + num2;
}


var result = SumTwoNumbers(num1: 20, num2: 30); // passado 20 e 30 como argumentos para os parâmetros

var otherResult = SumTwoNumbers(20, 30); // e também tem como fazer dessa forma mais direta


// função com parâmetros opcionais


(bool isSuccess, string message) CreateNewUser(string name, int id, string gender = "não definido") // o parâmetro "gender" é opcional porque já foi dado um valor padrão, ele pode ser sobreescrito se algum valor para gender for passado como argumento
{
    return (isSuccess: true, message: "usuário registrado 👍");
}


var resultCreate = CreateNewUser("Geriscleiton", 123); // e assim não é necessário dar um valor pra gender, fica padrão, mas se for passado, vai sobreescrever o padrão, seria útil se esse código registrasse de verdade 🤔



// variáveis dentro de funções (life cycle)


decimal[] points = [7, 8, 9, 4];

decimal final = 0;

void CalcAverage()
{
    decimal tempPoint = 0;

    foreach (decimal i in points)
    {
        tempPoint += i;
    }

    final = tempPoint / points.Length;
}


// nesse caso, a variável "tempPoint" foi criada dentro da função, ela existe no código enquanto a função estiver em execução, mas, como não é uma variável global ou campo de classe, vai ser excluída da memória após o fim da função e não pode ser acessada fora do escopo da função...

WriteLine(tempPoint); // por isso essa parte vai dar um erro tipo: o nome "tempPoint" não existe no contexto atual


/*
aviso: eu não sei sobre funções recursivas e nem sei se quero aprender, é uma das coisas que eu considero perigosas e difíceis de aplicar tipo goto... Então por enquanto é meio meh, vou deixar isso pra quando tiver aprendendo algoritmos
*/


/*

minhas notas:

- funções em C# são especialmente mais tensas pelo OOP forte, esse arquivo usa top level statements então não precisou chegar lá ainda, mas já aviso, vai piorar

- funções são top pra não ficar repetindo código e poder quebrar sistemas em partes menores, é top pra organização e DRY (Don't Repeat Yourself)

- não sei o que o node.js fez, mas acho que ele merece ser xingado

*/