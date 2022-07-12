using System;

namespace Home_work_5._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            // Напишите программу, которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2

            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            Console.WriteLine($"Количество четных чисел в массиве: [{String.Join(", ", array)}] -> {FindEvenNumber(array)}");

            int FindEvenNumber(int[] arrayInFunction)
            {
                int evenNumbers = 0;
                for (int i = 0; i < arrayInFunction.Length; i++)
                {
                    if (arrayInFunction[i] % 2 == 0)
                        evenNumbers += 1;
                }
                return (evenNumbers);
            }
            void FillArray(int[] arrayInFunction)
            {
                for (int i = 0; i < arrayInFunction.Length; i++)
                    arrayInFunction[i] = new Random().Next(1, 1000);
            }
        }
    }
}