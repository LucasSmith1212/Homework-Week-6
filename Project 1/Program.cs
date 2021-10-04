/// Week 6 Project 1
/// File Name: week6project1.cs
/// Author: Lucas Smith
/// Date:  October 4, 2021
///
/// Problem Statement: Write code to create a copy of an array.
/// 
/// 
/// Overall Plan:
/// 1) Ask for the amount of integers that will be in the array.
/// 2) Have the user enter each integer into the array.
/// 3) Declare the array's copy.
/// 4) Enter each element of the first array into the copy.
/// 5) Print out both arrays to show they are the same.
///
using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers do you want in your array?");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            int i;
            for (i = 0; i < x; i++) {
                Console.WriteLine("Enter element " + (i + 1) + " in the array.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arrayCopy = new int[x];

            for (i = 0; i < x; i++)
            {
                arrayCopy[i] = array[i];
            }
            
            for (i = 0; i < x; i++)
            {
                Console.Write(array[i] + ". ");
            }
            Console.WriteLine();
            Console.WriteLine();
            for (i = 0; i < x; i++)
            {
                Console.Write(arrayCopy[i] + ". ");
            }
        }
    }
}
