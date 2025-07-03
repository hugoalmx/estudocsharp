//Declarar Variáveis Literais

//Para criar uma nova variável, primeiro você deve declarar o tipo de dados da variável e, em seguida, dar-lhe um nome.

//A escrita da variável é diferenciada por maiúsculas e minúsculas, o que significa que "nome" e "Nome" são 
//considerados variáveis diferentes.

//A seguir, você pode atribuir um valor à variável usando o operador de atribuição "="

string nome = "João"; // Declara uma variável do tipo string chamada nome e atribui o valor "João"
string Nome = "Maria"; // Declara uma variável do tipo string chamada Nome e atribui o valor "Maria" 
int idade = 30; // Declara uma variável do tipo int chamada idade e atribui o valor 30
double altura = 1.75; // Declara uma variável do tipo double chamada altura e atribui o valor 1.75
bool ativo = true; // Declara uma variável do tipo bool chamada ativo e atribui o valor true

//Nomes de váriaveis devem começar com uma letra ou um caractere de sublinhado (_), mas o 
//sublinhado é indicado para variáveis privadas ou protegidas, ou alguma finalidade específica.

//e podem conter letras, números e sublinhados. Não podem conter espaços ou caracteres especiais

//Nomes de variáveis devem usar camelCase ou PascalCase para melhorar a legibilidade. que é escrever
// a primeira letra de cada palavra em maiúscula, como em "minhaVariavel".
// "issoEUmExemploDeVariavel" é um exemplo de PascalCase.

//Você pode reutilizar e reatribuir a variável quantas vezes quiser. Este exemplo ilustra essa ideia.

Console.WriteLine(nome); // Exibe o valor da variável nome
nome = "Carlos"; // Reatribui um novo valor à variável nome

Console.WriteLine(nome); // Exibe o novo valor da variável nome
nome = "Ana"; // Reatribui outro novo valor à variável nome

Console.WriteLine(nome); // Exibe o novo valor da variável nome
Console.WriteLine(Nome); // Exibe o valor da variável Nome

Nome = "Fernanda"; // Reatribui um novo valor à variável Nome
Console.WriteLine(Nome); // Exibe o novo valor da variável Nome

nome = Nome;
Console.WriteLine(nome); // Exibe o valor da variável nome, que agora é igual ao valor da variável Nome




