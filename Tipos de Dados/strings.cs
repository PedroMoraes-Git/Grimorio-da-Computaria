/*
Eu acho que passei aproximadamente não sei quantos dias sem fazer um commit... Bem, strings porque sim
*/


using System.Text; // esse using é necessário para o StringBuilder explicado abaixo


// tipo de dado string


string garbageText = "esse é um texto aleatório e inútil";

char oneChar = 'M';

char[] chars = ['o', 'l', 'á', oneChar];


// Basicamente, essa maravilha de tipo de dado é um array de caracteres, então é imutável, uma string precisa ser reatribuída toda vez que for alterar o valor


// mexendo com string


string otherGarbage = garbageText + ", socorro"; // concatenar | adicionar o texto no final

string interpolation = $"o texto da variável otherGarbage é: {otherGarbage}"; // usa $ antes das aspas e chaves para a variável que quer formatar

int size = interpolation.Length; // nome autodescritivo, não


// métodos úteis


string text = "  oi     ";

text = text.Trim().ToUpper(); // a string agora tem o valor "OI"


string data = "nome, idade, cidade";

string[] dataArray = data.Split(", "); // fica: ["nome", "idade", "cidade"]

data = string.Join("/", dataArray); // e acaba como: "nome/idade/cidade"


/*

Lista de métodos úteis:

ToUpper() / ToLower() - altera os caracteres para caixa alta ou caixa baixa (upper case, lower case), tudo abaixo pode ser case sensitive então é bom converter

Trim() - tira os espaços do começo e fim da string

Length() - retorna o número inteiro da quantidade de caracteres da string

Substring(start, length) - o segundo argumento é opcional, extrai o valor de uma string do começo até o final ou do começo até o índice específicado

Replace(before, after) - aceita char e string, por exemplo: trocar 'a' por 'b' ou trocar "velho" por "novo". Troca TODAS as ocorrências de before pra after

Contains(text) - aceita string ou char, retorna bool se houver ou não o texto ou caractere verificado

StartsWith() / EndsWith - também aceita string ou char e tem nomes bem descritivos, retorna bool verificando se começa ou termina com certos caracteres, tipo EndsWith(".png")

Split(separator) - divite a string em array de strings, por exemplo: "a-b-c".Split('-') vira o array ["a", "b", "c"]

Join(separator, array) - junte um array de strings em uma string com um separador, por exemplo: array ["a", "b", "c"] com string.Join("-") vira "a-b-c"

string.IsNullOrEmpty(string) / IsNullOrWhiteSpace(string) - ambos retornam bool de acordo com a verificação, os nomes são autodescritivos então sem explicação demais

*/


// comparação


string a = "oi";
string b = "Oi";

bool equals = a.Equals(b); // false

equals = a.Equals(b.ToLower()); // true

equals = a.Equals(b, StringComparison.OrdinalIgnoreCase); // true também

// strings são case sensitive, então "STRING" é diferente de "string"


// imutabilidade


string s = "abc";
s.Replace("a", "z");

Console.WriteLine(s); // continua "abc"

string s2 = "abc";
s2 = s2.Replace("a", "z");

Console.WriteLine(s2); // agora é "zbc"


// precisa reatribuir o valor para alterar a string


// string builder


var sb = new StringBuilder();

sb.Append("Olá");
sb.Append(" mundo");

string stringResult = sb.ToString();


// se precisar de muitas concatenações, usar StringBuilder deixa mais simples e performático


// caracteres especiais e escape


string otherExample = "a mensagem foi \"oi\"";

Console.WriteLine(otherExample); // a mensagem foi "oi"

string file = @"/home/pedro/file.txt";

Console.WriteLine(file); // /home/pedro/file.txt


// convertendo string e int


int num = int.Parse("10"); // 10
string str = num.ToString(); // "10"

/*

notas:

- provavelmente eu vou esquecer metade do que tá escrito aqui em uma semana

- strings são mais complicadas do que parecem

- pelo menos eu não tô estudando node

*/