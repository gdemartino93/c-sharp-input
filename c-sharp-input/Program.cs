using System;

try
{
    Console.WriteLine("Inserisci il primo numero");
    // convertiamo automaticamente i dati inseriti in console in int
    int primoNumero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserisci il secondo numero");
    int secondoNumero = Convert.ToInt32(Console.ReadLine());
    int risultato = primoNumero + secondoNumero;
    Console.WriteLine($"I numeri inseriti sono {primoNumero} e {secondoNumero}. La somma dei due numeri è {risultato}");
}
catch (FormatException)
{
     Console.WriteLine("Il numero non è nel formato corretto");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);

}
finally
{
    Console.WriteLine("Non so se il calcolo è riuscito o meno! Io ci sono lo stesso");
}
