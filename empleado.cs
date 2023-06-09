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

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public char Genero { get => genero; set => genero = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }
    public int Edad { get => edad; set => edad = value; }
    public int Antiguedad1 { get => antiguedad; set => antiguedad = value; }
    public int Jubilacion1 { get => jubilacion; set => jubilacion = value; }

    public void Antiguedad(DateTime Fechaingreso){
        Antiguedad1 = DateTime.Now.Year - Fechaingreso.Year;
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



}
