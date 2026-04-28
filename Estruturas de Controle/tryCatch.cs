/*
Criado em 28/04/2026...

Eu esqueci de fazer esse arquivo e percebi que usei try catch em outro arquivo sem ter explicado antes, então pra resolver isso... Eba, hoje eu vou falar de algo que esquecem que também é uma estrutura de controle, inclusive eu esqueci também, brabo demais

Basicamente, usamos isso pra fazer uma operação que pode dar erro e o programa deve seguir um fluxo mesmo caso haja erro, esse é o famigerado... Tratamento de erros, que no C# é tão fácil que nem tem estresse
*/

using static System.Console;


// apresentando um exemplo logo de cara (descomente as linhas abaixo se quiser testar o script funcionando)


// File.WriteAllText("texto.txt", "nada");
// File.WriteAllText("outro.txt", "nada");

try
{
    File.ReadAllText("texto.txt");
}

catch (Exception ex) // qualquer exceção vai ser capturada sem matar o programa
{
    WriteLine($"ocorreu um erro: {ex.Message}");
}

WriteLine("esse código vai ser executado mesmo se houver um erro");

// sem tratamento

File.ReadAllText("outro.txt");

WriteLine("esse código pode nem ser executado se houver um erro");


// pronto... Você aprendeu tratamento de erro em 20 linhas, arquivo finalizado 


// claro que não caralho! Tem mais coisa ainda, continuando...


// capturando exceções específicas

try
{
    int num1 = 20;
    int num2 = 0;

    WriteLine(num1 / num2);
}
catch (DivideByZeroException) // exceção específica
{
    WriteLine("você não pode dividir por zero");
}
catch (Exception ex) // exceção genérica
{
    WriteLine($"não sei como, mas deu erro: {ex.Message}");
}

// com isso dá pra mudar o tratamento dependendo do erro, não só capturar exceção e mandar pro console


// e o finally, keyword pra sempre fazer algo independente do resultado


try
{
    // sei lá
}

catch (Exception ex)
{
    WriteLine($"ocorreu um erro: {ex.Message}");
}

finally
{
    WriteLine("esse bloco sempre é executado, tendo erro ou não");
}


// exemplo da vida real, fila de requisições feita de forma simples


class Example
{
    private static SemaphoreSlim semaphore = new(1, 1); // contagem inicial 1 e contagem máxima 1 também

    private static async Task DoAnything()
    {
        await Task.Delay(800); // simulando trabalho

        WriteLine("fiz uma requisição de mentira");
    }

    public static async Task UseSystem()
    {
        await semaphore.WaitAsync();

        try
        {
            await DoAnything();
        }

        finally // executado toda vez
        {
            await Task.Delay(1000); // imagine que você quer implementar um sistema que limita a 60 requisições por minuto, após toda chamada dessa função, o sistema vai aguardar 1 segundo antes de liberar o acesso.

            WriteLine("tarefa concluída");

            semaphore.Release();
        }
    }
}

// é uma forma de implementação mais simples do que contar as requisições e deixar fazer as 60 requisições do minuto atual em 5 segundos e depois ter que esperar mais 55 segundos, depende do modelo de rate limit né, no caso, o meu sistema mostra um exemplo que tem limite de 1 req/s


// agora sim, oficialmente encerrado


/*

minhas notas:

- talvez ler o arquivo asyncFunctioncs.cs em Funções ajude a entender o exemplo acima

- eu escrevi esse arquivo depois de morrer 50 vezes no Celeste

- sorry 0 leitores por ter esquecido disso

*/