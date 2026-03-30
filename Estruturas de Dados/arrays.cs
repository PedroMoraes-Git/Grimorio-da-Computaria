/*
array, não lista, é complicado escolher se um array é uma estrutura de dados ou um tipo de dado, mas independente do que seja a escrita de um array é a mesma
*/


// criando array


byte[] arrayOfNotStrings = [20, 30, 15, 10]; // pra conjurar isso aqui é simples, precisa escrever o tipo de dado, adicionar colchetes logo depois e atribuir o valor com colchetes e dentro a lista dos valores do respectivo tipo de dado separando com vírgula, diferente do português, o compilador vai brigar se escrever errado


// outros exemplos


string[] arrayOfNotBytes = ["curioso", "como", "isso", "é", "um", "array", "de", "arrays"];

decimal[] arrayOfNotFloats = [2073.5m, 271563.98m, 1234321.5421441m];

int[] arrayOfInts = [20, 30, 30, 20, 15];

int[][] arrayOfArraysOfInts = [[69, 2, 4, 6], [5, 7, 3, 1, 2], [2, 5, 4]]; // sim, essa porra existe e funciona, no mínimo magia negra mas na verdade é um array de arrays

int[][][] no = [[[1, 2, 3], [1, 2, 3]], [[1, 2, 3], [1, 2, 3]]]; // não.


// acessando valores


// para acessar os valores de um array se usa os índices (ou posições, sei lá como se chama). ele começa no 0 e vai seguindo como 0, 1, 2, 3, 4 e usa, por exemplo, array[0] para pegar o valor do primeiro índice


int value = arrayOfInts[0]; // 20 - primeiro valor
int aaaaaaaa = arrayOfArraysOfInts[0][0]; // 69 - primeiro valor do primeiro valor


// modificando os valores


string[] strings = ["x", "y", "z"];
strings[1] = "z"; // penúltimo, segundo
strings[2] = "y"; // último, terceiro

/*

agora: strings = ["x", "z", "y"]

mas só é possível alterar os valores dos elementos, não é possível adicionar e nem remover

*/


// propriedades e métodos


int[] example = [1, 2, 3, 4, 5, 6, 7, 8];

int size = example.Length; // quantos elementos tem no array, sem parênteses porque é propriedade e não método

int lastIndex = example.Length - 1; // valor do último índice do array, quantidade de elementos -1 porque o array começa em 0, então tendo 5 elementos o último tá no índice 4

int lastValue = example[^1]; // o '^' inverte o índice, então aqui pega o último valor. O ^1 significa uma posição antes do fim, então ^2 é o penúltimo, ^3 antepenúltimo e por aí vai


// iteração (percorrer todos os valores)


int[] ints = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine(i); // i = ints[i], segue o índice
}


foreach (var integer in ints) // integer é int
{
    Console.WriteLine(integer); // só valor sem índice
}



/*
o básico de arrays tá aqui, sim, tem muito mais coisa, só que se eu só copiar o código de um exemplo sem entender e copiar aqui vai bem contra o objetivo de documentar meu aprendizado, então sla
*/


/*

notas:

- na dúvida entre array ou lista, eu prefiro usar lista, 3ms de velocidade não vale mais que minha paz

- dica do dia (ou noite): não use node

- também tem como fazer um array de objetos criados a partir de classes do próprio código

*/