using System;
using ClassLibrary;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1, 2
            int[] numbers = new int[] { 6,3,5,41};
            ArrayWorker Worker = new ArrayWorker();
            Worker.ShowArray("Original array: ",numbers);
            Console.WriteLine();
            int[] inv_nums = Worker.InvertArray(numbers);
            Worker.ShowArray("Inverted array: ", inv_nums);
            Console.WriteLine();
            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            int[] upd_nums = Worker.AddValue(numbers, value, index);
            Worker.ShowArray("Updated array: ",upd_nums);
            Console.WriteLine();

            //Задание 3
            Cone myCone = new Cone(5,20);
            Console.WriteLine($"Square of base = {myCone.BaseSquare()} cm2");
            Console.WriteLine($"All square = {myCone.AllSquare()} cm2");

        }
    }
}
