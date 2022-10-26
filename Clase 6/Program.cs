Console.Clear();
int respuesta;
int intentos = 0;
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
do
{
    Console.WriteLine("Por favor ingrese el número secreto");
    respuesta = int.Parse(Console.ReadLine());
    intentos++;
    if (respuesta > numeroSecreto)
        Console.WriteLine("El número ingresado es mayor al número secreto");
    else if (respuesta < numeroSecreto)
            Console.WriteLine("El número ingresado es menor al número secreto");
        else    
        {
            Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
            Console.WriteLine($"Lo has logrado en {intentos} intentos!!");
        }
} while (numeroSecreto != respuesta);

Console.WriteLine("Presione una tecla para finalizar la ejecución");
Console.ReadKey();    