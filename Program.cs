
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

int[] arr = new int[10];
int n, x, y, max, max_X = 0, max_Y = 0;
Random rand = new Random();

Console.Write("Введите номер задания: ");
n = Convert.ToInt32(Console.ReadLine());

switch (n)
{
    case 1:

        for (int i = 0; i < 10; i++)
        {
            arr[i] = rand.Next(-10, 10);
        }

        Console.Write("До изменений: ");

        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine("");

        for (int i = 0; i < arr.Length; i++)
        {

            if (arr[i] < 0)
            {
                arr[i] *= arr[i];
            }

        }

        Console.Write("После изменений: ");

        foreach (int i in arr)
        {
            Console.Write($"{i} ");
        }

        break;
    case 2:

        int num = 0;

        for (int i = 0; i < 10; i++)
        {
            arr[i] = rand.Next(1, 15);
        }

        Console.Write("Массив: ");

        foreach (int i in arr)
        {
            Console.Write($"{i} ");
            if (i > 0 & i % 2 == 0)
            {
                num++;
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"количество четных положительных :{num}");

        break;

    case 3:


        y = rand.Next(2, 4);
        x = rand.Next(2, 6);

        int[,] arr1 = new int[x, y];

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {

                arr1[i, j] = rand.Next(-20, 20);

            }
        }
        max = arr1[0, 0];

        Console.WriteLine("Массив:");

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {

                Console.Write($"{arr1[i, j]}");

            }
            Console.WriteLine("");
        }

        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < x; j++)
            {
                if (Math.Abs(arr1[i, j]) > max)
                {

                    max = Math.Abs(arr1[i, j]);
                    max_X = j;
                    max_Y = i;

                }
            }
        }

        Console.WriteLine($"Максимальный элемент по модулю: {max}");
        Console.WriteLine($"Позиция по X:{max_X + 1}");
        Console.WriteLine($"Позиция по Y:{max_Y + 1}");

        break;

}
