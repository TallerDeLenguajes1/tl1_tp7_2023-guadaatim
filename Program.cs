using Empleados;

Empleado[] empleaditos = new Empleado[3];

for (int i = 0; i < 3; i++)
{
    empleaditos[i] = new Empleado();
    Console.WriteLine("Ingrese el nombre de empleado: ");
    empleaditos[i].Nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el apellido: ");
    empleaditos[i].Apellido = Console.ReadLine();
    Console.WriteLine("Ingrese la fecha de nacimiento: ");
    //DateTime.TryParse(Console.ReadLine(), out empleaditos[i].Fechadenacimiento);
    Console.WriteLine("Ingrese su estado civil: ");
    //char.TryParse(Console.ReadLine(), out empleaditos[i].Estadocivil);
    Console.WriteLine("Ingrese su genero: ");

    Console.WriteLine("Ingrese su fecha de ingreso a la empresa: ");

    Console.WriteLine("Ingrese su sueldo basico: ");
    //double.TryParse(Console.ReadLine(), out empleaditos[i].Sueldobasico);
    int cargox = 0;
    Console.WriteLine("Ingrese su cargo: ");
    Console.WriteLine("0 - Auxiliar");
    Console.WriteLine("1 - Administrativo");
    Console.WriteLine("2 - Ingeniero");
    Console.WriteLine("3 - Especialista");
    Console.WriteLine("4 - Investigador");
    //cargox.TryParse(Console.ReadLine(), out empleaditos[i].Cargo);

    
    
}

int indice = 9;
int mayor = 0;
for (int i = 0; i < 3; i++)
{
    if (empleaditos[i].Jubilacion1 > mayor)
    {
        indice = i;        
    }
}