// See https://aka.ms/new-console-template for more information

class Factorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("I'm from straight forwad method: " + FactorialNormal(num));
        Console.WriteLine("I'm from Recursive method: " + RecursiveFact(num));
    }
    public static int FactorialNormal(int num)
    {
        int fact = 1;
        for (int i = 2; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }

    public static int RecursiveFact(int num)
    {
        if (num == 1) {
            return 1;
        }
        return num*RecursiveFact(num-1);
    }
}