namespace Tesk3
{
    // Программа от -N до N
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write($"{number} -> ");
            for (int i = number * (-1); i <= number; i++)
            {
                if (i == number) Console.WriteLine(i+";");
                else Console.Write($"{i}, ");
            }
            Console.ReadLine();
        }
    }
}
