/*
É interessante como o C# tem muitas formas de representar números e... Todas fazem até que bastante sentido (ou nem tanto)
*/


// tipos de dados para números inteiros e/ou naturais


sbyte integer0 = 127; // usa míseros 8 bits na memória e armazena valores de -128 a 127. O signed byte suporta valores inteiros

byte integer1 = 255; // o tipo byte vai de 0 até 255, também é extremamente leve, mas só suporta 0 e valores positivos


short integer2 = 32667; // o short usa apenas 16 bits na memória e armazena números inteiros de -32.768 a 32.767

ushort integer3 = 65535; // unsigned short suporta números do 0 até o 65.535, usa os mesmos 16 bits do short mas suportando apenas valores sem sinal (0 ou positivo)

// não é possível somar shorts diretamente porque geralmente o resultado vira int, então precisa usar cast, por exemplo: short integer = (short)(short1 + short2);


int integer4 = 2147483647; // é um tipo de dado que armazena números inteiros e ocupa 32 bits na memória. Vai de -2.147.483.648 a 2.147.483.647

uint integer5 = 4294967295; // unsigned integer, ou uint, armazena do 0 até 4.294.967.295, também ocupa 32 bits na memória mas não suporta valores negativos (com sinal de menos)


long integer6 = 9223372036854775807; // long usa 64 bits na memória e armazena números imensos de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807, que é aproximadamente 9 quintilhões positivo e negativo

ulong integer7 = 18446744073709551615; // unsigned long vai de 0 até 18.446.744.073.709.551.615, ou seja, quase 18,4 QUINTILHÕES, é muito grande!


// tipos de dados para números decimais


float decimal0 = 3.402823e38f; // o float (ou ponto flutuante) ocupa 32 bits e tem precisão simples de ~6 a 9 dígitos, o sufixo é obrigatório pro C# não achar que é double, tem erros bizarros de arredondamento


double decimal1 = 1.7976931348623157e308; // é o padrão do C#, tem precisão de uns ~15 a 17 dígitos e ocupa 64 bits na memória, sem sufixo e tem os mesmos problemas de arredondamento do float


decimal decimal2 = 79228162514264337593543950335m; // precisão absurda de ~28 a 29 dígitos, usa 128 bits na memória, tem sufixo e não sofre com erros de precisão como os anteriores porque é feito pra preservar a precisão decimal, só que acaba sendo menos rápido.


/*

notas:

- socorro, tem 8 formas diferentes de declarar números inteiros no C#, como não fica indeciso?

- pelo menos dá pra escolher, mas isso é bom e ruim

- e eu não gosto de double ou float, decimal é menos confuso

*/