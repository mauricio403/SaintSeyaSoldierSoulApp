using System;
using Ninject;
using Negocio;
using Personajes;
using Interfaces;
using Ataques;
namespace SaintSeyaSoldierSoul
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcion = 0;

            var kernel = new StandardKernel();

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
                        Caballeros Mu = new Caballeros("Mu de Aries", "Revolucion Estelar");
                        kernel.Bind<ITecnica>().To<Tecnicas>();
                        var ataquePrimerJugador = kernel.Get<Game>();

                        ataquePrimerJugador.HacerLaTecnica(Mu);
                        break;
                    case 2:
                        Console.WriteLine("Haz elejido al caballero Shura de Capricornio");
                        Caballeros Shura = new Caballeros("Shura de Capricornio", "Espada Sagrada Exclaibur");
                        kernel.Bind<ITecnica>().To<Tecnicas>();
                        var ataqueSegundoJugador = kernel.Get<Game>();

                        ataqueSegundoJugador.HacerLaTecnica(Shura);
                        break;
                    case 3:
                        Console.WriteLine("Haz elejido al caballero Saga de Géminis");
                        Caballeros Saga = new Caballeros("Saga de Géminis", "Explosion de Galaxias");
                        kernel.Bind<ITecnica>().To<Tecnicas>();
                        var ataqueTercerJugador = kernel.Get<Game>();

                        ataqueTercerJugador.HacerLaTecnica(Saga);
                        break;
                    case 4:
                        Console.WriteLine("Haz elejido al caballero Mascara de muerte de Cancer");
                        Caballeros DeadthMask = new Caballeros("Mascara de muerte de Cancer", "Ondas Infernales");
                        kernel.Bind<ITecnica>().To<Tecnicas>();
                        var ataqueCuartoJugador = kernel.Get<Game>();

                        ataqueCuartoJugador.HacerLaTecnica(DeadthMask);
                        break;
                    case 5:
                        Console.WriteLine("Haz elejido al caballero Camus de Acuario");
                        Caballeros Camus = new Caballeros("Camus de Acuario", "Ejecución de Aurora");
                        kernel.Bind<ITecnica>().To<Tecnicas>();
                        var ataqueQuintoJugador = kernel.Get<Game>();

                        ataqueQuintoJugador.HacerLaTecnica(Camus);
                        break;
                }
            }
           
        }
    }
}
