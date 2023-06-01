namespace EspacioCalculadora;

public class Calculadora{
    private double valor;

    public Calculadora()
    {
        valor = 0;
    }

    public double Resultado { get => valor; }

    public void Suma(double sumando){
        valor += sumando;
    }
}