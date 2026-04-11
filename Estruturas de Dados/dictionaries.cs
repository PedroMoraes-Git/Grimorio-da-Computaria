/*
Dicionários... Uma das estruturas de dados que eu mais gosto junto de tuplas, apesar de no C# ele ser mais rígido com os tipos de dados do que um JSON, ainda continua sendo brabo
*/


// proferindo o encantamento... Mentira, é só como criar um dicionário


Dictionary<string, int> mysticalData = new()
{
    ["valor1"] = 200,
    ["valorNão1"] = 002
};

// ou

Dictionary<string, int> mysticalData2 = new()
{
    { "valorNão1", 002 },
    { "valorAgora1", 200 }
};


/*

o C# deve ter mais umas 3 formas diferentes de fazer isso, mas sinceramente... É só sintaxe

Basicamente, se usa Dictionary<TypeKey, TypeValue> para invocar essa estrutura no código, ele funciona definindo um tipo para a "chave" e outro para o "valor", é quase como listas, mas agora usamos a chave para acessar os valores ao invés de índices. 

Acesso: mysticalData["valor1"]

Isso devole aí o valor 200

E dá pra fazer com um monte de tipos de dados e até estruturas de dados, tipo colocar o valor como outro dicionário ou uma lista

*/


// outros exemplos


Dictionary<string, int> empty = new(); // dicionário vazio... Tão vazio quanto minha conta bancária

Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<Dictionary<int, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int>, int> pureAbomination = new(); // música Soap&Skin... "Me and the Devil... Walking side by side"


// mexendo com dicionários (métodos e exemplos junto)


Dictionary<string, int> exampleDict = new();

exampleDict.Add("valor1", 20); // adiciona a chave "valor1" com valor 20, vai dar erro se já existir uma chave com esse nome
exampleDict.TryAdd("valor1", 30); // esse é mais seguro, retorna bool informando se conseguiu ou não adicionar
exampleDict["valor2"] = 20; // se a chave existir, altera o valor, caso contrário, vai adicionar a chave no dicionário
exampleDict.Remove("valor2"); // retorna bool pra caso consiga ou não remover o par de chave e valor
exampleDict.ContainsKey("valor2"); // busca rápida, geralmente O(1), que significa velocidade constante. Retorna bool caso contenha ou não a chave (key) no dicionário
exampleDict.ContainsValue(30); // a velocidade desse busca depende do tamanho do dicionário, ela percorre todos os elementos internamente, então é O(n), o que significa que demora proporcionalmente ao tamanho do dicionário. Também retorna bool caso exista ou não o valor, mas só verifica se o valor existe em qualquer lugar do dicionário
int value; exampleDict.TryGetValue("valor1", out value); // essa já é um pouco mais robusta. É uma operação O(1) que: verifica se a chave existe. Obtém o valor da chave. E atribui esse valor a uma variável com out. Por fim, retorna bool dependendo se a chave existe ou não
exampleDict.Count(); // com parênteses porque é função, retorna a quantidade de pares chave e valor que tem no dicionário


// iteração, e sim, tem várias opções


var dict = new Dictionary<string, int>();

foreach (KeyValuePair<string, int> pair in dict)
{
    // acessos: pair.Key e pair.Value
}

foreach (var key in dict.Keys)
{
    // simplesmente key
}

foreach (var number in dict.Values)
{
    // e simplesmente number
}


/*
observação: eu creio que isso seja o suficiente por enquanto, seguindo a proposta de só pôr o que eu sei, acabou que algumas coisas que também dá pra fazer não estão por aqui
*/


/*

notas:

- eu citei um pouquinho de Big O notation aqui, mas não é obrigatório saber pra entender a explicação

- dicionários são extremamente úteis, mas, no C# não dá pra usar chaves ou valores de tipos diferentes de uma forma simples igual JSON -_-

- e dessa vez o node ganhou

*/