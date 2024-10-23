using ScreenSound1.Modelos;
namespace ScreenSound1.Menus;

internal class MenuRegistrarAlbum : Menu
{
     public override void Ejecutar(Dictionary<string, Grupo> bandasRegistradas)
     {
        base.Ejecutar(bandasRegistradas);
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

     }
}