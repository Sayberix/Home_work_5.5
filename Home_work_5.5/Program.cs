using System;

namespace Home_work_5._5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
            // [3 7 22 2 78] -> 76

            Console.Write("Введите размерность массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];
            FillArray(array);
            Console.WriteLine($"Разница между максимальным и минимальным элементом в массиве: [{String.Join(", ", array)}] равна: {DiffMinMax(array)}");

            void FillArray(double[] arrayInFunction)
            {
                for (int i = 0; i < arrayInFunction.Length; i++)
                    arrayInFunction[i] = Math.Round(new Random().NextDouble() * 200 - 100, 2); // генератор ыещественных чисел от -100 до 100 с заданной точностью до двух знаков после запятой
            }

            double DiffMinMax(double[] arrayInFunction)
            {
                double min = arrayInFunction[0], max = arrayInFunction[0];
                for (int i = 0; i < arrayInFunction.Length; i++)
                {
                    if (arrayInFunction[i] < min)
                        min = arrayInFunction[i];
                    if (arrayInFunction[i] > max)
                        max = arrayInFunction[i];
                }
                return (max-min);
            }
        }
    }
}