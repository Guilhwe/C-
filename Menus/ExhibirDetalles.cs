using ScreenSound1.Modelos;

namespace ScreenSound1.Menus;

internal class MenuExhibirDetalles
{
    public void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
    public void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
    {
        Console.Clear();
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
 