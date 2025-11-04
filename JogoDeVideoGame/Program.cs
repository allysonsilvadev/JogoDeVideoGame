//Faça um programa para um jogo de videogame que diz se o portão pode ser aberto ou não.
//O programa precisa das seguintes informações de entrada:
//se o jogador possuí a chave do portão
//se o jogador possui a espada dourada
//se o jogador possui o escudo dourado
//a força do jogador
//O portão abre se o jogador possuir a chave ou possui a espada e o escudo dourado
//ou então se tiver força maior que 100 (para quebrar o portão)

String portao;
String espadaEscudo;
int forca;

Console.WriteLine("O jogador possuí a chave do portão? :  ");
portao = Console.ReadLine().ToLower();

Console.WriteLine("O jogador possui a espada dourada e o escudo dourado? :");
espadaEscudo = Console.ReadLine().ToLower();

Console.WriteLine("Qual é a força do jogador?: ");
forca = int.Parse(Console.ReadLine());

if ((portao == "sim") || (espadaEscudo == "sim"))
{
    Console.WriteLine("Portão liberado");
}
else if (forca >= 100)
{
    Console.WriteLine("O portão pode ser quebrado");
}else
{
    Console.WriteLine("O portão não pode ser aberto no momento");
}

