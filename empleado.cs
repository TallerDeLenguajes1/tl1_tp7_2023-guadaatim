namespace Empleados;

public class Empleado{
    private string nombre;
    private string apellido;
    private DateTime fechadenacimiento;
    private char estadocivil;
    private DateTime fechaingreso;
    private double sueldobasico;
    private string cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime Fechadenacimiento { get => fechadenacimiento; set => fechadenacimiento = value; }
    public char Estadocivil { get => estadocivil; set => estadocivil = value; }
    public DateTime Fechaingreso { get => fechaingreso; set => fechaingreso = value; }
    public double Sueldobasico { get => sueldobasico; set => sueldobasico = value; }
    public string Cargo { get => cargo; set => cargo = value; }
}

enum Cargos{

    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador,
}