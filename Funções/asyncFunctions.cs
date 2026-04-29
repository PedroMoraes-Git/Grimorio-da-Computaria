/*
Arquivo criado em 26/04/2026...

Hoje eu vou escrever sobre que eu sei de funções assíncronas, a sintaxe pode até ser parecida com funções normais, mas elas funcionam de um jeito um pouco diferente, já que podem rodar em segundo plano sem travar o programa, isso é bom pra fazer requisições a APIs, bots do Discord, consultas demoradas em banco de dados ou simplesmente qualquer sistema que precisa funcionar em tempo real sem travar. Eu vou usar um pouquinho de OOP pra separar os códigos mas nada que precise de mais do que 10 minutos pra entender

obs: se quiser, leia o arquivo syncFunctions.cs antes
*/

using static System.Console; // aliás, eu já expliquei isso em outros arquivos


// começando com os exemplos básicos


class BasicAsyncMethods // classe de funções/métodos/qualquer-nome-que-você-quiser
{
    private static async Task VoidMethodAsync() // é como se fosse uma função void mas não exatamente é porque existe async void, mas foda-se também, esse presta mais e eu considero async void ruim igual goto e npm
    {
        WriteLine("método assíncrono que não retorna valor executado");
    }

    private static async Task<string> StringMethodAsync() // e pra método async que retorna algo, você usa Task<TypeResult>, se não conseguiu entender, bruh... Enfia o tipo do return dentro das setas aí que dá certinho
    {
        return "método assíncrono que retorna uma string executado";
    }

    public static async Task TestMethodsAsync() // método pra chamar os métodos, a gente faz isso usando await
    {
        WriteLine("testando os métodos assíncronos básicos...");

        await VoidMethodAsync(); // await e a chamada da função
        WriteLine(await StringMethodAsync()); // isso é meio estranho mas funciona porque o método retorna string
    }

    // obs: não temos alteração alguma em usar parâmetros e passar argumentos pra função, a sintaxe se mantém a mesma
}


// e agora lidando com erros em funções assíncronas


class ErrorMethods
{
    private static async Task FunctionThatNotWorksAsync()
    {
        throw new Exception("função que não funciona foi executada");
    }

    private static async Task PrintFileContentAsync(string file)
    {
        try
        {
            string text = await File.ReadAllTextAsync(file);
            WriteLine(text);
        }

        catch (Exception)
        {
            throw; // isso passa o erro direto pra quem chamou a função
        }

        /*
        código pra não fazer:

        catch (Exception ex)
        {
            throw ex;
        }

        se fizer isso, o C# vai achar que o erro aconteceu na linha do "throw ex;"... Não recomendo
        */
    }

    public static async Task TestMethodsAsync()
    {
        try
        {
            await FunctionThatNotWorksAsync(); // erro sempre
        }
        catch (Exception ex)
        {
            WriteLine($"Ops! Ocorreu um erro: {ex.Message}"); // aqui a gente consegue capturar a exceção e exibir o erro sem parar o código da função
        }

        await PrintFileContentAsync("nada.txt"); // dá erro se o arquivo não existir

        WriteLine("isso pode não ser executado"); // como o erro não foi tratado, essa linha nunca vai ser executada se o arquivo não existir porque a execução da função para no momento do erro
    }
}


// paralelismo - fazer muitos trecos de uma vez só, você não consegue, mas o computador sim


class Parallelism
{
    private static async Task SlowFunctionAsync()
    {
        await Task.Delay(4000); // essa função aguarda 4 segundos (4000 ms) antes de executar
        WriteLine("função assíncrona demorada executada");
    }

    private static async Task NormalFunctionAsync()
    {
        await Task.Delay(2000);
        WriteLine("função assíncrona meio demorada executada");
    }

    private static async Task FastFunctionAsync()
    {
        WriteLine("função assíncrona rápida executada");
    }

