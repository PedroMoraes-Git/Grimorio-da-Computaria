/*
listas, não arrays... Hoje em não tenho um bom comentário pra fazer sobre isso

Na verdade agora eu tenho, não leia esse arquivo sem antes ler o de arrays
*/


// criando lista


List<byte> listOfBytes = [255, 0, 32, 16]; // aqui eu usei o nome List, e, entre as setas, o tipo de dado, no caso, byte, o que resultou em List<byte>, ou seja, uma lista de números de até 1 byte

List<byte> emptyListOfBytes = new List<byte>(); // lista vazia... Tão vazia quanto minha vontade de aprender front end

// outros exemplos:

List<string> listOfNotBytes = ["isso", "é", "uma", "lista", "de", "arrays"];

List<float> listOfNotStrings = [10.283f, 273.49263f, 240.5f];

List<int> listOfInts = [125, 5, 25, 15];

List<List<List<List<List<int>>>>> help = new List<List<List<List<List<int>>>>>(); // eu nem vou falar nada sobre isso, sinceramente

// e claro, também dá pra fazer listas com objetos criados a partir de classes do próprio código


// métodos tão úteis que são essenciais


List<int> example = [1, 2, 5, 4, 3];

example.Add(10); // adiciona o valor 10 no final da lista. Sim, não é imutável igual array
example.Insert(0, 5); // sintaxe é: Insert(index, item), adiciona um elemento no índice específicado
example.Remove(10); // remove o valor 10, se tiver mais de um elemento com esse valor, faz o L, ele só remove o primeiro que encontra. Retorna true/false dependendo se a remoção foi bem sucedida ou não
example.RemoveAt(0); // remove o elemento no índice 0
example.Clear(); // clear limpa tudo, sobra nada

// verificações também úteis

bool hasAnything = example.Contains(5); // é bool, então true/false mesmo
int index = example.IndexOf(5); // índice do 5 ou -1 caso não encontre 5 na lista
int size = example.Count; // quantos elementos tem na lista. Não, não é length

// extras

example.Sort(); // ordena em ordem crescente, sort é o pesadelo de quem estuda Big O notation
example.Reverse(); // simplesmente inverte a lista


// convertendo listas e arrays


int[] array = [1, 5, 3, 7];
List<int> list = [1, 5, 3, 7];

List<int> newList = array.ToList(); // agora é lista
int[] newArray = list.ToArray(); // agora é array


// onde a iteração muda

List<int> anotherList = [2, 6, 2, 7, 9, 0];

foreach (int item in anotherList)
{
    anotherList.Remove(item); // isso definitivamente faz kaboom. Você não pode percorrer uma lista (e nenhuma coleção) enquanto a modifica
}


/*
observação sad: eu não sei LINQ (ainda), então falta umas manipulações legais de lista. Será adicionado no futuro
*/


/*
outra observação: a sintaxe em questão de acessar os valores e iterar não é diferente de arrays, por isso eu não repeti isso aqui, é meio redundante e já foi avisado no começo do arquivo
*/

/*

notas (finalmente):

- dessa vez eu vou deixar o node em paz

- eu continuo preferindo usar listas ao invés de arrays

- é sério, não vai ter xingamento pro node aqui

*/