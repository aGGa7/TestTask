using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compressor  - содержит решение на задание про сжатие строки
            //CompressorTest - функциональные тесты на базе Nunit для класса Compressor (необходим NUnit и NUnit3TestAdapter)
            //Search -обобщенный класс с реализацией бинарного поиска для нахождение элемента в массиве
            //SearchTest -  функциональные тесты на базе Nunit для класса Search (необходим NUnit и NUnit3TestAdapter)

            int[] intTest = new[] { 1, 2, 3, 4, 5 };
            string[] strTest = new[] { "a", "b", "c", "d" };
            Program.TestStr(strTest.ToList(), "c");
            Program.TestStr(strTest.ToList(), "a");
            Program.TestStr(strTest.ToList(), "d");
            Program.TestStr(strTest.ToList(), "f");
            Program.TestInt(intTest.ToList(), 1);
            Program.TestInt(intTest.ToList(), 5);
            Program.TestInt(intTest.ToList(), 0);
        }

        public static void TestStr (List<string> list, object element)
        {
            var type = list.GetType().GetGenericArguments()[0];
            Console.Write("массив: ");
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + ", ");
            Console.WriteLine("элемент "+element+" находится по индексу: " + Search<string>.BinarySearch(list, (string)element)) ;
        }

        public static void TestInt(List<int> list, object element)
        {
            var type = list.GetType().GetGenericArguments()[0];
            Console.Write("массив: ");
            for (int i = 0; i < list.Count; i++)
                Console.Write(list[i] + ", ");
            Console.WriteLine("элемент " + element + " находится по индексу: " + Search<int>.BinarySearch(list, (int)element));
        }
    }
}
