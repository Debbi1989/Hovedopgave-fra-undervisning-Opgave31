using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave31
{
    internal class Opgave31
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast et tal: ");  
            // Programmet udskriver "indtast et tal: " hvor brugeren bedes om at indtaste et tal.

            int num = Convert.ToInt32(Console.ReadLine());
            // Selve Console.ReadLine() læser input som streng/string.
            // Convert.ToInt32() konverterer streng/string til int/heltal hvori variablen num befinder sig.


            for (int i = 1; i <= 10; i++)
            // for er en løkke. I dette tilfælde der kører løkken fra i = 1 til i <= 10.
            // Dette skal bruges til gangetabelen hvor den kan ganges fra 1 til 10.
            // Her er der tale om øgning derfor <= 10; i++.
            // Hvis der skulle være tale om en reduktion ville det havde været --.
            // Der øges i med 1 i hver iteration (runde).
            {
                int resultat = i * num;
                // I int resultat beregnes produktet af i og num (Indtastet tal).
                // Heri bliver resultatet i variablen resultat.

                Console.WriteLine($"{i} * {num} = {resultat}");
                // Gangestykket udskrives.
                // {} bruges til at definere/omslutte hvad man vil have ud af stykket. 
                // Heri variablerne {i} * {num] og det skal være = {resultat}.
                // Dette er sat op så udskriften viser gangestykket jf. i (index) og viser = det resultat gangestykket bliver.

            }
            Console.ReadKey();
        }
    }
}
