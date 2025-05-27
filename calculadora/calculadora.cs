namespace EspacioCalculadora;

public class Calculadora
{
    private double resultado=0;
    public double Resultado { get => resultado; }

    public void Sumar(double termino)
    {
        resultado += termino;
    }

    public void Restar(double termino)
    {
        resultado -= termino;
    }

    public void Multiplicar(double termino)
    {
        resultado *= termino;
    }

    public void Dividir(double termino)
    {
        if (termino != 0)
        {
            resultado /= termino;
        }else
        {
            Console.WriteLine("No se puede dividir por 0");
        }
    }

    public void Limpiar()
    {
        resultado = 0;
    }
}
