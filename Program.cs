internal class Program
{
    private static void Main(string[] args)
    {
        void FillArray(int[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minValue, maxValue);
            }
        }      
        void FillArrayDouble(double[] array, int minValue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
                array[i] = Math.Round(array[i], 2);
            }
        }      
        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
        void PrintArrayDouble(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  ");
            }
            Console.WriteLine();
        }
        int SumPositive(int[] numbers)
        {
            int sumPositive = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) sumPositive += numbers[i];
            }
            return sumPositive;
        }
        int SumNegative(int[] numbers)
        {
            int sumNegative = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0) sumNegative += numbers[i];
            }
            return sumNegative;
        }
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        } 


        
        void Task34()
        // Задача 34: Задайте массив заполненный случайными положительными
        // трёхзначными числами. Напишите программу, которая покажет
        // количество чётных чисел в массиве.
        {
            int size = 6;
            int[] numbers = new int[size];

            FillArray(numbers);
            PrintArray(numbers);

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) count++;
            }   
            Console.WriteLine("Количество четных чисел равно " + count);
            
        }
        // Console.Clear();
        // Task34();

        void Task37()
        // Задача 37: Задайте одномерный массив, заполненный случайными
        //числами. Найдите сумму элементов, стоящих на нечётных позициях.
        {
            int size = 6;
            int[] numbers = new int[size];

            FillArray(numbers, 0, 7);
            PrintArray(numbers);

            int sum = 0;
            int count = 0;
            for (int i = 1; i < numbers.Length; i +=2)
            {
                sum += numbers[i];
            }   
            Console.WriteLine("Сумма равна " + sum);
            
        }
        //Console.Clear();
        //Task37();


        void Task38()
        // Задача 38: Задайте массив вещественных чисел. Найдите разницу
        //между максимальным и минимальным элементов массива.
        {
            int size = 6;
            double[] numbers = new double[size];

            FillArrayDouble(numbers, -100, 100);
            PrintArrayDouble(numbers);

            double max = numbers[0];
            double min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
                else if (numbers[i] > min) min = numbers[i];
            }   
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("Разница значений равна:  " +
                                $"{max - min}");
        }
        //Console.Clear();
        //Task38();
    }
}