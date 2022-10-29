using claseBaraja;

   Console.Clear();
        int respuesta = 0;
        Baraja mazo = new Baraja();


        do
        {
            Console.WriteLine("1 - Barajar");
            Console.WriteLine("2 - Mostrar siguiente carta");
            Console.WriteLine("3 - Mostrar cartas disponibles");
            Console.WriteLine("4 - Dar cartas");
            Console.WriteLine("5 - Mostrar cartas del monton");
            Console.WriteLine("6 - Mostrar baraja");
            Console.WriteLine("7 - Salir");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    mazo.barajar();
                    break;
                case 2:
                    mazo.siguienteCarta();
                    break;
                case 3:
                    barajar();
                    break;
                case 4:
                    barajar();
                    break;
                case 5:
                    barajar();
                    break;
                case 6:
                    barajar();
                    break;

            }

        } while (respuesta != 7);
    
