using System;

namespace c_sharp_input // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero");
            // convertiamo automaticamente i dati inseriti in console in int
            int primoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il secondo numero");
            int secondoNumero = Convert.ToInt32(Console.ReadLine());

            int risultato = primoNumero + secondoNumero;

            Console.WriteLine($"I numeri inseriti sono {primoNumero} e {secondoNumero}. La somma dei due numeri è {risultato}");
        }
    }
}