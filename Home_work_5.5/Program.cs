using System;

namespace Home_work_5._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 36: Задайте одномерный массив, заполненный случайными числами.
            // Найдите сумму элементов, стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
            // [-4, -6, 89, 6]-> 0

            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            FillArray(array);
            Console.WriteLine($"Сумма чисел в нечетных индексах массива: [{String.Join(", ", array)}] равна: {FuncSumOddNumbers(array)}");

            void FillArray(int[] arrayInFunction)
            {
                for (int i = 0; i < arrayInFunction.Length; i++)
                    arrayInFunction[i] = new Random().Next(1, 100);
            }

            int FuncSumOddNumbers(int[] arrayInFunction)
            {
                int sumOddNumbers = 0;
                for (int i = 0; i < arrayInFunction.Length; i++)
                {
                    if (i % 2 == 1)
                        sumOddNumbers += arrayInFunction[i];
                }
                return (sumOddNumbers);
            }
        }
    }
}