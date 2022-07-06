using System;
using System.Collections.Generic;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            Limites _limites = new Limites();
            Console.WriteLine("En que numero debería iniciar");
            do
            {
                _limites.I = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine( validaMayorACero(_limites.I) ? "Solo mayores a 0": "" ) ;

            } while (validaMayorACero(_limites.I));

            Console.WriteLine("Numero de primos a buscar");
            var primos = CalculaPrimo(_limites);
            Console.WriteLine("Estos son sus numeros primos");
            foreach (var numero in primos)
            {
                Console.WriteLine(numero.Numero + " ");
            }
            Console.ReadLine();

            List<Primos> CalculaPrimo(Limites limites)
            {
                List<Primos> Lista = new();
                
                while (Lista.Count != limites.N)
                {
                    
                    limites.I ++;
                    int cantidadNumeros = 0;
                    Primos Primos = new();
                    Primos.Numero = limites.I;
                    Primos.CantidadDivisibles = 0;
                    while (limites.I != cantidadNumeros)
                    {
                        cantidadNumeros++;
                        if (limites.I % cantidadNumeros == 0)
                        {
                            Primos.CantidadDivisibles++;
                        }
                    }

                    if (Primos.CantidadDivisibles == 2)
                    {
                        Lista.Add(Primos);
                    }
                }
                return Lista;
            }

            bool validaMayorACero(int numero)
            {
                return numero > 0;
            }
        }
        public class Limites
        {
            public int I { get; set; }
            public int N { get; set; }
            public List<Primos> Primos { get; set; }
        }
        public class Primos
        {
            public int Numero { set; get; }
            public int CantidadDivisibles { set; get; }
        }
       
    }
}
