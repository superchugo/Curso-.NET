string respuesta = "S";
while (respuesta.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Por favor ingrese su nombre");
    String nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre}");
    Console.WriteLine("Desea continuar? S/N");
    respuesta = Console.ReadLine();
}

if (respuesta.ToUpper() == "N")
    Console.WriteLine("Programa finalizado correctamente");
else
    Console.WriteLine("Opcion no valida");

Console.WriteLine("Presione una tecla para finalizar la ejecucion");
Console.ReadKey();    