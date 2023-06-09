using Empleados;

Empleado[] empleado = new(3);

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Ingrese nombre del empleado: ");
    empleado[i].Nombre = Console.Readline();
    Console.WriteLine("Ingrese el apellido: ");
    empleado[i].Apellido = Console.Readline();
}