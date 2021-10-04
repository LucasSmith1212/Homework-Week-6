/// Week 6 Project 2
/// File Name: week6project2.cs
/// Author: Lucas Smith
/// Date:  October 4, 2021
///
/// Problem Statement: Let's make a program that uses methods to accomplish a task. Let's take an array and reverse the contents of it.
/// 
/// 
/// Overall Plan:
/// 1) Ask for the amount of integers to be in the array.
/// 2) Declare the three methods.
/// 3) Generate the random numbers for the array.
/// 4) Print it out, then reverse the array.
/// 5) Print the reversed array to the screen.
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers do you want in your array?");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] numbers = GenerateNumbers(x);
            PrintNumber(numbers);
            Reverse(numbers);
            PrintNumber(numbers);
        }

        static int[] GenerateNumbers(int j)
        {
            Random rand = new Random();
            int[] array = new int[j];
            for (int i = 0; i < j; i++)
            {
                array[i] = rand.Next(100);
            }
            return array;
            
        }

        static void PrintNumber(int []arr)
        {
           for (int n = 0; n < arr.Length; n++)
            {
                Console.Write(arr[n] + ". ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static int[] Reverse(int[] arr)
        {
            int replace;
            for (int l = 0; l < (arr.Length / 2); l++)
            {
                replace = arr[l];
                arr[l] = arr[arr.Length - l - 1];
                arr[arr.Length - l - 1] = replace;
            }

            return arr;
        }
    }
}
