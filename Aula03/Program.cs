//O que são variáveis locais de tipo implícito?

//Uma variável local de tipo implícito é criada usando a palavra-chave var seguida de uma inicialização de variável. 

var message = "Hello, World!"; // A variável message é do tipo string

//A palavra-chave var informa ao compilador C# que o tipo de dados está implícito pelo valor atribuído. 
//Depois que o tipo é implícito, 
//a variável age da mesma forma como se o próprio tipo de dados real tivesse sido usado para declará-lo.

//De fato, a variável message é definida para ser um string e para nunca poder ser alterada.

//As variáveis que usam a palavra-chave var devem ser inicializadas, ou seja
//devem receber um valor no momento da declaração.
//Caso contrário, o compilador C# não poderá determinar o tipo de dados da variável.

//Por que usar a palavra-chave var?

//A palavra-chave var é útil quando o tipo de dados é óbvio a partir do valor atribuído,
//ou quando o tipo de dados é complexo e você não quer escrever o tipo completo.

// Exercício de concatenar variáveis literais
//Concatenar significa unir duas ou mais cadeias de caracteres em uma única cadeia de caracteres


var name = "Bob";
var primeiroNumero = 3;
decimal segundoNumero = 34.40m;

Console.WriteLine("Hello, " + name + "! You have " + primeiroNumero + " messages in your inbox. The temperature is " + segundoNumero + " celsius." );

Console.WriteLine(34.40m + 3); // Exemplo de soma de variáveis literais