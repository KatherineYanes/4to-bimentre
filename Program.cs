using System;
using Tercera_prueba;

namespace ConsoleApp6
{

    class Program
    {

        static Menu menu = new Menu();
        static Op Opera = new Op();
        static void Main(string[] args)
        {
            int Opcion = 0;

            while (Opcion != 7)

            {
                Opcion = menu.M();

                if (Opcion == 1)

                {
                    Console.WriteLine(Opera.Resultado('s'));
                }

                else if (Opcion == 2)

                {
                    Console.WriteLine(Opera.Resultado('r'));
                }

                else if (Opcion == 3)

                {
                    Console.WriteLine(Opera.Resultado('m'));
                }

                else if (Opcion == 4)

                {
                    Console.WriteLine(Opera.Resultado('d'));

                }

                else if (Opcion == 5)
                {
                    Console.WriteLine(Opera.Resultado('p'));
                }
                else if (Opcion == 6)
                {
                    Console.WriteLine(Opera.Resultado('q'));
                }
            }





            Console.ReadKey();

        }
    }
}
