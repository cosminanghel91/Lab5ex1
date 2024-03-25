/*
* Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom
*/



using Microsoft.Win32.SafeHandles;

Console.WriteLine("Scrieti sirul de caractere");
string sirCaractere = Console.ReadLine();


Panlindrom(sirCaractere);
Checking(Panlindrom(sirCaractere));


bool Panlindrom(string x)
{

    string reversed = new string(sirCaractere.Reverse().ToArray());
    var check = sirCaractere.ToLower() == reversed.ToLower();
    return check;
}

void Checking(bool x)
{
    if (x == true)
    {
        Console.WriteLine("Sirul de caractere este palindrom");
    }
    else
    {
        Console.WriteLine("Sirul de caractere nu este palindrom");
    }
}