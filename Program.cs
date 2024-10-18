using System;
using System.Collections.Generic;
// Random.Next(); генирирует числа в диапаЗОНЕ 
// int [] - это кортеж 
//  List<int> A = new List<int> {} А это новый инициализированый список 
namespace работа_с_масивом__18._10_
{
    internal class Program
    {
        static void Main()
        {

            int[] A = [];
            Console.WriteLine("Task1");
            int ACap = A.Length;
            Random x = new Random();
            while (ACap == 23)
            {
                int i = 0;
                A[i] = x;
                
            }
            
           
                
            Console.WriteLine("Урок 1-й: не пишите смайлика в коде");
            // киря-чан начало 
            Console.WriteLine("Задание 2");
            Random random = new Random();
            int[] B = new int[12];
            for (int i = 0; i < 12; i++)
            {
               B[i] = random.Next(-15, 15); // генерация случайного числа(вроде, обычно тут ошибка)
            }
            int sum = 0;
            int count = 0;
            for (int i = 0; i < 12; i++)
            {
                if (B[i] >= -5 && B[i] <= 6)
                {
                    sum += B[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Среднее арифметическое в массиве B: " + average);
            }
            else
            {
                Console.WriteLine("В массиве B нет нужных чисел");
            }
            // здесь
            Console.WriteLine("Задание 3");
            int[] C = new int[32];
            int[] randomarray = new int[32];
            Random randomC = new Random();
            for (int arr = 0; arr < 32; arr++)
            {
                C[arr] = randomC.Next(0, 99);
            }
        }
    }
}