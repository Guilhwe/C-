using ScreenSound1.Modelos;
namespace ScreenSound1.Menus;

internal class MenuRegistrarBanda : Menu
{
     public override void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
     {
        base.Ejecutar(bandasRegistradas);
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nombreDeLaBanda = Console.ReadLine()!;
            Grupo grupo = new(nombreDeLaBanda);
            bandasRegistradas.Add(nombreDeLaBanda, grupo);
            Console.WriteLine($"A banda {nombreDeLaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
     }

}
