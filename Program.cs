// int[] arr = { 1, 2, 3, 4, 5 };
// int i = 0;
// while (i < arr.Length)
// {
//     arr[i] *= i * 2;
//     Console.Write(arr[i++] + " ");
// }


//Переворот чисел в массиве:

// int[] arr = { 10, 12, 16, 22, 26, 43, 345 };
// int[] tmp = ReverseArray(arr);
// CopyArray(tmp, arr);
// PrintArray(arr);

// int[] ReverseArray(int[] array)
// {
//     int[] result = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//         result[array.Length - 1 - i] = array[i];
//     return result;
// }

// void CopyArray(int[] sourse, int[] dest)
// {
//     if (sourse.Length != dest.Length)
//         return;
//     for (int i = 0; i < sourse.Length; i++)
//         dest[i] = sourse[i];
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("{");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             Console.Write(", ");
//     }
//     Console.WriteLine("}");
// }

// int[] arr = { 10, 12, 16, 22, 26, 43, 345 };
// ReverseArrayInPlace(arr);
// void ReverseArrayInPlace(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int tmp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = tmp;
//     }
// }
// Console.Write("{");
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write(arr[i]);
//     if (i < arr.Length - 1)
//         Console.Write(", ");
// }
// Console.WriteLine("}");

// Console.Write("Введите длину стороны АB:");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны BC:");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите длину стороны AC:");
// int C = Convert.ToInt32(Console.ReadLine());

// if ((A < B + C) && (B < A + C) && (C < B + A))
//     Console.WriteLine($"Треугольник со сторонами А, В, С существует");
// else
//     Console.WriteLine($"Треугольник со сторонами А, В, С НЕ существует");


//Программа, которая преобразовывает десятичное число в двоичное.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for (int step = number; step > 0; step /= 2)
// {
//     count++;
// }
// int[] arr = new int[count];
// for (int i = 0, step = number; step > 0; step /= 2)
// {
//     arr[i] = step % 2;
//     i++;
// }
// for (int i = count - 1; i >= 0; i--)
// {
//     Console.Write(arr[i]);
// }
// Console.WriteLine();