/*trapecio dos lados paralelos
Cuadrado 4 lados iguales
rectangulo 2 lados iguales*/
using clase16;

float x1,y1,x2,y2;
		double D;
		char si='s';
		while (si=='s')
		{
			
		Console.WriteLine("Ingresar coordenada del Punto 1");
		x1=float.Parse(Console.ReadLine());
		y1=float.Parse(Console.ReadLine());
		Console.WriteLine("Coordenada: ({0},{1})", x1,y1);
			
		Console.WriteLine("Ingresar coordenada del Punto 2");
		x2=float.Parse(Console.ReadLine());
		y2=float.Parse(Console.ReadLine());
		Console.WriteLine("Coordenada: ({0},{1})",x2,y2);
		
		D=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
		
		Console.WriteLine("La distancia del punto 1 ({0},{1}) y el punto 2 ({2},{3}) es: {4}", x1,y1,x2,y2,D);
		
		Console.WriteLine("Calcular otra distancia s/n");
		si=char.Parse(Console.ReadLine());
		Console.Clear();
        }