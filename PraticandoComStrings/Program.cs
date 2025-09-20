using System;
using System.Diagnostics;
using System.Text.RegularExpressions;


//Exercicio da palavra chave
Console.WriteLine("--------------------------------------");

string palavraChave = "exemplo";
Console.WriteLine("Digite um texto:");
var textoDigitado = Console.ReadLine() ?? string.Empty;

if (textoDigitado is not null && textoDigitado.Contains(palavraChave, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"O texto contém a palavra-chave '{palavraChave}'.");
}
else
{
    Console.WriteLine($"O texto não contém a palavra-chave '{palavraChave}'.");
}


//--------------------------------------
//EXERCICIO CONTANDO CARACTERES
//--------------------------------------

Console.WriteLine("Digite uma frase:");
int numeroTotalDeCaracteres = Console.ReadLine()?.Length ?? 0;
Console.WriteLine($"A frase digitada possui {numeroTotalDeCaracteres} caracteres.");

//--------------------------------------
// EXERCICIO SUBISTITUICAO DE UMA PALAVRA
//--------------------------------------
Console.WriteLine("--------------------------------------");

Console.Write("Digite uma frase: ");
string frase = Console.ReadLine() ?? string.Empty;
Console.Write("\nDigite a palavra que deseja substituir: ");
string palavraASerSubstituida = Console.ReadLine() ?? string.Empty;
Console.Write("\nDigite a nova palavra:");
string novaPalavra = Console.ReadLine() ?? string.Empty;
if (!string.IsNullOrWhiteSpace(palavraASerSubstituida))
{
    string fraseModificada = frase.Replace(palavraASerSubstituida, novaPalavra, StringComparison.OrdinalIgnoreCase);
    Console.WriteLine($"\nFrase modificada: {fraseModificada}");
}


//--------------------------------------
// EXERCICIO DE REGEX
//--------------------------------------
Console.WriteLine("--------------------------------------");

Console.Write("Digite uma chave PIX: ");
string chavePix = Console.ReadLine() ?? string.Empty;
string padraoCPF = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
if (Regex.IsMatch(chavePix, padraoCPF))
{
    Console.WriteLine("A chave PIX é um CPF válido.");
}
else
{
    Console.WriteLine("A chave PIX não é um CPF válido.");
}

string email = "iasmin@ymail.com.br";
string padraoEmailAgrupado = @"(^[a-zA-Z0-9._%+-]+)@([a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$)";
//Código omitido

string dominio = Regex.Match(email, padraoEmailAgrupado).Groups[2].Value;
Console.WriteLine(dominio);

Console.Write("Digite a chave PIX: ");

string padraoCNPJ = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
string padraoTelefone = @"^\(\d{2}\)\d{5}-\d{4}$";
string padraoEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

string tipoChave;

if (Regex.IsMatch(chavePix, padraoCPF))
    tipoChave = "CPF";
else if (Regex.IsMatch(chavePix, padraoCNPJ))
    tipoChave = "CNPJ";
else if (Regex.IsMatch(chavePix, padraoTelefone))
    tipoChave = "Telefone";
else if (Regex.IsMatch(chavePix, padraoEmail))
    tipoChave = "E-mail";
else
    tipoChave = "Formato inválido";

Console.WriteLine($"Tipo da chave PIX: {tipoChave}");


//----------------------------------
// EXERCICIO REGEX vlida numero
//----------------------------------
Console.WriteLine("--------------------------------------");

Console.Write("Digite o número do cupom: ");
string cupom = Console.ReadLine() ?? string.Empty;
bool cupomValido = Regex.IsMatch(cupom, @"^\d+$");
Console.WriteLine(cupomValido ? "Cupom válido" : "Cupom inválido");

//--------------------------------------
// EXERCICIO REGEX - Valor monetário
//--------------------------------------
Console.WriteLine("--------------------------------------");

Console.Write("Digite o texto do recibo: ");
string textoDeEntrada = Console.ReadLine() ?? string.Empty;
string padraoValorMonetario = @"R\$ \d+,\d{2}";
// Encontra todas as correspondências
MatchCollection matches = Regex.Matches(textoDeEntrada, padraoValorMonetario);

// Verifica se há pelo menos duas correspondências antes de tentar acessar o segundo valor
if (matches.Count >= 2)
{
    string segundoValor = matches[1].Value;
    Console.WriteLine($"Segundo valor encontrado: {segundoValor}");
}
else
{
    Console.WriteLine("Não foram encontrados dois valores monetários no formato 'R$ X,XX'.");
}


//--------------------------------------
// EXERCICIO REGEX - Valor monetário
//--------------------------------------
Console.WriteLine("--------------------------------------");

string fraseDigitada = "Olá,    mundo!   Como   vocês    estão?";
string regex = @"\s+";
string textoLimpo = Regex.Replace(fraseDigitada, regex, " ").Trim();

Console.WriteLine($"Texto limpo: \"{textoLimpo.Trim()}\"");


//--------------------------------------
// EXERCICIO REGEX - Validando Datas
//--------------------------------------
Console.WriteLine("--------------------------------------");

string regexDeData = @"^\d{2}/\d{2}/\d{4}$";

Console.Write("Digite uma data (dd/mm/aaaa): ");
string dataDigitada = Console.ReadLine() ?? string.Empty;
bool dataValida = Regex.IsMatch(dataDigitada, regexDeData);
if (dataValida)
{
    Console.WriteLine("Data válida.");
}
else
{
    Console.WriteLine("Data inválida. Por favor, use o formato dd/mm/aaaa.");
}

