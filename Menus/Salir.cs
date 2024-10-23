using ScreenSound1.Modelos;
namespace ScreenSound1.Menus;
internal class MenuSalir : Menu
{
    public override void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
    {
        Console.WriteLine("Hasta la proxima");
    }
}