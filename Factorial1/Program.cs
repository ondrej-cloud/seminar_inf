using System;
 
class Program
{
    static void Main()
    {
        Console.Write("Zadejte celé nezáporné číslo: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (n < 0)
            {
                Console.WriteLine("Faktoriál záporného čísla není definován.");
            }
            else
            {
                int vysledek = VypocitejFaktorial(n);
                Console.WriteLine($"{n}! = {vysledek}");
            }
        }
        else
        {
            Console.WriteLine("Zadaná hodnota není platné celé číslo.");
        }
    }
 
    static int VypocitejFaktorial(int n)
    {

        if (n <= 1)
        {
            return 1;
        }
        return n * VypocitejFaktorial(n - 1);
    }
}