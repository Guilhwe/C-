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

            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    RegistrarBanda();
                    break;
                case 2:
                    MenuRegistrarAlbum menu2 = new();
                    menu2.Ejecutar(bandasRegistradas);
                    break;
                case 3:
                    MenuBandasRegistradas menu3 = new();
                    menu3.Ejecutar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 4:
                    MenuEvaluarBanda menu4 = new();
                    menu4.Ejecutar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    break;
                case 5:
                    MenuExhibirDetalles menu5 = new MenuExhibirDetalles();
                    menu5.Ejecutar(bandasRegistradas);
                    ExibirOpcoesDoMenu();
                    
                    break;
                case -1:
                    Console.WriteLine("Hasta la proxima)");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        
        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro das bandas");
            Console.Write("Digite o nome da banda que deseja registrar: ");
            string nombreDeLaBanda = Console.ReadLine()!;
            Grupo grupo = new(nombreDeLaBanda);
            bandasRegistradas.Add(nombreDeLaBanda, grupo);
            Console.WriteLine($"A banda {nombreDeLaBanda} foi registrada com sucesso!");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }

      
        void ExibirTituloDaOpcao(string titulo)
        {
            int quantidadeDeLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }

        

        

        

        ExibirOpcoesDoMenu();
    }
}