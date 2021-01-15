using System;
using Ninject;
using Negocio;
using Personajes;
using Interfaces;
using Ataques;
using NinjectFramework;
namespace SaintSeyaSoldierSoul
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = 0;
            var fr = new NinjectFr();
            fr.Load();

            var kernel = new StandardKernel(fr);

            
            var ataqueJugador = kernel.Get<Game>();


            while (opcion != 5)
            {
                Console.WriteLine("Ejercicio de Inyeccion de dependencias con Ninjectic");


                Console.WriteLine("Elije un personaje");

                Console.WriteLine("1) Mu de Aries");
                Console.WriteLine("2) Shura de Capricornio");
                Console.WriteLine("3) Saga de Géminis");
                Console.WriteLine("4) Máscara de muerte de Cáncer");
                Console.WriteLine("5) Camus de Acuario");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Haz elejido al caballero Mu de Aries");

                        Caballero mu = new Caballero("Mu de Aries", "Revolucion Estelar");
                        

                        ataqueJugador.HacerLaTecnica(mu);
                        break;


                    case 2:
                        Console.WriteLine("Haz elejido al caballero Shura de Capricornio");
                        Caballero shura = new Caballero("Shura de Capricornio", "Espada Sagrada Excalibur");

                        

                        ataqueJugador.HacerLaTecnica(shura);
                        break;


                    case 3:
                        Console.WriteLine("Haz elejido al caballero Saga de Géminis");
                        Caballero saga = new Caballero("Saga de Géminis", "Explosion de Galaxias");

                        

                        ataqueJugador.HacerLaTecnica(saga);
                        break;


                    case 4:
                        Console.WriteLine("Haz elejido al caballero Mascara de muerte de Cancer");
                        Caballero deadthMask = new Caballero("Mascara de muerte de Cancer", "Ondas Infernales");

                        

                        ataqueJugador.HacerLaTecnica(deadthMask);
                        break;


                    case 5:
                        Console.WriteLine("Haz elejido al caballero Camus de Acuario");
                        Caballero camus = new Caballero("Camus de Acuario", "Ejecución de Aurora");
                        

                        

                        ataqueJugador.HacerLaTecnica(camus);
                        break;
                }
            }

        }
    }
}
