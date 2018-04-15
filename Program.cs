using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Data_Types_and_Algorythms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Reversing Linked list by iterating only once

            /*
             Linked lists in c# are double linked and do not allow certain functions i.e first / last are read only so I can't iterate and use a temp variable
             to swap them over, the same way I would do in an ArrayList
             
             */


            //Task 2 - check sum before and after and see if they are equal

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(2);
            linkedList.AddFirst(2);
            linkedList.AddFirst(1);
            linkedList.AddFirst(7);
            linkedList.AddFirst(3);
            linkedList.AddFirst(2);

            int sumTotal = 0;
            int sumRight = 0;
            int sumLeft = 0;
            foreach (var item in linkedList)
            {
                sumTotal += item;
            }

            for (int i = 0; i < linkedList.Count; i++)
            {
                if (i>0)
                {
                    sumLeft += linkedList.ElementAt(i - 1);
                    sumRight = sumTotal - linkedList.ElementAt(i) - sumLeft;
                    if (sumLeft == sumRight)
                    {
                        Console.WriteLine($"{linkedList.ElementAt(i)} is a solution to the task and it is on position {i}");
                        Console.WriteLine("-------------------------------------------");
                        break;
                    }
                }
            }


            //Task 4 - Find common elements between two arrays.
           


            int[] arr1 = { 4, 7, 3, 9, 2 };
            int[] arr2 = { 3, 2, 12, 9, 40, 32, 4 };

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == arr1[i])
                    {
                        Console.WriteLine(arr2[j]);
                    }
                }
            }


            Console.WriteLine("-------------------------------------");

            //Task 5 - Write a program to remove common elements within array

            int[] input1 = { 2, 3, 6, 6, 8, 9, 10, 10, 10, 12, 12 };
            List<int> output1 = new List<int>();

            var distinct = input1.Distinct();

            foreach (var item in distinct)
            {
                output1.Add(item);
            }

            foreach (var item in output1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------");
            //Task 3 - Write a program to reverse a string using recursive methods.

            string s = "Hello world";
            s = RecursivelyReverseString(s);
            Console.WriteLine(s);

            Console.WriteLine("------------------------------");


        }
        public static string RecursivelyReverseString(string s)
        {
            if (s.Length > 0)
                return s[s.Length - 1] + RecursivelyReverseString(s.Substring(0, s.Length - 1));
            else
                return s;
        }



       



        

       





    }

}
