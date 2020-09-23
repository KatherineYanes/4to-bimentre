using System;
using System.Collections.Generic;
using System.Text;

namespace Tercera_prueba
{
    class Op
    {
        public Operaciones Opera = new Operaciones();

        public double n = 0;



        public string Resultado(char t)

        {

            double Tot = 0;



            char op = 's';





            while (op != 'n')

            {

                if (t == 's')

                {

                    Tot = Opera.Suma(Tot, PedirVal());

                }

                else if (t == 'r')

                {

                    Tot = Opera.Resta(Tot, PedirVal());

                }
                else if (t == 'm')

                {
                    Tot = Opera.Multiplicacion(Tot, PedirVal());
                }
                else if (t == 'd')

                {
                    Tot = Opera.Division(Tot, PedirVal());
                }
                else if (t == 'p')

                {

                    Tot = Opera.Potencia(Tot, PedirVal());
                }
                else if (t == 'q')
                {
                    Tot = Opera.Raiz(Tot, PedirVal());
                }


                bool a = false;
                Console.WriteLine("¿Quiere entrar otro valor?");
                Console.WriteLine("[Si]                 [No]");

                while (a == false)
                {
                    try
                    {

                        op = char.Parse(Console.ReadLine());
                        a = true;
                    }
                    catch
                    {
                        Console.WriteLine("Ingrese valores alfabeticos");
                        op = char.Parse(Console.ReadLine());

                    }


                }

            }



            return ("El resultado de la operacion es: " + Tot);

        }



        private double PedirVal()
        {
            double Val = 0;
            bool Est = false;



            while (Est == false)

            {

                Console.Write("ingrese un Numero: ");

                try

                {

                    Val = double.Parse(Console.ReadLine());

                    Est = true;

                }

                catch

                {
                    Console.WriteLine("Caracter o operacion invalida, por favor intente de nuevo");
                }

            }
            return Val;


        }
    }
}
