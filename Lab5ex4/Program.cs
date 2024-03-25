/*
*Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii 
*dintr-un string citit de la tastatura, ignorand caseing-ul literelor.
*/

using Microsoft.VisualBasic;
using System.Reflection.Metadata;

Console.WriteLine("Scrieti informatia pe care doriti sa o cautati");
string search = Console.ReadLine();



maxOccurrences(search);
void maxOccurrences(string x)
{
    int maxOccurrences = 0;
    string rezultat = "";
    foreach (var st in x)
    {
        var occurrences = x.ToLower().Count(x => x == st);
        if (occurrences > maxOccurrences)
        {
            maxOccurrences = occurrences;
            char ch = st;
            rezultat = $"Caracterul {ch} apare de {maxOccurrences} ori";
        }
    }
    Console.WriteLine(rezultat);
}
