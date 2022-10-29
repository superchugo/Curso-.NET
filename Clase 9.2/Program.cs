//Console.Clear();

int cantidadFilas = 3;
int cantidadColumnas = 9;
int[,] carton = new int[cantidadFilas, cantidadColumnas];
Random numero = new Random();
Random espacios = new Random();

for (int columna = 0; columna < cantidadColumnas; columna++){
    int espaciosVacios = espacios.Next(1,3);
    for (int fila = 0; fila < cantidadFilas-espaciosVacios; fila++){
        int cantnumeros = 0;
        while (cantnumeros < cantidadFilas){
            carton[fila, columna] = numero.Next(0, 11) + (10 * columna) ;
            cantnumeros++;
        }     
    }   
}

for (int fila = 0; fila < cantidadFilas; fila++){
    for (int columna = 0; columna < cantidadColumnas; columna++){
        Console.Write($"   {carton[fila, columna]}");
    } 
    Console.WriteLine();  
}


Son 3 filas a llenar con 5 números cada una, en la primera selecciono al azar 3 columnas que serán las que solo pueden tener 1 número y 2 números al azar más.
En la segunda fila pongo los números en los 4 espacios de la primera más una columna cualquiera.
En la tercer fila solo me quedan obligatoriamente las columnas que no sean no las tres que tienen un número solo ni la otra que ya tiene 2.
Además hay que agregarle la lógica de que los números no se repitan, eso lo controlo por columna
