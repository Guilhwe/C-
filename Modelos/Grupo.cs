namespace ScreenSound1.Modelos;
class Grupo
 {
    private List<Album> albums = new List<Album>();  
    public Grupo(string nombre)
    {
        Nombre = nombre;
        
    }
    public string? Nombre {get;}
    public void AgregarAlbum(Album album)
    {
        albums.Add(album);
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