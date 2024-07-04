namespace Alura.Filmes;

public class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> filmesQueAtuou = new();

}