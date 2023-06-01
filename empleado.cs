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
    private string nombre = String.Empty;
    private string apellido = String.Empty;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private char genero;
    private DateTime fechaingreso;
    private double sueldobasico;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public char Genero { get => genero; set => genero = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    public int edad;
    public int antiguedad;
    
    public void Antiguedad(DateTime Fechaingreso){
        antiguedad = DateTime.Now.Year - Fechaingreso.Year;
    }
    public void CalcularEdad(DateTime Fechadenacimiento){
        edad = DateTime.Now.Year - Fechadenacimiento.Year;
    }

    public void Jubilacion(char Genero){
        if (Genero == 'm')
        {
            
        }
    }



}
