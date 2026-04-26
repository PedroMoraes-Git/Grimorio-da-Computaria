/*
Criado em 12/04/2026...

Hoje eu vou falar de estruturas de controle, mais especificamente as condições, eu não sabia como deixava mais chique aí eu pesquisei no Google e vi que chamam de estrutura de seleção condicionais... Serve pro código decidir aí o que ele vai fazer baseado em true/false e if/else if/else

Aliás, se você estiver lendo isso aqui sem antes ter lido o arquivo operators.cs em Operadores, não leia mais, ou leia, sei lá, eu só não recomendo muito porque é essencial combinar condicionais com operadores
*/


using static System.Console; // dica legal: se fizer esse using pode usar WriteLine() direto


// como usar condicionais


bool condition = true; // criei aqui uma condição, também funciona com absolutamente qualquer coisa que retorne bool

bool other = 200 * 2 < 300; // e aqui outra condição, agora com operadores (obs: retorna false)


if (condition && other) // SE condition == true E other == true
{
    WriteLine("as duas condições foram atendidas!"); // esses 4 espaços é a indentação, isso significa que o código tá dentro do if
}
else if (condition || other) // SE condition == true OU other == true
{
    WriteLine("apenas uma delas foi atendida...");
}
else // CASO CONTRÁRIO
{
    WriteLine("bruh... Nenhuma condição atendida");
}

// esse já é um exemplo completinho, mas dá pra usar if sozinho ou if e elif, mas o else sempre fica no final. Extra, nenhum dos outros que estiver abaixo é executado se o de cima for atendido primeiro, então mesmo que condition seja true e o if/elif verificam isso, como o if vem primeiro, ele é executado, isso acontece porque o código é executado de cima pra baixo da esquerda pra direita e a primeira verificação cancela as próximas


// exemplo mais elaborado


var user = (Age: 20, HaveCard: true);

if (user.Age >= 18)
{
    // esse código só vai ser executado se a idade for maior ou igual do que 18
    if (user.HaveCard)
    {
        WriteLine("pode comprar coisas!");
    }
    else
    {
        WriteLine("não tem cartão pra comprar!");
    }
}
else
{
    WriteLine("menor de idade não pode comprar coisa na internet! Vai jogar Roblox");
}

// sim, dá pra colocar condição dentro de condição, só que isso deixa o código mais complexo... Com grandes ifs vem grandes bugs 😭. Não recomendo ter mais de 4 aninhados


/*

minhas notas:

- acho que a partir de hoje vou começar a pôr data nos arquivos

- como no último arquivo eu só faltei xingar o criador do node, hoje de novo não vou xingar o node...

- é sério, node em paz aqui

- ... É sério, não vai ter xingamento

- ok, eu me rendo, o truthy e falsy do node são terríveis, isso é design ruim >:[ 

*/