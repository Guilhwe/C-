using ScreenSound1.Modelos;

namespace ScreenSound1.Menus;

internal class MenuExhibirDetalles : Menu
{
    
    public override void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
    {
        
         base.Ejecutar(bandasRegistradas);
            ExibirTituloDaOpcao("Exibir detalhes da banda");
            Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
            string nombreDeLaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nombreDeLaBanda))
            {
                Grupo grupo = bandasRegistradas[nombreDeLaBanda];
                Console.WriteLine($"\nA média da banda {nombreDeLaBanda} é {grupo.Media}.");
                /*
                * ESPAÇO RESERVADO PARA COMPLETAR A FUNÇÃO
                */
                Console.WriteLine("Digite uma tecla para votar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                

            }
            else
            {
                Console.WriteLine($"\nA banda {nombreDeLaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
               
            }
    }
}
 