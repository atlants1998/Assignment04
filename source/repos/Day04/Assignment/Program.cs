namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Assignment!");
            /*
             2- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
- If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
- If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
- If the worker takes more than 5 hours, they are required to leave the company. 
To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */

            //Console.Write("Enter the time taken by the worker to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("The worker needs to increase their speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken < 5)
            //{
            //    Console.WriteLine("The worker needs training to improve their speed.");
            //}
            //else if (timeTaken >= 5)
            //{
            //    Console.WriteLine("The worker should leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid time between 2 and more hours.");
            //}

            /************** Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.*********************/

            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine(); // Move to the next row
            //}


            /***************** 20- Write a program in C# Sharp to find the sum of all elements of the array. ******************/
            //int Sum=0;
            //int[] X = { 1, 2, 3 };
            //for (int i = 0; i < X.Length; i++) { 
            //    Console.WriteLine(X[i]);

            //    Console.WriteLine($"{Sum} + {(X[i])} = {Sum + X[i]} ");
            //    Sum = Sum + X[i];

            //}

            /********* Write a program in C# Sharp to find the second largest element in an array. *****/
            //Console.WriteLine("Enter the size of the array:");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //// Accepting values for the array
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //// Finding the second largest element
            //int largest = int.MinValue;
            //int secondLargest = int.MinValue;

            //foreach (int num in array)
            //{
            //    if (num > largest)
            //    {
            //        secondLargest = largest;
            //        largest = num;
            //    }
            //    else if (num > secondLargest && num != largest)
            //    {
            //        secondLargest = num;
            //    }
            //}

            //if (secondLargest == int.MinValue)
            //{
            //    Console.WriteLine("No second largest element exists.");
            //}
            //else
            //{
            //    Console.WriteLine($"The second largest element is: {secondLargest}");
            //}

            /*28- Write a Program to Print One Dimensional Array in Reverse Order*/

            //Console.WriteLine("Enter the size of the array:");
            //int size = int.Parse(Console.ReadLine());

            //int[] array = new int[size];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element [{i}]: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nThe array in reverse order is:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}

            /*Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like 
        Enter a number: 25 */

            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int result = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of {number} is: {result}");

            /*Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:*/
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //if (IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a prime number.");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a prime number.");
            //}

            /*Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters*/
            int[] numbers = { 5, 2, 9, 3, 7, 1, 8 };

            int min = 0;
            int max = 0;

            MinMaxArray(numbers, ref min, ref max);

            Console.WriteLine($"The minimum value is: {min}");
            Console.WriteLine($"The maximum value is: {max}");

        }

        // Function to calculate the sum of digits
        static int SumOfDigits(int number)
        {
            int sum = 0;

            // Loop through each digit of the number
            while (number > 0)
            {
                sum += number % 10;  // Add the last digit to the sum
                number /= 10;         // Remove the last digit
            }

            return sum;
        }

        // Function to check if a number is prime
        static bool IsPrime(int number)
        {
            // A number less than or equal to 1 is not prime
            if (number <= 1)
            {
                return false;
            }

            // Check divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)  // If divisible by any number in this range, it's not prime
                {
                    return false;
                }
            }

            // If no divisors were found, the number is prime
            return true;
        }

        // Function to find the minimum and maximum values in an array using reference parameters
        static void MinMaxArray(int[] array, ref int minValue, ref int maxValue)
        {
            // Check if the array is empty
            if (array.Length == 0)
            {
                Console.WriteLine("Array is empty!");
                return;
            }

            // Initialize min and max values with the first element of the array
            minValue = array[0];
            maxValue = array[0];

            // Loop through the array to find the min and max
            foreach (int value in array)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }
        }
    }
}


