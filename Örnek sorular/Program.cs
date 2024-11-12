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

            //int[] numbers = {14, -53, 19, -83, 20, -24, -53, 37, -13,};
            //a)
            //bool status = numbers.Length >= 36;
            //Console.WriteLine(status);
            //bool st = Array.Exists(numbers,x=> x ==36);
            //Console.WriteLine(st);
            //b)
            //int[] positive= Array.FindAll(numbers, x => x > 0);
            //foreach(int i in positive)
            //{
            //    Console.Write(i+" ");
            //}
            //c)
            //Console.WriteLine(Array.FindLast(numbers, x=> x<0));
            //d)
            //Console.WriteLine(Array.IndexOf(numbers, -83));
            //e)
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] <0)
            //    {
            //        numbers[i] = -1 * numbers[i];
            //    }

            //}
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //f)
            //Console.WriteLine(Array.FindLastIndex(numbers, x=> x %3==0));
            //g)
            //int[] yenilerinyensi = new int[3];
            //for (int i = 0; i < yenilerinyensi.Length; i++)
            //{
            //    yenilerinyensi[i] = numbers[i + 2];
            //}
            //foreach (int a in yenilerinyensi)
            //{
            //    Console.Write(a+" ");
            //}
            //h)
            //int[] bakbutarzbenim = new int[4];
            //for (int i = 0; i < bakbutarzbenim.Length; i++)
            //{
            //    bakbutarzbenim[i] = numbers[i+1];
            //}
            //foreach (int z in bakbutarzbenim)
            //{
            //    Console.Write(z+" ");
            //}
            //i)
            //int[] klon = (int[])numbers.Clone();
            //klon[0] = 1091;
            //Console.WriteLine($"first of klon: {klon[0]}, first of numbers: {numbers[0]}");
            //j)
            //int[] esaynıderrey = numbers;
            //esaynıderrey[0] = 1261;
            //Console.WriteLine($"first of assigned: {esaynıderrey[0]}, first of numbers: {numbers[0]}");
            //k)
            //double[] numbers2 = new double[numbers.Length];
            //for (int i=0; i<numbers.Length; i++)
            //{
            //    numbers2[i] = Math.Sqrt(numbers[i]);
            //} 
            //foreach (double i in numbers2)
            //{
            //    Console.WriteLine(i);
            //}
            //l)
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] == -53)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int kaunt = numbers.Count(n => n == -53);
            //Console.WriteLine(kaunt);
            //m)
            //Console.WriteLine(Array.FindLastIndex(numbers,x=>x ==-53));
            //n)
            //int[] diff= new int[numbers.Length];  
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    diff[i] = 100 - numbers[i];
            //}

            //Console.WriteLine(numbers[Array.IndexOf(diff,diff.Min())]);
            //o)
            //int[] fillarray = new int[5];
            //Array.Fill(fillarray, 24);
            //foreach(int i in fillarray)
            //{
            //    Console.WriteLine(i);
            //}
            //8)
            //int[,] twodimensinoal =
            //{
            //    { 3,15 },
            //    { 7,19 }
            //};

            //for (int i = 0; i < twodimensinoal.GetLength(0); i++)
            //{
            //    for (int j = 0; j< twodimensinoal.GetLength(1); j++)
            //    {
            //        Console.Write(twodimensinoal[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matris =
            //{
            //    {9, 17, -4 },
            //    {6, -8, 23 },
            //    {-16,-35,58}
            //};
            //9a)
            //int[] diagonal = new int[3];
            //for(int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matris.GetLength(1); j++)
            //    {

            //        if (i == j)
            //        {
            //            diagonal[i] = matris[i, j];
            //        }
            //    }
            //}
            //foreach(int i in diagonal)
            //{
            //    Console.WriteLine(i);
            //}
            //b)
            //int[] sums = new int[3];
            //int a = 0;
            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        if(a<3) 
            //        sums[a] += matris[i,j];
            //    }
            //    a++;
            //}

            //Console.WriteLine($"first row sum: {sums[0]}, second row sum: {sums[1]}, third row sum: {sums[2]}");
            //c)
            //int[] sums = new int[3];
            //int a = 0;
            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        if (a < 3)
            //        sums[a] += matris[j, i];
            //    }
            //    a++;
            //}

            //Console.WriteLine($"first column sum: {sums[0]}, second column sum: {sums[1]}, column row sum: {sums[2]}");
            //d)
            //int[][] jaggedArray = new int[3][];



            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    List<int> tempList = new List<int>();
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        if (matris[i, j] < 0)
            //        {
            //            tempList.Add(matris[i, j]);

            //        }

            //    }
            //    jaggedArray[i] = tempList.ToArray();
            //}
            //for (int b = 0; b < jaggedArray.Length;b++)
            //{

            //    if (jaggedArray[b].Length >= 2)
            //    {
            //        Console.WriteLine($"the row with two negative numbers is {b + 1}");
            //    }


            //}
            //e)

            //int sumAboveDiagonal = 0;
            //int sumBelowDiagonal = 0;

            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        // Diyagonalın üstündeki elemanlar: i < j
            //        if (i < j)
            //        {
            //            sumAboveDiagonal += matris[i, j];
            //        }
            //        // Diyagonalın altındaki elemanlar: i > j
            //        else if (i > j)
            //        {
            //            sumBelowDiagonal += matris[i, j];
            //        }
            //    }
            //}

            //// Sonuçları yazdırma
            //Console.WriteLine("Sum of the numbers above the diagonal: " + sumAboveDiagonal);
            //Console.WriteLine("Sum of the numbers below the diagonal: " + sumBelowDiagonal);
            //Console.WriteLine("Total sum of the numbers above and below the diagonal: " + (sumAboveDiagonal + sumBelowDiagonal));
            //10)
            //int[,] A =
            //{
            //    {7,1,1,1,-5 },
            //    {1,13,1,39,1},
            //    {1,1,48,1,1 },
            //    {1,-8,1,67,1 },
            //    {14,1,1,1,-86 }
            //};
            //int[] pembe = new int[A.GetLength(0)];
            //int[] yesil = new int[A.GetLength(1)];
            //int pembeindex = 0;
            //int yesilindex = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < A.GetLength(1); j++)
            //    {
            //        if(i==j || i+j == 4)
            //        {
            //            yesil[yesilindex]= A[i,j];
            //            yesilindex++;
            //        }
            //    }
            //}

            //for(int i = 2;i <A.GetLength(0); i++)
            //{
            //    for (int j = 0;j < A.GetLength(1); j++)
            //    {
            //        if ( i==j || i+j == 4)
            //        {
            //            pembe[pembeindex] = A[i,j];
            //            pembeindex++;
            //        }
            //    }
            //}

            //Console.WriteLine($"For pink:");
            //foreach(int i in pembe)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"For green:");
            //foreach (int i in yesil)
            //{
            //    Console.Write(i + " ");
            //}
            //11)
            //int[,] A = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(10 + (10 * i) + (5 * j) + " ");
            //    }
            //    Console.WriteLine();
            //}
            //}
            //12)
            //int[,] A = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if(i == 2)
            //        {
            //            A[j,i]=(-2+(j*2));
            //        }
            //        else
            //        {
            //            A[j,i]=(-3 + j + (4 * i));
            //        }

            //    }
            //}

            //for (int i = 0;i < 3; i++)
            //{
            //    for(int j = 0;j < 3; j++)
            //    {
            //        Console.Write(A[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}







        }    
    }
}
