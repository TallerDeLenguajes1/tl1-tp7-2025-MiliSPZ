// See https://aka.ms/new-console-template for more information

using EspacioCargos;
using EspacioEmpleados;

double MontoSalarioTotal = 0;
Empleados[] empleado = new Empleados[3];

for (int i = 0; i < 3; i++)
{
    empleado[i] = new Empleados();
    empleado[i].Nombre = "Empleado" + (i + 1);
    empleado[i].Apellido = "Apellido" + (i + 1);
    empleado[i].FechaNacimiento = new DateTime(1990 + i, 1, 1);
    empleado[i].EstadoCivil = 'c';
    empleado[i].FechaIngreso = new DateTime(2010 + 1, 1, 1);
    empleado[i].Sueldo = 450000;
    empleado[i].CargoEmpleado = cargos.Ingeniero;
    double salario = empleado[i].salario();

    MontoSalarioTotal += empleado[i].Sueldo;
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("-----------------------------");
    Console.WriteLine($"{empleado[i].Nombre}");
    Console.WriteLine($"{empleado[i].Apellido}");
    Console.WriteLine($"Fecha de Nacimiento: {empleado[i].FechaNacimiento.ToShortDateString()}");
    Console.WriteLine($"Fecha de Ingreso: {empleado[i].FechaIngreso.ToShortDateString()}");
    Console.WriteLine($"Estado Civil: {empleado[i].EstadoCivil}");
    Console.WriteLine($"Sueldo: {empleado[i].Sueldo}");
    Console.WriteLine($"Cargo: {empleado[i].CargoEmpleado}");
    Console.WriteLine($"Antiguedad: {empleado[i].Antiguedad()}");
    empleado[i].Jubilacion();
    Console.WriteLine($"Salario: {empleado[i].salario()}");
}

Console.WriteLine($"Monto Total a pagar a los empleaos es de: {MontoSalarioTotal}");