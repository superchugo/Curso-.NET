Console.Clear();

Console.WriteLine("Por favor ingrese el número de elementos que desea tener");
int cantidad = int.Parse(Console.ReadLine()); 


int[] elementos = new int[cantidad];
int aux;

for (int i = 0; i < cantidad; i++){
        Console.WriteLine("Por favor ingrese un número");
        elementos[i] = int.Parse(Console.ReadLine()); 
    }   


Console.Write("Los números ingresados son: ");
for (int i = 0; i < cantidad; i++)
    Console.Write($"{elementos[i]}, ");
    
Console.WriteLine("");    

for (int i = 0; i < cantidad/2; i++){
     aux = elementos[i];
     elementos[i] = elementos[cantidad-1-i];
     elementos[cantidad-1-i] = aux;
}


Console.Write("Los números ingresados al revez son: ");
for (int i = 0; i < cantidad; i++)
    Console.Write($"{elementos[i]}, ");


Console.WriteLine();
Console.WriteLine("Presione una tecla para finalizar la ejecución");
Console.ReadKey();    