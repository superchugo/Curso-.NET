public class Trapecio : Cuadrilatero{
    readonly decimal Lado;
    public Trapecio(decimal lado)
    {
        Lado = lado;
    }
    public override decimal Area()
    {
        return Lado * Lado;
    }
}