    public static async Task TestMethodsAsync()
    {
        // Sequencial (demora 6s pra continuar, tempo de todas) - usando sequencialmente, fica assim:

        await FastFunctionAsync();
        await NormalFunctionAsync();
        await SlowFunctionAsync();


        // WhenAll (demora 4s pra continuar, tempo da mais lenta) - também tem como executar as funções em paralelo e aguardar tudo ser feito usando o Task.WhenAll, vou dar dois exemplos de sintaxe, primeiro esse:

        Task t1 = FastFunctionAsync();
        Task t2 = NormalFunctionAsync();
        Task t3 = SlowFunctionAsync();

        await Task.WhenAll(t1, t2, t3);
        WriteLine("o código aguardou todas as funções serem executadas");

        // e esse:

        await Task.WhenAll(FastFunctionAsync(), NormalFunctionAsync(), SlowFunctionAsync());
        WriteLine("o código aguardou todas as funções serem executadas... De novo");


        // WhenAny (demora 0s pra continuar, tempo da mais rápida) - esse executa e paralelo e já continua quando qualquer função termina primeiro e deixa as outras rodando em segundo plano

        var fatest = await Task.WhenAny(FastFunctionAsync(), SlowFunctionAsync(), NormalFunctionAsync()); // FastFunctionAsync vai rodar primeiro e as outras duas vão continuar em segundo plano... Isso parece meio merda mas eu vou dar um exemplo melhor abaixo

        WriteLine("o código já continuou assim que uma função foi executada");
    }
}


// cancellation token, eu precisei escrever isso umas 161803 vezes pra lembrar que cancellation é com duas letras 'l', ou melhor, dois char, mas enfim, agora bora ver como pausa uma operação demorada tipo download


class CancellFunctions
{
    private static async Task FakeDownloadAsync(CancellationToken token) // precisa receber o token de cancelação né, por isso tá aqui como parâmetro
    {
        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested(); // vai cancelar se pedir pra cancelar, isso é uma verificação

            WriteLine("baixando...");

            await Task.Delay(1000);
        }
    }

    public static async Task TestMethodsAsync()
    {
        using var sourceToken = new CancellationTokenSource(); // keyword using garante o descarte do token source após o uso, bom pra liberar recursos (pode usar o mesmo pra várias funções async)

        await FakeDownloadAsync(sourceToken.Token); // enviando o token, né...

        await Task.Delay(2000);

        sourceToken.Cancel(); // e agora a gente tá pedindo yamete kudasai pro FakeDownload parar


        // depois desse exemplo de uso aí, vou continuar e dar o exemplo que presta do WhenAny aqui mesmo:

        using var newSourceToken = new CancellationTokenSource();

        Task timeout = Task.Delay(5000);
        Task task = FakeDownloadAsync(newSourceToken.Token);

        var first = await Task.WhenAny(task, timeout);

        if (first == timeout)
        {
            WriteLine("demorou demais e é isso, desisti");

            newSourceToken.Cancel();
        }
        else
        {
            WriteLine("download falso assíncrono foi executado antes de expirar");
        }
    }
}


/*
nota aleatória: eu quase precisei engolir o Google pra criar esse arquivo, eu entendi a lógica das coisas mas foi luta pra lembrar como escreve T-T
*/


class Program // sim, porque o código funciona
{
    static async Task Main() // se o código for executado e funcionar, vai exibir os logs de testes de forma bagunçada porque é tudo assíncrono
    {
        await BasicAsyncMethods.TestMethodsAsync();

        await ErrorMethods.TestMethodsAsync();

        await Parallelism.TestMethodsAsync();

        await CancellFunctions.TestMethodsAsync();
    }
}


/*

minhas notas (muitas):

- eu preciso começar a escrever código e parar de escrever sobre código em até um mês

- mas, sem pressão, até que esse arquivo tá legal, foi um dos mais organizados e longos que eu já fiz pro Grimório

- dica do dia (e eu não vou falar pra não usar node): não use e nem aprenda task.Result ou task.Wait(), isso causa deadlocks e não é top

- deadlock na programação: é quando dois processos ficam igual barata tonta esperando um ao outro pra terminar e ninguém termina, imagine que duas pessoas conseguiram fazer um PIX ao mesmo tempo, transferindo dinheiro da conta A para B e da B para A, a transferência 1 vai bloquear a conta A e tentar bloquear a conta B, mas a transferência 2 já bloqueou a conta B que a transferência 1 tentou bloquear e quer tentar bloquear a conta A pra finalizar. Nesse caso a transferência 1 precisaria esperar a transferência 2 liberar a conta, e a transferência 2 esperar a 1 liberar a conta, e pronto, desse jeito a gente e o computador ficamos doidos juntos 😵

- e também não use async void, a não ser que você esteja fazendo uma biblioteca, aí sei lá, o que alguém assim estaria fazendo em um arquivo com código de iniciante?

*/