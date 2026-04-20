/*
Criado em 20/04/2026...

Minha nossa, eu fiquei 8 dias sem fazer um commit, mais um pouco e eu esqueço até como faz hello world

Hoje eu vou falar sobre os loops for, foreach e while... São estruturas de repetição

Eu quase esqueci como eu escrevo os arquivos 😭
*/

using static System.Console; // pra usar WriteLine() direto


// loop for, até que é simples


for (int i = 0; i < 10; i++) // inicialização; condição; incrementar/decrementar
{
    WriteLine(i);
}

/* o WriteLine vai ser executado 10 vezes porque: a variável i foi criada, o código continua sendo executado enquanto "i < 10" for true, e após cada execução do código, incrementa 1

Por isso também dá pra inverter e ir de 10 até 0 com: for (int i = 10; i > 0; i--)
*/


// loop foreach, melhor pra iteração


string[] names = ["Astolfo", "Bob", "Clodovaldo"];

foreach (var name in names) // name é uma variável temporária que representa o item atual, pode usar var ou declarar o tipo string explicitamente
{
    WriteLine(name); // isso vai ser executado 3 vezes porque names tem 3 itens... Funciona com qualquer coleção
}


// loop do-while, esse é meio esquecido mas é bem útil


string option = "";

do
{
    WriteLine("Menu de opções...");
    WriteLine("1 - Sair");
    WriteLine("2 - Continuar");
    Write("Escolha uma opção: ");
    option = ReadLine();
}
while (option != "1");


// o do-while executa pelo menos uma vez antes de verificar a condição e repete enquanto a condição for true


// loop apenas while


string otherOption = "1";

while (otherOption != "1")
{
    WriteLine("nada");
}

// nesse caso nem vai ser executado porque o while verifica antes de executar, se fosse true o código continuaria sendo executado pra sempre ou até a condição ser false


// extras, palavras-chave:


for (int i = 0; i > 10; i++)
{
    if (i is 4)
    {
        WriteLine("skip 4");

        continue; // isso é meio que um "skip", o loop vai pular o 4 e ir pro 5, ignorando todo o resto do código abaixo e pulando pra próxima iteração
    }

    if (i is 5)
    {
        return; // esse depende de onde o loop tá sendo usado, só funciona se estiver em uma função void (não retorna valor), isso interrompe toda a execução da função
    }

    if (i is 6)
    {
        break; // interrompe a execução do loop
    }
}


/*

minhas notas:

- hoje tô meio sem criatividade

- eu também admito que quase ia esquecendo do do-while, a documentação da Microsoft me salvou de não deixar coisa importante de fora

- menos o goto, isso daí é criminoso

*/