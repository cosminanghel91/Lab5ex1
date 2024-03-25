/*
* Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere.
* Atat caracterul cat si sirul de caractere vor fi citite de la tastatura
*/

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Console.WriteLine("Scrieti caracterul pe care doriti sa il cautati");
char character = Console.ReadLine()[0];

Console.WriteLine("Scrieti sirul de caractere");
string sirCaractere = Console.ReadLine();

ShowCharacter2(sirCaractere, character);

int CountCharacter2(string text, char c)
{
    int numberOfLetters = 0;
    for (int i = 0; i < sirCaractere.Length; i++)
    {
        if (text.ToLower()[i] == char.ToLower(character))
        {
            numberOfLetters++;
        }
    }
    return numberOfLetters;
}

void ShowCharacter2(string text, char c)
{
    int numberCaracters = CountCharacter2(sirCaractere, character);
    //Console.WriteLine(numberCaracters);
    Console.WriteLine($"Caracterul '{character}' apare de {numberCaracters} ori in sirul '{sirCaractere}' ");
}