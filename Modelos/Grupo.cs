namespace ScreenSound1.Modelos;
class Grupo
 {
    private List<Album> albums = new List<Album>(); 
    private List<int> notas = new List<int>() ;
    public Grupo(string nombre)
    {
        Nombre = nombre;
        
    }
    public string? Nombre {get;}
    
    public double Media => notas.Average();
    public List <Album> Albums => albums;
    public void AgregarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void AgregarNota(int nota)
    {
        notas.Add(nota);
    }
    public void ExhibirDiscografia()
    {
        Console.WriteLine($"Discografia de la banda {Nombre}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album : {album.Nombre} ({album.DuracionTotal})");
        }

    }
 }