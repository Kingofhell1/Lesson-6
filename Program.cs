// Console.Write("Введите длину массива: ");
// int input = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[input];
// GetRandomArray(array);
// Revers(array);
// PrintArray(array);


// void GetRandomArray(int[] array)
// {
//     for (int i = 0; i < input; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
                
// }
// void Revers(int[] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
// }

int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("  ");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. ");
    Console.WriteLine("2. Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    programm = Convert.ToInt32(Console.ReadLine());
    switch(programm)
    {
        case 1:
                Console.Write("Введите количество элементов массива: ");
                int m = Convert.ToInt32(Console.ReadLine());
                int[] Array = new int[m];

                void EnterData(int m)
                {
                    for (int i = 0; i < m; i++)
                    {
                        Console.WriteLine($"Введите {i+1} элемент массива ");
                        Array[i] = Convert.ToInt32(Console.ReadLine());
                    }

                }

                int kol(int[] Array)
                {
                    int i=0;
                    int sum = 0;
                    while (i < Array.Length)
                    {
                        if(Array[i]>0)
                        {
                            sum = sum + 1;
                            i = i + 1;
                        }
                    }
                    return sum;
                }

                EnterData(m);
                Console.Write($"\n Чисел больше нуля: {kol(Array)}");
                break;
            case 2:
                Console.WriteLine("введите значение b1");
                double b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите число k1");
                double k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите значение b2");
                double b2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите число k2");
                double k2 = Convert.ToInt32(Console.ReadLine());
                double x = (-b2 + b1)/(-k1 + k2);
                double y = k2 * x + b2;
                Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
            break;
        default:
             begin = false;
             break;
    }
}