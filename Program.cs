//**Задача * *: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//**Примеры**:

//["hello", "2", "world", ":-)"] -> ["2", ":-)"]

//["1234", "1567", "-2", "computer science"] -> ["-2"]

//["Russia", "Denmark", "Kazan"] -> []

using System;

namespace Home_Work_GB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный массив");
            Console.WriteLine("hello 2 world :-)");

            string[] array = { "hello", "2", "world", ":-)" };

            Console.WriteLine("Выборка");
            for (int i = 0; i <= array.Length - 1; i++)
            {

                string arrStart = array[i];

                if (arrStart.Length <= 3)
                {

                    string[] result = (string[])array.Clone();
                    Console.Write(result[i] + " ");

                }
            }
            Console.WriteLine("");
            Console.WriteLine("Конец программы");

        }
    }
}
