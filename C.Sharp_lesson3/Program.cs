using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C.Sharp_lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter first number->");
            //string firstNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("Enter second number->");
            //string secondNumber = Console.ReadLine();

            //firstNumber.Reverse();
            //secondNumber.Reverse();

            //int result1 = 0;
            //int result2 = 0;

            //int buffer = 0;

            //foreach(var item in firstNumber)
            //{
            //    //Convert.ToInt32(item);
            //    buffer = Convert.ToInt32(item.ToString());
            //    result1 += buffer;
            //}

            //foreach(var item in secondNumber)
            //{
            //    buffer = Convert.ToInt32(item.ToString());
            //    result2 += buffer;
            //}

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);


            Exmpl06();
            Console.ReadLine();

        }

        static void Exmpl01()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            string[] letterArr = new string[textArr.Length];

            int k = 0;

            foreach (var item in textArr)
            {
                string fLetters = item[0].ToString();
                letterArr[k++] = fLetters;
            }

            foreach (var item in letterArr)
            {
                int l = 0;
                Console.WriteLine("Letter " + item + ": ");
                for (int i = 0; i < letterArr.Length; i++)
                {
                    if (letterArr[i] == item)
                    {
                        l++;
                    }
                }
                Console.WriteLine(l);
            }
        }

        static void Exmpl02()
        {
            string text = Console.ReadLine();

            string[] textArr = text.Split(' ');

            foreach (var item in textArr)
            {
                int num = 0;
                if (Int32.TryParse(item, out num))
                {
                    Console.WriteLine("Hmm, number");
                }
            }
        }

        static void Exmpl03()
        {
            string text = Console.ReadLine();

            string[] wordArray = text.Split(' ');

            //foreach(var item in wordArray)
            //{
            //    if (item.Equals("one"))
            //    {
            //        Console.WriteLine("Yes, contains");
            //        break;
            //    }
            //}

            //if (text.Contains("one"))
            //{
            //    Console.WriteLine("Yes, contains");
            //}

        }

        static void Exmpl04()
        {
            //string text = Console.ReadLine();

            //string[] wordArray = text.Split(' ');

            string word = "drragging";

            for (int i = 0; i < (word.Length - 1); i++)
            {
                if (word[i] == word[i + 1])
                {
                    string letter = word[i].ToString();
                    word = word.Replace(letter, "1");
                }
            }

            Console.WriteLine(word);
        }

        static void Exmpl05()
        {
            int[,] array = new int[5, 5];
            Random randNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = randNum.Next(-100, 100);
                }
            }

            int sumMin;

            int fIndexMin_i = 0;
            int fIndexMin_j = 0;

            int lIndexMin_i = 0;
            int lIndexMin_j = 0;

            int minNum = array[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < minNum)
                    { 
                        minNum = array[i, j];
                        fIndexMin_i = i;
                        fIndexMin_j = j;
                    }
                }
            }

            minNum = array[0, 0];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if((array[i, j] < minNum) && (i != fIndexMin_i && j != fIndexMin_j))
                    {
                        minNum = array[i, j];
                        fIndexMin_i = i;
                        fIndexMin_j = j;
                    }
                }
            }


        }

        static void Exmpl06()
        {
            string text = Console.ReadLine();
            string[] wordArray = text.Split(' ');
            Console.WriteLine(wordArray.Length);
            for (int i = 0; i < wordArray.Length; i++)
            {
                string item = wordArray[i];
                Console.WriteLine(item);
            }
        }

        StringBuilder obj = new StringBuilder("Hello World"); // в отличии от String не заполняет память копиями(могут удаляться сборщиками мусора)
    }
}
