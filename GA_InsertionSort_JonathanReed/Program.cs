using System;

namespace GA_InsertionSort_JonathanReed
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int size = 17; 
            int minValue = 1; 
            int maxValue = 107; 

            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);
            Console.WriteLine("Unsorted Array:");
            DisplayArray(randomArray);
            InsertionSortArray(randomArray);
            Console.WriteLine("Sorted Array:");
            DisplayArray(randomArray);

        }
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }
        public static void InsertionSortArray(int[] arr) /*Starting from the second element (as the first element is considered sorted), compare the current element with its predecessor.*/
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int currentValue = arr[i]; /* If the current element is smaller than its predecessor, compare it to the elements before it. Move each element one position up to make space for the new element.*/
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than currentValue,
                // to one position ahead of their current position
                while (j >= 0 && arr[j] > currentValue)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = currentValue; /*Insert the current element at its correct position in the sorted part of the array.*/
            }
        }
        static void DisplayArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}