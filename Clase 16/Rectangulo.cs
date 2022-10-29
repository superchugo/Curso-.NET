public class Rectangulo : Cuadrilatero{
    readonly decimal Lado;
    public Rectangulo(decimal lado)
    {
        Lado = lado;
    }
    public override decimal Area()
    {
        return Lado * Lado;
    }
}    
