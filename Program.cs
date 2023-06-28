using Empleados;

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado[] empleaditos = new Empleado[3];
        string? nacimientostr;
        DateTime nacimientox;
        string? sueldobasicostr;
        double sueldobasicox;
        string? ingresostr;
        DateTime ingreso;
        string? generostr;
        char generox;
        string? estadocivilstr;
        char estadocivilx;
        string? cargostr;
        int cargox;

        //cargar datos
        for (int i = 0; i < 2; i++)
        {
            empleaditos[i] = new Empleado();
            Console.WriteLine("Ingrese el nombre de empleado: ");
            empleaditos[i].Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido: ");
            empleaditos[i].Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: ");
            nacimientostr = Console.ReadLine();
            DateTime.TryParse(nacimientostr, out nacimientox);
            empleaditos[i].Fechadenacimiento = nacimientox;
            Console.WriteLine("Ingrese su estado civil: ");
            estadocivilstr = Console.ReadLine();
            char.TryParse(estadocivilstr, out estadocivilx);
            empleaditos[i].Estadocivil = estadocivilx;
            Console.WriteLine("Ingrese su genero: ");
            generostr = Console.ReadLine();
            char.TryParse(generostr, out generox);
            empleaditos[i].Genero = generox;
            Console.WriteLine("Ingrese su fecha de ingreso a la empresa: ");
            ingresostr = Console.ReadLine();
            DateTime.TryParse(ingresostr, out ingreso);
            empleaditos[i].Fechaingreso = ingreso;
            Console.WriteLine("Ingrese su sueldo basico: ");
            sueldobasicostr = Console.ReadLine();
            double.TryParse(sueldobasicostr, out sueldobasicox);
            empleaditos[i].Sueldobasico = sueldobasicox;
            Console.WriteLine("Ingrese su cargo: ");
            Console.WriteLine("0 - Auxiliar");
            Console.WriteLine("1 - Administrativo");
            Console.WriteLine("2 - Ingeniero");
            Console.WriteLine("3 - Especialista");
            Console.WriteLine("4 - Investigador");
            cargostr = Console.ReadLine();
            int.TryParse(cargostr, out cargox);
            switch (cargox)
            {
                case 0:
                    empleaditos[i].Cargo = Cargos.Auxiliar;
                    break;
                case 1:
                    empleaditos[i].Cargo = Cargos.Administrativo;
                    break;
                case 2:
                    empleaditos[i].Cargo = Cargos.Ingeniero;
                    break;
                case 3:
                    empleaditos[i].Cargo = Cargos.Especialista;
                    break;
                case 4:
                    empleaditos[i].Cargo = Cargos.Investigador;
                    break;
            }

        }

        //calcular monto total
        double montoTotal = 0;

        for (int i = 0; i < 1; i++)
        {
            Console.WriteLine("------DATOS DEL EMPLEADO-------");
            MostrarEmpleados(empleaditos, i);
            montoTotal += empleaditos[i].Salario;
        }

        int indice = 0;
        int x = 0;

        //empleado proximo a jubilarse
        for (int i = 0; i < 3; i++)
        {
            if (x == 0)
            {
                indice = i;
            }
            else
            {
                if (empleaditos[indice].Jubilacion() < empleaditos[i].Jubilacion())
                {
                    indice = i;
                }
            }
        }
        
        Console.WriteLine("------DATOS DEL EMPLEADO MAS PROXIMO A JUBILARSE-------");
        MostrarEmpleados(empleaditos, indice);
    
    }

    private static void MostrarEmpleados(Empleado[] empleaditos, int i)
    {
        Console.WriteLine("Nombre: " + empleaditos[i].Nombre);
        Console.WriteLine("Apellido: " + empleaditos[i].Apellido);
        Console.WriteLine("Fecha de nacimiento: " + empleaditos[i].Fechadenacimiento.Date);
        Console.WriteLine("Edad: " + empleaditos[i].CalcularEdad());
        if (empleaditos[i].Estadocivil == 'S')
        {
            Console.WriteLine("Estado civil: Soltero");
        } else
        {
            Console.WriteLine("Estado Civil: Casado");
        }
        Console.WriteLine("Genero: " + empleaditos[i].Genero);
        Console.WriteLine("Cargo: " + empleaditos[i].Cargo);
        Console.WriteLine("Sueldo Basico: " + empleaditos[i].Sueldobasico);
        Console.WriteLine("Salario: " +empleaditos[i].CalcularSalario());
    }
}