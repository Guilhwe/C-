namespace ScreenSound1.Modelos;
internal class Grupo
 {
    private List<Album> albums = new List<Album>(); 
    private List<Evaluacion> notas = new List<Evaluacion>() ;
    public Grupo(string nombre)
    {
        Nombre = nombre;
        
    }
    public string? Nombre {get;}
    
    public double Media 
    {
        get
        {
            if (notas.Count == 0)return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List <Album> Albums => albums;
    public void AgregarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void AgregarNota(Evaluacion nota)
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