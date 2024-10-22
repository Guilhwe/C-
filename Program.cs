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
                    RegistrarAlbum();
                    break;
                case 3:
                    MostrarBandasRegistradas();
                    break;
                case 4:
                    AvaliarUmaBanda();
                    break;
                case 5:
                    MenuExhibirDetalles menu = new MenuExhibirDetalles();
                    menu.Ejecutar(bandasRegistradas);
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

        void RegistrarAlbum()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registro de álbuns");
            Console.Write("Digite a banda cujo álbum deseja registrar: ");
            string nombreDeLaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nombreDeLaBanda))
            {
                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Grupo grupo = bandasRegistradas[nombreDeLaBanda];
                grupo.AgregarAlbum(new Album(tituloAlbum));
                Console.WriteLine($"O álbum {tituloAlbum} de {nombreDeLaBanda} foi registrado com sucesso!");
                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nombreDeLaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();

            }


            ExibirOpcoesDoMenu();
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

        void MostrarBandasRegistradas()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
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

        void AvaliarUmaBanda()
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
                ExibirOpcoesDoMenu();
            }
            else
            {
                Console.WriteLine($"\nA banda {nombreDeLaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }

        }

        

        ExibirOpcoesDoMenu();
    }
}