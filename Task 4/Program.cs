namespace Task_4
{
    // Последняя цифра техзначного
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three-digit number: ");
            int number= int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} -> {number%10}");
            Console.ReadLine();
        }
    }
}
