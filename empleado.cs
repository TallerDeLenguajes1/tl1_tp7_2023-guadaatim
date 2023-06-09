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
    private int edad;
    private int antiguedad;
    private int jubilacion;
    private double adicional;
    private int salario;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public char Genero { get => genero; set => genero = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Antiguedad { get => antiguedad; set => antiguedad = value; }
    public int Jubilacion1 { get => jubilacion; set => jubilacion = value; }
    public double Adicional { get => adicional; set => adicional = value; }
    public int Salario { get => salario; set => salario = value; }

    //metodos
    public void CalcularAntiguedad(DateTime Fechaingreso){
        Antiguedad = DateTime.Now.Year - Fechaingreso.Year;
    }
    public void CalcularEdad(DateTime Fechadenacimiento){
        Edad = DateTime.Now.Year - Fechadenacimiento.Year;
    }

    public void Jubilacion(char Genero){
        if (Genero == 'm' || Genero == 'M')
        {
            if (Edad < 60)
            {
                Jubilacion1 = 60 - Edad;
            } else
            {
                Jubilacion1 = 0;
            }
        } else
        {
            if (Edad < 65)
            {
                Jubilacion1 = 65 - Edad;
            } else
            {
                Jubilacion1 = 0;
            }
        }
    }

    public void CalcularAdicional(int Antiguedad, Cargos Cargo, char Estadocivil)
    {
        Adicional = 0;

        if (Antiguedad <= 20)
        {
            Adicional += Sueldobasico * (Antiguedad / 100);
        } else
        {
            Adicional += Sueldobasico * 0.75;
        }
        if (Cargos.Ingeniero || Cargos.Especialista)
        {
            Adicional += Adicional * 1.5;
        }
        if (Estadocivil == 'C' || Estadocivil == 'c')
        {
            Adicional += 15000;
        }
    }

    public void CalcularSalario(double Sueldobasico, double Adicional)
    {
        Salario = Sueldobasico + Adicional;
    }


}
