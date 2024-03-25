/*
* Un program care va normaliza un sir de caractere citit de la tastatura astfel 
* incat fiecare cuvant din sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mari
*/


using System.Globalization;

Console.WriteLine("Scrieti textul pe care doriti sa il transformati");
string change = Console.ReadLine();



Console.WriteLine(ToTitleCase(change));
string ToTitleCase(string subs)
{
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(subs.ToLower());
}