// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EspacioCalculadora;

Calculadora cal = new Calculadora();

int opcion;
double num1;
double num2;
int a = 1;

while (a != 0)
{
    Console.WriteLine("Ingrese un numero: ");
    double.TryParse(Console.ReadLine(), out num1);

    Console.WriteLine("Ingrese otro numero: ");
    double.TryParse(Console.ReadLine(), out num2);

    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicacion");
    Console.WriteLine("4 - Division");

    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            cal.Suma(num1); 
        break;
        case 2: 
            cal.Restar(num1);
        break;
        case 3: 
            cal.Multipilicar(num1);
        break;
        case 4: 
            cal.Dividir(num1);
        break;
    }

    Console.WriteLine("Resultado: " + cal.Resultado);

    Console.WriteLine("Ingrese 1 para realizar otra operacion o 0 para terminar: ");
    int.TryParse(Console.ReadLine(), out a);
}