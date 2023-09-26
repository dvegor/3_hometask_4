// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Degree(int numA, int numB)
// {
//     int res = 1;
// for (int i = 0; i < numB; i++)
// {
//     res = res * numA;
// }
// Console.WriteLine ($"{res}");
// }

// Console.WriteLine("Plesae input the first number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Plesae input the second number:");
// // int num2 = Convert.ToInt32(Console.ReadLine());
// // Degree(num1,num2);

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int SummDigit(int num)
// {
//     int res = 0;
//     while (num > 1)
//     {
//         int ost = num%10;
//         num = num/10;
//         res = res + ost;
//     }
//     return res;
// }

// Console.WriteLine("Plesae input the number:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if(num1<0)
// num1 = num1 * -1;
// int summ = SummDigit(num1);
// Console.WriteLine($"Summ of numbers {num1} is equal {summ} ");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array()
{
    int j = new Random().Next(0,10);
    int [] array = new int[j];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}
void ShowArray(int [] array)
{
    Console.Write("[");
      for (int i = 0; i < array.Length; i++)
      Console.Write(array[i]+" ");
    {
        Console.Write("]");
    }
}
ShowArray(Array());