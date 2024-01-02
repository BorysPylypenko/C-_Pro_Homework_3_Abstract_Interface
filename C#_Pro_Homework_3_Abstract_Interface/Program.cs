using C__Pro_Homework_3_Abstract_Interface;
using C__Pro_Homework_3_Abstract_Interface.Task_1;
using System.Reflection;

public class Program
{
    public static int[] CreateArray(int arrayLength, int numbers)
    {
        Random random = new Random();
        int[] array = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++ )
        {
            array[i] = random.Next(numbers);
        }

        return array;
    }
    public static void Main()
    {
        Console.Write("Enter array length: ");
        int arrayLength = int.Parse(Console.ReadLine());
        Console.Write("Enter max value of number: ");
        int numbers = int.Parse(Console.ReadLine());

        string info = $"Array consists of {arrayLength} elements";

        int[] array = CreateArray(arrayLength, numbers);

        MyArray myArray = new MyArray(array);

        myArray.Show();

        myArray.Show(info);

        Console.WriteLine($"Max value: {myArray.Max()}");
        Console.WriteLine($"Min value: {myArray.Min()}");
        Console.WriteLine($"Avarage value: {myArray.Avg()}");

        Console.Write("Enter number for search: ");
        int searchNumber = int.Parse(Console.ReadLine());

        Console.WriteLine($"Founded search number: {myArray.Search(searchNumber)}");

        
        Console.WriteLine("\nSort ascending:");
        myArray.SortAsc();
        myArray.Show();

        Console.WriteLine("\nSort descending");
        myArray.SortDesc();
        myArray.Show();

        Console.WriteLine("\nSorted based on parameter (ascending):");
        myArray.SortByParam(true);
        myArray.Show();

        Console.WriteLine("\nSorted based on parameter (descending):");
        myArray.SortByParam(false);
        myArray.Show();
    }
}