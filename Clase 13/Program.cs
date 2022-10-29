using claseBilletera; 

Console.Clear();
Billetera billetera1, billetera2, billetera3 = null;
int respuesta = 0;
int billeteDiez, billeteVeite, billeteCincuenta, billeteCien, billeteDoscientos, billeteQuinientos, billeteMil;
do {
    Console.WriteLine("1 - Total Billetera");
    Console.WriteLine("2 - Combinar Billeteras");
    Console.WriteLine("3 - Salir");
    respuesta = int.Parse(Console.ReadLine());

if (respuesta == 1) {
    Console.WriteLine("Por favor ingrese el número de billetes de $10 que contiene la billetera");
    billeteDiez = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $20 que contiene la billetera");
    billeteVeite = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $50 que contiene la billetera");
    billeteCincuenta = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $100 que contiene la billetera");
    billeteCien = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $200 que contiene la billetera");
    billeteDoscientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $500 que contiene la billetera");
    billeteQuinientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $1000 que contiene la billetera");
    billeteMil = int.Parse(Console.ReadLine()); 
    billetera1 = new Billetera(billeteDiez,billeteVeite,billeteCincuenta,
                    billeteCien,billeteDoscientos,billeteQuinientos,billeteMil);
    Console.WriteLine($"La billetera de tiene $ {billetera1.total().ToString()}");
    }

if (respuesta == 2) {
    Console.WriteLine("Por favor ingrese el número de billetes de $10 que contiene la billetera");
    billeteDiez = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $20 que contiene la billetera");
    billeteVeite = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $50 que contiene la billetera");
    billeteCincuenta = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $100 que contiene la billetera");
    billeteCien = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $200 que contiene la billetera");
    billeteDoscientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $500 que contiene la billetera");
    billeteQuinientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $1000 que contiene la billetera");
    billeteMil = int.Parse(Console.ReadLine()); 
    billetera1 = new Billetera(billeteDiez,billeteVeite,billeteCincuenta,
                    billeteCien,billeteDoscientos,billeteQuinientos,billeteMil);
    
    Console.WriteLine("Por favor ingrese el número de billetes de $10 que contiene la billetera");
    billeteDiez = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $20 que contiene la billetera");
    billeteVeite = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $50 que contiene la billetera");
    billeteCincuenta = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $100 que contiene la billetera");
    billeteCien = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $200 que contiene la billetera");
    billeteDoscientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $500 que contiene la billetera");
    billeteQuinientos = int.Parse(Console.ReadLine()); 
    Console.WriteLine("Por favor ingrese el número de billetes de $1000 que contiene la billetera");
    billeteMil = int.Parse(Console.ReadLine()); 
    billetera2 = new Billetera(billeteDiez,billeteVeite,billeteCincuenta,
                    billeteCien,billeteDoscientos,billeteQuinientos,billeteMil);

    
    billetera3 = billetera1.combinar(billetera2);
    Console.WriteLine($"La billetera de tiene $ {billetera3.total().ToString()}"); 
    billetera1.vaciarBilletera();
    billetera2.vaciarBilletera();   
    }

} while (respuesta != 3);

