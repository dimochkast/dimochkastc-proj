using System;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("input1");
        string str1 = Console.ReadLine();
        Console.WriteLine("input2");
        string str2 = Console.ReadLine();

        int x = Convert.ToInt32(str1);
        int y = Convert.ToInt32(str2);
        int sum = x + y;
        int avg = sum / 2;

        Console.WriteLine($"summa ravna = {sum}");
        Console.WriteLine($"Averaga ravna = {avg}");



     
    
    
    
    }
}

