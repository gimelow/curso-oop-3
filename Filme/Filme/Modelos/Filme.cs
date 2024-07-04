namespace Alura.Filmes;

public class Filme
{
    private List<Filme> filmes = new();
    public string Título { get; set; }
    public int Duracao { get; set; }
    public List <Artista> artistas = new();

    public void AdicionarFilme(Filme filme)
    {
        filmes.Add(filme);
    }

    public void AdicionarArtista(Artista artista)
    {
        artistas.Add(artista);
    }
}