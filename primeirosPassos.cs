Console.WriteLine("Digite seu Nome:"); //exibe uma mensagem no console, solicitando ao usuário que digite seu nome.
var nome = Console.ReadLine(); // lê a entrada do usuário a partir do console e a armazena na variável "nome"

Console.WriteLine("Digite sua Bibliografia");
var bio = Console.ReadLine(); // lê a entrada do usuário a partir do console e a armazena na variável "bio"

Console.WriteLine("Digite seu(s) Objetivo(s)");
var objetivos = Console.ReadLine(); // lê a entrada do usuário a partir do console e a armazena na variável  "obvjetivos"

Console.WriteLine("-------------------------------------------------Processando seu Perfil-------------------------------------------------");

Console.WriteLine($"Olá, Me chamo {nome}!\nBiografia: {bio}\nMeu(s) Objetivo(s): {objetivos}\n"); // a interpolação de string ($) é usada para inserir os valores das variáveis dentro da string
