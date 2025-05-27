using EspacioCalculadora;

Calculadora calculadora1 = new Calculadora();

int opcion = 0, bandera = 0; 
double numero = 0;


Console.WriteLine("Bienvenido a la calculadora, donde podras hacer calculos simples :D \n (Puedes hacer +, -, * y /)");

do
{
    Console.WriteLine("Elige que operacion quieres realizar: \n 1)Sumar \n 2)Restar \n 3)Multiplicar \n 4)Dividir \n 5)Empezar un nuevo calculo \n 6)Salir de la calculadora");
    int.TryParse(Console.ReadLine(), out opcion);

    if (opcion != 5 && opcion != 6)
    {
        Console.WriteLine("Ingrese el numero para calcular:");
        double.TryParse(Console.ReadLine(), out numero);
    }
    switch (opcion)
    {
        case 1:
            calculadora1.Sumar(numero);
            break;

        case 2:
            calculadora1.Restar(numero);
            break;

        case 3:
            calculadora1.Multiplicar(numero);
            break;

        case 4:
            calculadora1.Dividir(numero);
            break;

        case 5:
            Console.WriteLine("Iniciando nuevo calculo...");
            calculadora1.Limpiar();
            break;

        case 6:
            Console.WriteLine("Saliendo de la calculadora...");
            Console.WriteLine("Bye :D");
            bandera = 1;
            break;

        default:
            break;
    }
    if (opcion != 5 && opcion != 6)
    {
        Console.WriteLine("Tu resultado actual es:");
        Console.WriteLine(calculadora1.Resultado.ToString());
    }else
    {
        opcion = 0;
    }


} while (bandera != 1);

