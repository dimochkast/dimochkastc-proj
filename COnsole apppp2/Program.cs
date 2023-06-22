

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("marks1");
        int marks1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("marks2");
        int marks2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("marks3");
        int marks3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("marks4");
        int marks4 = Convert.ToInt32(Console.ReadLine());

        int summarks = marks1 + marks2 + marks3 + marks4;
        float sumpersent = (float)summarks / 335 * 100;

        string grade = "";
        switch (sumpersent)
        {
            case float n when n >= 80:
                grade = "A";
                break;
            case float n when n >= 70:
                grade = "B";
                break;
            case float n when n >= 60:
                grade = "C";
                break;
            case float n when n >= 50:
                grade = "D";
                break;
            case float n when n >= 40:
                grade = "E";
                break;
            case float n when n < 40:
                grade = "U";
                break;
         }

        Console.WriteLine($"Ваш балл {summarks}, ваш процкнт {sumpersent}. Ваша оцкнка {grade} ");
    }
}