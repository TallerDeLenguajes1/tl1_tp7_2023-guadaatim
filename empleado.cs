namespace Empleados;

public enum Cargos{

    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}

public class Empleado{

    //atributos
    private string? nombre;
    private string? apellido;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private char genero;
    private DateTime fechaingreso;
    private double sueldobasico;
    private Cargos cargo;
    private double adicional;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public char Genero { get => genero; set => genero = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }


    //metodos
    public int CalcularAntiguedad(){
        
        int antiguedad = DateTime.Now.Year - Fechaingreso.Year;
        return antiguedad;
    }
    public int CalcularEdad(){
        int edad = DateTime.Now.Year - Fechadenacimiento.Year;
        return edad;
    }

    public int Jubilacion(){
        int edad = CalcularEdad();

        if (Genero == 'm' || Genero == 'M')
        {
            if (edad < 60)
            {
                return 60 - edad;
            } else
            {
                return 0;
            }
        } else
        {
            if (edad < 65)
            {
                return 65 - edad;
            } else
            {
                return 0;
            }
        }
    }

    public double CalcularSalario()
    {
        int adicional = 0;
        int antiguedad = CalcularAntiguedad();


        if (antiguedad <= 20)
        {
            adicional += Sueldobasico * (antiguedad / 100);
        } else
        {
            adicional += Sueldobasico * 0.75;
        }
        if ((Cargo == Cargos.Ingeniero) || (Cargo == Cargos.Especialista))
        {
            adicional += Adicional * 1.5;
        }
        if (Estadocivil == 'C' || Estadocivil == 'c')
        {
            adicional += 15000;
        }

        return Sueldobasico + Adicional;
    }

}
