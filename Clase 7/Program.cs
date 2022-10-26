Console.Clear();
int[] numeros = new int[10];
for (int i = 0; i < 10; i++){
    Console.WriteLine($"Por favor ingrese el {i+1}° número");
    numeros[i] = int.Parse(Console.ReadLine()); 
}

int suma = 0;
int mayor = 0;
int menor = 0;
float promedio = 0;

for (int i = 0; i < 10; i++){
    suma = suma + numeros[i];
    if (mayor < numeros[i])
        mayor = numeros[i];
    if (menor > numeros[i])
        menor = numeros[i];
}
  
Console.Clear();  
Console.WriteLine($"La suma de los números ingresados es: {suma}");
Console.WriteLine($"El número mayor de los números ingresados es: {mayor}");
Console.WriteLine($"El número menor de los números ingresados es: {menor}");
Console.WriteLine($"El promedio de los números ingresados es: {suma/10}");
Console.Write("Los números ingresados son: ");
for (int i = 0; i < 10; i++)
    Console.Write($"{i}, ");
    

Console.WriteLine();
Console.WriteLine("Presione una tecla para finalizar la ejecución");
Console.ReadKey();    