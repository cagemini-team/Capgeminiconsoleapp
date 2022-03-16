using System;

namespace Practicebasic
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //string str = "techie";
            //int pos = 0;
            //char replacement = 'T';

            //str = str.Remove(pos, 1).Insert(pos, replacement.ToString());
            //Console.WriteLine(str);

            //string str = Console.ReadLine();
            //int pos =Convert.ToInt32(Console.ReadLine());
            //str = str.Remove(0,pos);
            //Console.WriteLine(str);

            //object[] product = new object[] { 1, "lcd", 4.25, 2, "led", 6.25 };

            //for (int i = 0; i < product.Length; i++)
            //{
            //    Console.WriteLine(product[i]);
            //}
            //Console.WriteLine("---------");

            //foreach (int i in product)
            //{
            //    Console.WriteLine(i);
            //}


            //int[,] array1 = new int[2, 2];
            //int[,] array2 = new int[2, 2];
            //int[,] array3 = new int[2, 2];

            //Console.WriteLine($"enter array elements");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("----------");
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        array2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("----------");

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        array3[i, j] = array1[i, j] + array2[i, j];
            //        Console.WriteLine($"array:{array3[i, j]}");
            //    }
            //}

            //Console.WriteLine($"Sum of arrays: {array1[]}");

            //int[][] jarray = new int[4][];

            //jarray[0] = new int[] {10,20,30,40};
            //jarray[1] = new int[] { 10, 20, 30, 40 ,50, 60, 70};
            //jarray[2] = new int[] { 100,200,300,150,200};
            //jarray[3] = new int[] { 1505,1260,456,1505 };
            //for (int i = 0; i < jarray.Length; i++)
            //{
            //    for(int j = 0; j < jarray[i].Length; j++)
            //    {
            //        Console.WriteLine(jarray[i][j]+"\t");
            //    }
            //    Console.WriteLine("\n");

            //object[][] course = new object[3][];
            //course[0] = new object[] {1,2,3,4};
            //course[1] = new object[] {"c#",".net","java","PHP"};
            //course[2] = new object[] { "15days", "20days", "15days", "20days" };

            // for (int i = 0; i < course.Length; i++)
            //{
            //    for(int j = 0; j < course[i].Length; j++)
            //    {
            //        Console.WriteLine(course[i][j]+"\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            //int a;
            //Console.WriteLine("input a number");
            //int c = int.Parse(Console.ReadLine());

            //int result;
            //Console.WriteLine("input a number");
            //bool b  = int.TryParse(Console.ReadLine(), out result);
            //Console.WriteLine(b+","+result);


            //char ch;
            //Console.WriteLine("input a char");

            //ch = char.Parse(Console.ReadLine());

            //if(ch>='0' && ch <='9')
            //{
            //    Console.WriteLine("the input is number");
            //    Console.WriteLine("the input is ={0}",ch);
            //}
            //else if(ch>='a' && ch<='z')
            //{
            //    Console.WriteLine("input is alphabet");
            //}
            //else
            //{
            //    Console.WriteLine("it is Special charcter");
            //}

            //bool var1 = true;
            //int res;
            //res = Convert.ToInt32(var1);
            //Console.WriteLine(res);

            //string str1 = "suraj";
            //string str2 = "hello my name is suraj";
            //Console.WriteLine(str1.Length);
            //Console.WriteLine(str1.IndexOf('s'));
            //Console.WriteLine(str1.LastIndexOf('j'));

            //Console.WriteLine("-----------");

            //Console.WriteLine(str2.Length);
            //Console.WriteLine(str2.IndexOf('s'));
            //Console.WriteLine(str2.LastIndexOf('j'));

            //Console.WriteLine("-----------");

            //Console.WriteLine(str1.StartsWith('s'));
            //Console.WriteLine(str1.EndsWith('s'));
            //Console.WriteLine(str1.Contains('u'));
            //Console.WriteLine(str1.Equals(str2));

            //Console.WriteLine("-----------");

            //Console.WriteLine(String.Compare(str1,str2));

            //string str2 = "suraj";
            //string str1 = "hello my name is ";
            //Console.WriteLine(string.Concat(str1,str2));
            //string str3 = string.Concat(str1,str2);
            //Console.WriteLine(str3);
            //string str4 = string.Copy(str1);
            //Console.WriteLine(str4);
            //string str5 = (string)str2.Clone();
            //Console.WriteLine(str5);

            //int[] arr1 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr2 = new int[5] { 1, 2, 3, 4, 7 };
            //int[] arr3 = new int[10];
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i] = arr1[i] + arr2[i];
            //    Console.WriteLine(arr3[i]);

            //}

            int[,] arr = new int[4,4];

            Console.WriteLine("enter the array elements");

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"inserted matrix: { arr[i, j]+"\t"}");
                }

            }

            int[,] arr1 = new int[3, 3];

            Console.WriteLine("enter the array elements");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"inserted matrix: { arr1[i, j] +"\t"}");
                }

            }

            
           
            Console.WriteLine($"these are the two matrix");

            int [,] arr2 = new int[6, 6];

            Console.WriteLine($"sum of arrays: ");

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    arr2[i, j] = arr1[i,j]+arr2[i,j];
                    Console.WriteLine($"sum: {arr2[i,j]} ");
                }

            }

        }

    }

}
