using System;

namespace AplicacionAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            int _ruedas=4;
    
            Muestra();
            Pausa();
        }
        public static void Muestra()
        {
            Console.WriteLine("Hola el auto tiene");
        }

        public static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar ...");
            Console.ReadKey();
        }
    }
}
