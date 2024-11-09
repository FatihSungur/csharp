using System;
using System.Collections.Generic;


namespace Örnek_sorular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1)
            //Console.WriteLine("Enter the size: ");
            //int size = Convert.ToInt32(Console.ReadLine());
            //string[] arraymiss = new string[size];
            //int sıra = 1;
            //for (int i = 0; i < size; i++)

            //{
            //    Console.WriteLine($"{sıra}. Öğeyi Giriniz:");
            //    arraymiss[i] = Console.ReadLine();
            //    sıra++;
            //}

            //Array.Reverse(arraymiss);
            //foreach (string s in arraymiss)
            //{
            //    Console.Write(s+",");
            //}
            //2)
            //int[] elementarray = { 13, -42, 77, 93, 45, 19, 83 };

            //for (int i = 0; i < elementarray.Length; i++)
            //{
            //    if (elementarray[i] % 3 == 0)
            //    {
            //        elementarray[i] = (int)Math.Pow(elementarray[i],2);
            //    }
            //    else
            //    {
            //        elementarray[i] = (int)(Math.Pow(elementarray[i],3));
            //    }
            //}
            //foreach (int i in elementarray)
            //{
            //    Console.WriteLine(i);
            //}
            //3)
            //int[] numbers = { 29, 33, 12, 48, -3, 9, 16 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach (int i in numbers)
            //{
            //    Console.Write(i+" ");
            //}
            //4)
            //double[] numbers = {12.47, 236.3, -12, 4, 9.8, 3.14, -25.63, 11.7 };
            //double maks = numbers[0];
            //double min = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < min)
            //    {
            //        min= numbers[i];
            //    }
            //    else if (numbers[i] > maks) 
            //    {
            //        maks= numbers[i];
            //    }

            //}

            //double sum = maks - min;
            //Console.WriteLine(sum);
            //5)
            //int[] twodigitadded= new int[100];
            //int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Copy(digits, twodigitadded, digits.Length);
            //int x = 10;

            //for (int i = x; i < twodigitadded.Length; i++)
            //{
            //    for (int j = 0; j < digits.Length; j++)
            //    {
            //        if(j+x<100)
            //        twodigitadded[j+x] = digits[j]+x;
            //    }

            //    x = x + 10;
            //}

            //foreach (int element in twodigitadded)
            //{
            //    Console.WriteLine(element);
            //}
            //6)
            //string[] array = new string[3];
            //int sıra = 1;
            //int i = 0;
            //do
            //{
            //    Console.WriteLine($"Enter {sıra}. item:");
            //    array[i] = Console.ReadLine();
            //    sıra++;
            //    i++;
            //}
            //while (sıra < 4);

            //string ocuuredtext = "";
            //foreach (string element in array)
            //{
            //    ocuuredtext += element[0];
            //    ocuuredtext += element[element.Length-1];
            //}

            //Console.WriteLine(ocuuredtext);
             
            
        }
    }
}
