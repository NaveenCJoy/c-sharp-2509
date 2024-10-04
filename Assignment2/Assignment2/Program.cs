using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Multiplication table of a given number
            //Console.WriteLine("Enter a number");
            //double number = Convert.ToDouble(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("0 * any number is 0");
            //}
            //else
            //{
            //    for (int i = 0; i <= 10; i++)
            //    {
            //        Console.WriteLine($"{number} * {i} = {number * i}");
            //    }
            //}


            //2
            //Display a right-angled triangle
            //Console.WriteLine("Enter height of triangle");
            //int height = Convert.ToInt32(Console.ReadLine());

            //for (int i=0; i<height; i++)
            //{
            //    for (int j=0; j<=i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine("");
            //}

            //3
            //Sum of all even numbers between 1 and 100
            //int sum = 0;
            //int i = 1;

            //while (i <= 100)
            //{
            //    if (i % 2 == 1)
            //    {
            //        i += 1;
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i;
            //        i += 1;
            //    }
            //}
            //Console.WriteLine($"Sum of all even numbers between 1 and 100 is {sum}");

            //4
            //Multiplication table from 1 to 5
            //int i = 1;
            //int j = 1;
            //while (i <= 5)
            //{
            //    j = 1;
            //    while (j <= 10)
            //    {
            //        Console.WriteLine($"{i} * {j} = {i * j}");
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine("");
            //}

            //5
            //Print Positive Number            
            //while (true)
            //{
            //    Console.WriteLine("Enter a positive number");
            //    double number = Convert.ToDouble(Console.ReadLine());

            //    if (number >= 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //6
            //Create Menu Driven Calculator
            //do
            //{
            //    Console.WriteLine("Enter 2 numbers. Enter exit to close");
            //    double firstNumber;
            //    string firstInput = Console.ReadLine();
            //    if (firstInput == "exit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        firstNumber = Convert.ToDouble(firstInput);
            //    }
            //    double secondNumber = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Choose operation +, -, *, /");
            //    string operation = Console.ReadLine();

            //    if (operation == "+")
            //    {
            //        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //    }else if(operation == "-"){
            //        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //    }
            //    else if (operation == "*")
            //    {
            //        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //    }
            //    else if (operation == "/")
            //    {
            //        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //    }
            //} while (true);


            //7
            //Print All Numbers From 1 to 100. exclude divisible by 3. stop using break at 50.
            //for(int i=0; i<100; i++)
            //{
            //    if(i%3 == 0)
            //    {
            //        continue;
            //    }else if (i > 50)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //8
            //Sum of Odd Numbers
            //int sum = 0;
            //for (int i=0; i<100; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"Sum of all odd numbers between 1 and 100 is {sum}");

            //9
            //Factorial Calculation
            //int result = 1;
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (number != 0)
            //{
            //    result = result * number;
            //    number -= 1;
            //}
            //Console.WriteLine($"Factorial is {result}");

            //10
            //Number Pyramid using while loop
            //Console.WriteLine("Enter no. of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //int number = 1;
            //while (i < rows)
            //{
            //    while (i < number)
            //    {
            //        Console.Write(number);
            //        i += 1;
            //    }
            //    i = 0;
            //    rows -= 1;
            //    number += 1;
            //    Console.WriteLine("");
            //}

            //11
            //Guess the Number Game
            //while (true)
            //{
            //    int number = new Random().Next(1, 101);
            //    Console.WriteLine(number);
            //    Console.WriteLine("Guess the number");
            //    while (true)
            //    {

            //        int enteredNumber = Convert.ToInt32(Console.ReadLine());

            //        if (enteredNumber == number)
            //        {
            //            Console.WriteLine("Congratulations. You won!!");
            //            break;

            //        }
            //        else if (enteredNumber > number)
            //        {
            //            Console.WriteLine("Wrong answer. Too high. Guess again.");
            //        }
            //        else if (enteredNumber < number)
            //        {
            //            Console.WriteLine("Wrong answer. Too low. Guess again.");
            //        }
            //    }
            //    Console.WriteLine("Do you want to play again? Yes/No");
            //    string decision = Console.ReadLine();
            //    if (decision.ToLower() == "yes")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}

            //12
            ////simple calculator
            //Console.WriteLine("Enter two numbers");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Choose operation +, -, *, /");
            //string operation = Console.ReadLine();
            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            //        break;
            //    case "/":
            //        if(secondNumber != 0)
            //        {
            //            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not possible");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine($"{operation} is an invalid operation");
            //        break;
            //}


            //13
            //Sum of Digits
            //Console.WriteLine("Enter two numbers");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int rem = 0;
            //int sumOfDigits = 0;
            //do
            //{
            //    rem = number % 10;
            //    sumOfDigits += rem;
            //    number = number / 10;
            //} while (number > 0);

            //Console.WriteLine(sumOfDigits);

            //14
            //Finding the Largest Number
            //Console.WriteLine("Enter 10 numbers");
            //int largestNumber = Convert.ToInt32(Console.ReadLine());
            //for(int i=0; i<9; i++)
            //{
            //    int newNumber = Convert.ToInt32(Console.ReadLine());
            //    if (newNumber > largestNumber)
            //    {
            //        largestNumber = newNumber;
            //    }
            //    else
            //    {
            //        continue;
            //    }                
            //}
            //Console.WriteLine($"{largestNumber} is the largest number");


            //15
            //Sum of squares
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //int n = 1;
            //int sumOfSquares = 0;
            //while (n <= number)
            //{
            //    sumOfSquares += n * n;
            //    n += 1;
            //}
            //Console.WriteLine(sumOfSquares);

            //16
            //countdown timer
            int count = 10;
            do
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(count);
                count--;
            } while (count > 0);



            Console.ReadLine();

        }
    }
}
