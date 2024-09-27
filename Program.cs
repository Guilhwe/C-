// See https://aka.ms/new-console-template for more information
string mensajeDeBienvenida= "Bienvenidos a Screen Sound";
//List<string> ListaDeBandas = new List<string>{"Linkin Park", "U2", "SKILLET"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int>{10,9,10});
bandasRegistradas.Add("U2", new List<int>{10,8,5,3});
bandasRegistradas.Add("Pink Floyd", new List<int>{10,9,10});
bandasRegistradas.Add("Beatles", new List<int>());

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
        case 3: PuntuarBandas();
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
    MostrarTituloDeLaOpcion("Registrar banda");
    Console.Write("Escribe el nombre de la banda que deseas registrar: ");
    string nombreDeLaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nombreDeLaBanda,new List<int>());
    Console.WriteLine($"La banda {nombreDeLaBanda} fue registrada");
    Thread.Sleep(2000);
    Console.Clear();
    MostrarMenu();
}

void ListarBandas()
{
    Console.Clear();
    MostrarTituloDeLaOpcion("Listando las bandas registradas");
    //for (int i = 0; i<ListaDeBandas.Count; i++)//mientras i sea menor que lista de bandas repite x y sumale uno a i
    //{
       // Console.WriteLine($"Banda: {ListaDeBandas[i]}");
    //}
    foreach(string banda in bandasRegistradas.Keys)//forma mas sintetizada de la forma de arriba
    Console.WriteLine($"Banda: {banda}");
    Console.WriteLine("\nPulse cualquier tecla para volver al menu principal");
    Console.ReadKey();
    Console.Clear();
    MostrarMenu();

}

void PuntuarBandas()
{

Console.Clear();
MostrarTituloDeLaOpcion("Valorar Banda");
Console.WriteLine("Escribe el nombre de la banda que quieres evaluar: ");
string nombreDeLaBanda = Console.ReadLine()!;
if (bandasRegistradas.ContainsKey(nombreDeLaBanda))//comprueba si l banda esta en el diccionario
{
    Console.Write($"Que nota le das a la banda {nombreDeLaBanda}:");
    int nota =int.Parse(Console.ReadLine()!);
    bandasRegistradas[nombreDeLaBanda].Add(nota);
    Console.WriteLine($"La nota {nota} fue registrada en la banda{nombreDeLaBanda}");
    Thread.Sleep(2000);
    Console.Clear();
    MostrarMenu();


}else{
    Console.WriteLine($"\nLa banda {nombreDeLaBanda} no fue encontrada");
    Console.WriteLine("Pulse una tecla para vlver al menu");
    Console.ReadKey();
    Console.Clear();
    MostrarMenu();

}

}

void MostrarTituloDeLaOpcion(string titulo)
{
    int cantidadDeLetras= titulo.Length;
    string asteriscos = string.Empty.PadLeft(cantidadDeLetras,'*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos +"\n");
}