public class Cuadrado : Cuadrilatero{
    readonly decimal Lado;
    public Cuadrado(decimal lado)
    {
        Lado = lado;
    }
    public override decimal Area()
    {
        return Lado * Lado;
    }
}