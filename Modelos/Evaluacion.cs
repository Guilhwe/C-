namespace ScreenSound1.Modelos;

internal class Evaluacion
{
    public Evaluacion(int nota)
    {
        Nota = nota;
    }
    public int Nota {get;}

    public static Evaluacion Parse(string texto)
    {
        int nota =  int.Parse(texto);
        return new Evaluacion(nota);
    }
}