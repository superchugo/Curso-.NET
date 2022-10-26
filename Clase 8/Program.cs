Console.Clear();

Console.WriteLine("Por favor ingrese el número de filas");
int filas = int.Parse(Console.ReadLine()); 
Console.WriteLine("Por favor ingrese el número de columnas");
int columnas = int.Parse(Console.ReadLine()); 

int[,] numeros = new int[filas, columnas];
double[] promedio = new double[columnas];

int cantidadFilas = numeros.GetUpperBound(0) + 1;
int cantidadColumnas = numeros.GetUpperBound(1) + 1;

for (int fila = 0; fila < cantidadFilas; fila++){
    for (int columna = 0; columna < cantidadColumnas; columna++){
        Console.WriteLine("Por favor ingrese un número");
        numeros[fila, columna] = int.Parse(Console.ReadLine()); 
    }   
}

for (int fila = 0; fila < cantidadFilas; fila++){
    for (int columna = 0; columna < cantidadColumnas; columna++){
        Console.Write($"   {numeros[fila, columna]}");
    } 
    Console.WriteLine();  
}


for (int columna = 0; columna < cantidadColumnas; columna++){
    int suma = 0;
    for (int fila = 0; fila < cantidadFilas; fila++){
        suma = suma + numeros[fila, columna];
    }
    promedio[columna] =  (double)suma / (double)cantidadFilas; 
}

Console.Write("Los promedios son: ");
for (int i = 0; i < cantidadColumnas; i++)

    Console.Write($"{promedio[i]}, ");
    

Console.WriteLine();
Console.WriteLine("Presione una tecla para finalizar la ejecución");
Console.ReadKey();    