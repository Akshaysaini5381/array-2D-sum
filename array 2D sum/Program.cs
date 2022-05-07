using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_2D_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the base aaray size :");
            int Row = int.Parse(Console.ReadLine());

            Console.Write("Enter the child aaray size :");
            int Col = int.Parse(Console.ReadLine());

            int[,] arr = new int[Row,Col];
            int ctr;
            int ptr;
            ctr = 0;
            while (ctr<Row)
            {
                ptr = 0;
                while (ptr<Col)
                {
                    Console.Write("Enter the value {0} :",(ctr+1));
                    arr[ctr, ptr] = int.Parse(Console.ReadLine());
                    ptr++;
                }
                Console.WriteLine();
                ctr++;
            }
            Console.Write("my array :");
            Console.WriteLine();
            int sum = 0;
            int ctr1 = 0;
            while (ctr1 < Row)
            {
                 int ptr1 = 0;
                while (ptr1 < Col)
                {
                    Console.Write(" " + arr[ctr1, ptr1]);
                    sum = sum + arr[ctr1, ptr1];

                    ptr1++;
                }
                Console.WriteLine();
                ctr1++;
            }

            Console.WriteLine();
                int min = arr[0, 0];
                int max = arr[0, 0];
                for (int i = 0; i < Row; i++)
                {
                    for (int j = 0; j < Col; j++)
                    {
                        if (min > arr[i, j])
                        {
                            min = arr[i, j];
                        }
                        if (max < arr[i, j])
                        {
                            max = arr[i, j];
                        }
                    }
                  

                }
                Console.WriteLine("sum :" + sum);
            Console.WriteLine("Maximum number:" + max);
            Console.WriteLine("Minimum  number:" + min);

            Console.ReadLine();
            }
          
        
    }
}
