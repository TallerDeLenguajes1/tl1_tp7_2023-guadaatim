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
        int jubilacion1 = 0;

        if (Genero == 'm' || Genero == 'M')
        {
            if (edad < 60)
            {
                jubilacion1 = 60 - edad;
            }
        } else
        {
            if (edad < 65)
            {
                jubilacion1 = 65 - edad;
            }
        }

        return jubilacion1;
    }

    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = CalcularAntiguedad();

        if (antiguedad <= 20)
        {
            adicional += this.sueldobasico * CalcularAntiguedad() * 0.01;
        } else
        {
            adicional += Sueldobasico * 0.25;
        }
        if ((Cargo == Cargos.Ingeniero) || (Cargo == Cargos.Especialista))
        {
            adicional = adicional * 1.5;
        }
        if (Estadocivil == 'C' || Estadocivil == 'c')
        {
            adicional += 15000;
        }

        return Sueldobasico + adicional;

    }

}
