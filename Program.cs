
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

                Console.Write($"{arr1[i, j] }");

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

        case 4:
            //заполнение массива
            List<int> str = new List<int>();
            List<int> col = new List<int>();

            y = rand.Next(3, 4);
            x = rand.Next(3, 6);

            int[,] arr2 = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    arr2[i, j] = rand.Next(-20, 20);

                }
            }
            //вывод заполненного массива
            Console.WriteLine("Массив:");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {

                    Console.Write($"{arr2[i, j]} ");

                }
                Console.WriteLine("");
            }
            int max_str = arr2[0,0];
            int max_col = arr2[0,0];
            //задание
            //максимальные элементы в строках
            for (int i = 0;i < x;i++)
            {
                max_str = arr2[i,0];
                for (int j = 0; j < y; j++)
                {
                    if(arr2[i,j] > max_str)
                    {
                        max_str = arr2[i,j];
                    }
                }
                str.Add(max_str);
            }
            //максимальные элементы в столбцах
            for (int i = 0;i < y;i++)
            {
                max_col = arr2[0,i];
                for (int j = 0; j < x; j++)
                {
                    if(arr2[j,i] > max_col)
                    {
                        max_col = arr2[j,i];
                    }
                }
                 col.Add(max_col);

            }
            // Вывод результата
            Console.Write("Маклчимальные в строках:");
            foreach (int item in str)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            Console.Write("Максимальные в столбцах: ");

            foreach (int item in col)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            break;

}
