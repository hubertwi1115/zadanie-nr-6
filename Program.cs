using System;

class Program
{
    static void Main()
    {
        int rozmiar;

        rozmiar = sizeof(float);
        Console.WriteLine($"Rozmiar typu float: {rozmiar} bajtów");

        rozmiar = sizeof(char);
        Console.WriteLine($"Rozmiar typu char: {rozmiar} bajtów");

        rozmiar = sizeof(double);
        Console.WriteLine($"Rozmiar typu double: {rozmiar} bajtów");

        rozmiar = sizeof(int);
        Console.WriteLine($"Rozmiar typu int: {rozmiar} bajtów");
    }
}
