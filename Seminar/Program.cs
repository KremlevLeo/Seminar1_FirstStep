namespace Task_1
{
    /*Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
        a = 25, b = 5 -> да
        a = 2, b = 10 -> нет
        a = 9, b = -3 -> да
        a = -3 b = 9 -> нет*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a 1 number: ");
            double numberSquere = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2 number: ");
            double numberForAnalise = double.Parse(Console.ReadLine());
            if (numberSquere/numberForAnalise == numberForAnalise) Console.WriteLine($"a = {numberSquere}, b = {numberForAnalise} -> Yes");
            else Console.WriteLine($"a = {numberSquere}, b = {numberForAnalise} -> No");
            Console.ReadLine();
        }
    }
}
