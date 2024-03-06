namespace WorkItems
{
    public static class Exercises
    {
        /// <summary>
        /// SORTING ALGORITHM 
        /// Write a sorting algorithm to sort a List of string in ascending order
        /// without using any built-in functions.
        /// Please focus on stability, cost efficiency and low memory consumption.
        /// </summary>
        public static List<string> ExerciseOne(List<string> UnsortedList)
        {
            return UnsortedList;
        }

        /// <summary>
        /// PALIMDROM CHECK 
        /// Write a function that checks whether a given string is a palindrome (reads the same forwards and backwards).
        /// This function should not be case sensitive.
        /// </summary>
        public static bool ExerciseTwo(string word)
        {
            return false;
        }

        /// <summary>
        /// FIZZBUZZ
        /// Write a program that return the given number, 
        /// but for multiples of three, return "Fizz" instead of the number, 
        /// and for the multiples of five, return "Buzz". For numbers that 
        /// are multiples of both three and five, return "FizzBuzz"
        /// </summary>
        public static string ExerciseThree(int number)
        {
            return number.ToString();
        }

        /// <summary>
        /// ANAGRAM CHECK
        /// Write a function to check if two strings are anagrams of each other 
        /// (contain the same characters in a different order)
        /// This function should not be case sensitive.
        /// </summary>
        public static bool ExerciseFour(string wordone, string wordtwo)
        {
            return wordone == wordtwo;
        }

        /// <summary>
        /// FIND MAXIMUM
        /// Write a function that finds the maximum number in a list of integers 
        /// without using any built-in functions or sorting algorithms.
        /// </summary>
        public static int ExerciseFive(List<int> numbers)
        {
            return numbers.First();
        }
    }
}
