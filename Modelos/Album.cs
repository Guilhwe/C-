namespace ScreenSound1.Modelos;
class Album
{
    public Album(string nombre)
    {
        Nombre=nombre;
        
    }
    private List<Musica> musicas = new List<Musica> ();
    public string? Nombre { get;}
public int DuracionTotal=>musicas.Sum(musica=>musica.Duracion);
    public void AgregarMusica(Musica musica)
    {
        musicas.Add(musica);

    }
    public void ExhibirAlbum()
    {
        Console.WriteLine($"Lista de canciones del album {Nombre}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nombre}");

        }
        Console.WriteLine($"Para escuchar el album necesitas {DuracionTotal} segundos\n");
    }
}