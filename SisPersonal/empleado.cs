namespace EspacioEmpleados;

using EspacioCargos;

public class Empleados
{
    private string? nombre;
    private string? apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldo;
    private cargos cargoEmpleado;

    public String Nombre { get => nombre; set => nombre = value; }
    public String Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public Char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public Double Sueldo { get => sueldo; set => sueldo = value; }
    public cargos CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }

    /* Metodos */

    public int Antiguedad()
    {
        DateTime fechaActual = DateTime.Now;
        int antiguedad = fechaActual.Year - fechaIngreso.Year;
        if (fechaActual.Month < fechaIngreso.Month ||
            (fechaActual.Month == fechaIngreso.Month && fechaActual.Day < fechaIngreso.Day))
        {
            antiguedad--;
        }
        return antiguedad;
    }

    public int Edad()
    {
        DateTime fechaActual = DateTime.Now;

        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaIngreso.Day))
        {
            edad--;
        }

        return edad;
    }

    public void Jubilacion()
    {
        int edad = Edad();
        int faltaJubilacion = 0;
        if (edad < 65)
        {
            faltaJubilacion = 65 - edad;
            Console.WriteLine($"Le falta {faltaJubilacion} años para su jubilacion");
        }else
        {
            Console.WriteLine("Ya puede jubilarse");
        }

        
    }

    public double salario()
    {
        double adicional = 0;
        int antiguedad = Antiguedad();

        if (antiguedad <= 20)
        {
            adicional = sueldo * (antiguedad * 0.01);
        }
        else
        {
            adicional = sueldo * 0.25;
        }

        if (cargoEmpleado == cargos.Ingeniero || cargoEmpleado == cargos.Especialista)
        {
            adicional *= 1.5;
        }

        if (estadoCivil == 'C' || estadoCivil == 'c')
        {
            adicional += 150000;
        }

        return Sueldo + adicional;
    }
}