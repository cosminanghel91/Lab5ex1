/*
* Scrieti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura
*/


using System.Numerics;

Console.WriteLine("Scrieti sirul de caractere");
string sirCaractere = Console.ReadLine().ToLower();


Console.WriteLine(CountVocals(sirCaractere));

int CountVocals(string x)
{
    int total = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == 'a' || x[i] == 'ă' || x[i] == 'â' || x[i] == 'î' || x[i] == 'e' | x[i] == 'i' || x[i] == 'o' | x[i] == 'u')
        {
            total++;
        }
    }
    return total;
}