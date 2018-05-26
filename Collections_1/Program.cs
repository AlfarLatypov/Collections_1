using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /* 1. Создать коллекцию List <int> . Вывести на экран позицию и значение элемента, 
            являющегося вторым максимальным значением в коллекции. Вывести на экран сумму элементов на четных позициях. */
            /* 2 - 8.	Удалить все нечетные элементы списка List<int> */

            List<int> dc = new List<int>();
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                dc.Add(rand.Next(1, 20));
            }
            dc = dc.OrderBy(d => d).ToList();
            Console.WriteLine(dc[dc.Count - 1]);

            int summ = 0;
            for (int i = 0; i < dc.Count; i += 2)
            {
                Console.WriteLine("Elements\t" + dc[i]);
                summ += dc[i];
                dc.Remove(i);
            }
            Console.WriteLine("Summ\t" + summ);
            #endregion

            #region
            // 3 - 9.Дана коллекция типа List<double>.Вывести на экран элементы списка, значение которых больше среднего арифметического всех элементов коллекции.

            //double avgTask3 = 0;
            //List<int> gq = new List<int>();
            //Random rand = new Random();

            //for (int i = 0; i < gq.Count; i += 2)
            //{
            //    gq.Add(rand.Next(1, 100));
            //}
            //avgTask3 = gq.Sum(d => d) / gq.Count;
            //Console.WriteLine("Sum\t" + avgTask3);
            //foreach (var item in gq)
            //    if (item > avgTask3)
            //        Console.WriteLine("Value more than avg\t" + item);

            //foreach (var item in gq.Where(o => o > avgTask3))
            //        Console.WriteLine("Value more than avg\t" + item);
            #endregion

            #region
            ///* 4. Напечатать содержимое текстового файла t, выписывая литеры каждой его строки в обратном порядке. */

            //string str = "sdfsdfsdf";
            //List<char> xx = str.ToList();
            //xx.Reverse();
            //foreach (var item in xx)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            #endregion

            #region

            // 5. Даны 2 строки s1 и s2. Из каждой можно читать по одному символу. Выяснить, является ли строка s2 обратной s1.

            //string s1 = "top";
            //string s2 = "pot";
            //string s3 = "";
            //foreach (char item in s1.Reverse())
            //    s3 += item;

            //if (s3 == s2)
            //    Console.WriteLine("Vectory");

            #endregion

            #region

            ///*6. Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все слова, 
            //     начинающиеся на гласную букву, потом все слова, начинающиеся на согласную букву, сохраняя исходный порядок в каждой группе слов.*/

            //string text = "Be or not to be is a question";
            //List<string> Alen = new List<string>();
            //Alen = text.Split(' ').ToList();
            //string bookva = "aoieu";
            //foreach (var item in Alen)
            //{
            //    if (bookva.Contains(item[0]))
            //        Console.Write(item);
            //}
            //Console.WriteLine();

            //foreach (var item in Alen)
            //{
            //    if (!bookva.Contains(item[0]))
            //        Console.Write(item);
            //}
            //Console.WriteLine();

            #endregion

            #region

            /* 
             7.	Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: сначала все положительные числа,
                    потом все отрицательные числа, сохраняя исходный порядок в каждой группе чисел.
            */

            //string numbt = @"C:\Temp\numbers.txt";
            //Queue<int> numberst = new Queue<int>();

            //Random random = new Random();
            //for (int i = 0; i < 15; i++)
            //{
            //    numberst.Enqueue(random.Next(-20, 20));
            //}

            //using (StreamWriter sw = new StreamWriter(numbt))
            //{
            //    foreach (var i in numberst)
            //    {
            //        sw.WriteLine(i);
            //    }
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Дан файл, содержащий числа.");
            //Console.ForegroundColor = ConsoleColor.White;

            //using (StreamReader sr = new StreamReader(numbt))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.Write(line + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //List<int> numPol = new List<int>();
            //List<int> numOtr = new List<int>();
            //using (StreamReader sr = new StreamReader(numbt))
            //{
            //    string line;

            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] lin2 = line.Split(' ');
            //        int[] linNum = new int[lin2.Length];
            //        for (int i = 0; i < lin2.Length; i++)
            //        {
            //            linNum[i] = Int32.Parse(lin2[i]);
            //            numPol.Add(linNum[i]);
            //            if (linNum[i] < 0)
            //            {
            //                numOtr.Add(linNum[i]);
            //                numPol.Remove(linNum[i]);
            //            }
            //        }
            //    }
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("все положительные числа");
            //    Console.ForegroundColor = ConsoleColor.White;


            //    foreach (var i in numPol)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();

            //    Console.WriteLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("все отрицательные числа");
            //    Console.ForegroundColor = ConsoleColor.White;

            //    foreach (var i in numOtr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}