using System;
namespace ejercicio_clase
{
    class Program
    {
        static void Main(string[] args)
        {
            String elegir = "";
            while (elegir == "si" || elegir == "si") ;

            int pelicula = 0;
            int[] asientos = { 1, 5, 8, 7, 2, 6, 3, 9, 4, 10 };
            string sex = "";

            Console.WriteLine("Ingrese su nombre");
            Console.WriteLine("Ingrese su sexo");
            Console.WriteLine("m = masculino");
            Console.WriteLine("f = femenino");
            sex = Console.ReadLine();

            if(sex == "m") 
            {
                Console.WriteLine("Eres hombre");
            }
            else
            {
                Console.WriteLine("Eres mujer");
            }

            Console.WriteLine("Elija que genero desear ver");
            Console.WriteLine("1.- Suspenso");
            Console.WriteLine("2.- Accion");
            Console.WriteLine("3.- Drama");
            Console.WriteLine("4.- Romance");

            elegir = Console.ReadLine();

            String seleccion = Convert.ToString(elegir);


            switch (elegir)
            {
                case "1":
                    Console.WriteLine("Tus asientos disponibles son: ");
                    for (int i = 0; i <= asientos.Length; i++)
                    {
                        var seed = Environment.TickCount;
                        var random = new Random(seed);

                        var value = random.Next(0, 10);
                        Console.WriteLine($"Asiento {i} con id {seed} disponible");
                    }
                    break;
                case "2":
                    Console.WriteLine("Tus asientos disponibles son: ");
                    for (int i = 0; i <= asientos.Length; i++)
                    {
                        var seed = Environment.TickCount;
                        var random = new Random(seed);

                        var value = random.Next(0, 10);
                        Console.WriteLine($"Asiento {i} con id {seed} disponible");
                    }
                    break;
                case "3":
                    Console.WriteLine("Tus asientos disponibles son: ");
                    for (int i = 0; i <= asientos.Length; i++)
                    {
                        var seed = Environment.TickCount;
                        var random = new Random(seed);

                        var value = random.Next(0, 10);
                        Console.WriteLine($"Asiento {i} con id {seed} disponible");
                    }
                    break;

                case "4":
                    Console.WriteLine("Tus asientos disponibles son: ");
                    for (int i = 0; i <= asientos.Length; i++)
                    {
                        var seed = Environment.TickCount;
                        var random = new Random(seed);

                        var value = random.Next(0, 10);
                        Console.WriteLine($"Asiento {i} con id {seed} disponible");
                    }
                    break;
            }
        }

    }
}