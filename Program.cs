using ScreenSound1.Menus;
using ScreenSound1.Modelos;
internal class Program
{
    private static void Main(string[] args)
    {
        Grupo linkinpark = new Grupo("Linkin Park");
        linkinpark.AgregarNota(new Evaluacion(10));
        linkinpark.AgregarNota(new Evaluacion(9));
        linkinpark.AgregarNota(new Evaluacion(6));
        Grupo u2 = new Grupo("U2");
        u2.AgregarNota(new Evaluacion(5));
        u2.AgregarNota(new Evaluacion(8));
        u2.AgregarNota(new Evaluacion(7));

        Dictionary<string, Grupo> bandasRegistradas = new();
        bandasRegistradas.Add(linkinpark.Nombre, linkinpark);
        bandasRegistradas.Add(u2.Nombre, u2);

        Dictionary<int, Menu> opciones = new();
        opciones.Add(1, new MenuRegistrarBanda());
        opciones.Add(2, new MenuRegistrarAlbum());
        opciones.Add(3, new MenuBandasRegistradas());
        opciones.Add(4, new MenuEvaluarBanda());
        opciones.Add(5, new MenuExhibirDetalles());
        opciones.Add(-1, new MenuSalir());

        void ExibirLogo()
        {
            Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }
        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite -1 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if(opciones.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExhibido = opciones[opcaoEscolhidaNumerica];
                menuASerExhibido.Ejecutar(bandasRegistradas);
                if (opcaoEscolhidaNumerica>0) ExibirOpcoesDoMenu();
            }  
            else
            {
                Console.WriteLine("Opção inválida");
            }
            

           
        }
        ExibirOpcoesDoMenu();
    }
}