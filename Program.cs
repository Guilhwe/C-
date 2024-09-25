// See https://aka.ms/new-console-template for more information
string mensajeDeBienvenida= "Bienvenidos a Screen Sound";
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
        case 1: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case 2: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case 3: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case 4: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        case -1: Console.WriteLine("Elegiste la opción " + opciónElegidaNumerica);
            break;
        default: Console.WriteLine("Opción no válida");
            break;
    }
}
MostrarMensajeDeBienvenida();
MostrarMenu();



