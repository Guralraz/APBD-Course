// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

static double ObliczSrednia(int[] liczby)
{
    if (liczby.Length == 0)
        return 0;

    double suma = 0;
    foreach (int liczba in liczby)
    {
        suma += liczba;
    }
    return suma / liczby.Length;
}
