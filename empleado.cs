namespace Empleados;

public class Empleado{

    //atributos
    private string nombre = String.Empty;
    private string apellido = String.Empty;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private DateTime fechaingreso;
    private double sueldobasico;
    private Cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    //internal Cargos Cargo { get => cargo; set => cargo = value; }
    //metodos

    public int edad;
    public int antiguedad;
    
    void Antiguedad(DateTime Fechaingreso){
        antiguedad = DateTime.Now.Year - Fechaingreso.Year;
    }
    void CalcularEdad(DateTime Fechadenacimiento){
        edad = DateTime.Now.Year - Fechadenacimiento.Year;
    }




}

enum Cargos{

    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}