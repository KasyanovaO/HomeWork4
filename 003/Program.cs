// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[8] { 6, 1, 33, 5, 14, 7, 8, 45 };
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i] + "");
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.Write("]");
    }
}
