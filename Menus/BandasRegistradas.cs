using ScreenSound1.Modelos;
namespace ScreenSound1.Menus;

internal class MenuBandasRegistradas : Menu
{
     public override void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
     {
         base.Ejecutar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            
     }
}