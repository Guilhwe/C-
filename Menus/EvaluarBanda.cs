using ScreenSound1.Modelos;
namespace ScreenSound1.Menus;

internal class MenuEvaluarBanda : Menu
{
   
    public void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
    {
        
        Console.Clear();
            ExibirTituloDaOpcao("Avaliar banda");
            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nombreDeLaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nombreDeLaBanda))
            {
                Grupo grupo = bandasRegistradas[nombreDeLaBanda];
                Console.Write($"Qual a nota que a banda {nombreDeLaBanda} merece: ");
                Evaluacion nota = Evaluacion.Parse(Console.ReadLine()!);
                grupo.AgregarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nombreDeLaBanda}");
                Thread.Sleep(2000);
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