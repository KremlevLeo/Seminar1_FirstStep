namespace Task_2
{
    /*
     * Напишите программу которая принимает число и выдет названичя дня недели
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number of the day of the week: ");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine($"{number} -> Monday");
            }
            if (number == 2)
            {
                Console.WriteLine($"{number} -> Tuesday");
            }
            if (number == 3)
            {
                Console.WriteLine($"{number} -> Wednesday");
            }
            if (number == 4)
            {
                Console.WriteLine($"{number} -> Thursday");
            }
            if (number == 5)
            {
                Console.WriteLine($"{number} -> Friday");
            }
            if (number == 6)
            {
                Console.WriteLine($"{number} -> Saturday");
            }
            if (number == 7)
            {
                Console.WriteLine($"{number} -> Sunday");
            }
            else Console.WriteLine($"{number} -> There is no such day");
            Console.ReadLine();
        }
    }
}