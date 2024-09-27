// See https://aka.ms/new-console-template for more information
string mensajeDeBienvenida= "Bienvenidos a Screen Sound";
List<string> ListaDeBandas = new List<string>{"Linkin Park", "U2", "SKILLET"};
void MostrarMensajeDeBienvenida()

{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensajeDeBienvenida);
}
void MostrarMenu()
{
    Console.WriteLine("\nElija 1 para registrar una banda");
    Console.WriteLine("Elija 2 para listar todas las bandas");
    Console.WriteLine("Elija 3 para puntuar una banda");
    Console.WriteLine("Elija 4 para ver la media de una banda");
    Console.WriteLine("Elija -1 para salir");
    Console.Write("\nElige la opción: ");
    string opciónElegida = Console.ReadLine()!;//! evita el valor nulo
    int opciónElegidaNumerica = int.Parse(opciónElegida);
    
    switch(opciónElegidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ListarBandas();
            break;
        case 3: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case 4: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case -1: Console.WriteLine("Hasta la próximaaa!!");
            break;
        default: Console.WriteLine("Opción no válida");
            break;
    }
}
MostrarMensajeDeBienvenida();
MostrarMenu();




void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("**********************************\n");
    Console.Write("Escribe el nombre de la banda que deseas registrar: ");
    string nombreDeLaBanda = Console.ReadLine()!;
    ListaDeBandas.Add(nombreDeLaBanda);
    Console.WriteLine($"La banda {nombreDeLaBanda} fue registrada");
    Thread.Sleep(2000);
    Console.Clear();
    MostrarMenu();
}

void ListarBandas()
{
    Console.Clear();
    Console.WriteLine("**********************************");
    Console.WriteLine("Listando las bandas registradas");
    Console.WriteLine("**********************************\n");
    for (int i = 0; i<ListaDeBandas.Count; i++)//mientras i sea menor que lista de bandas repite x y sumale uno a i
    {
        Console.WriteLine($"Banda: {ListaDeBandas[i]}");
    }
    Console.WriteLine("\nPulse cualquier tecla para volver al menu principal");
    Console.ReadKey();
    Console.Clear();
    MostrarMenu();

}
