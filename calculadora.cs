namespace EspacioCalculadora;

public class Calculadora{
    private double valor;

    public Calculadora()
    {
        valor = 0;
    }

    public void Suma(double sumando){
        valor += sumando;
    }

    public void Restar(double restando){
        valor -= restando;
    }

    public void Multipilicar(double multiplicador){
        valor *= multiplicador;
    }

    public void Dividir(double divisor){
        if (divisor != 0)
        {
            valor /= divisor;
        }
    }

    public void Limpiar(){
        valor = 0;
    }

    public double Resultado { get => valor; }



}