using System;

namespace Parcial1
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Se Informara la distancia recorrida por un movil ingresando el tiempo y la velocidad");
                Console.WriteLine("Ingrese la velocidad(metros/segundos) : ");
                var vel = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tiempo (seg): ");
                var tiempo = double.Parse(Console.ReadLine());
                var distancia = vel * tiempo;
                Console.WriteLine($"La distancia recorrida es: {distancia} metros");
                var distanciakms = distancia * 0.001;
                Console.WriteLine($"La distancia recorrida es: {distanciakms} kilometros");

                Console.ReadLine();
            }
            catch (Exception)
            {
                //Esta la exepcion por si no se ingresan numeros, o algo que no corresponda.
                Console.WriteLine("Alguno de los datos ingresados no es correcto");
                Console.ReadLine();
            }

        }
    }
}
