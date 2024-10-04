using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Enter name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello "+name);
            //Console.ReadLine();



            //2
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter your age");
            //string age = Console.ReadLine();            
            //Console.WriteLine($"Hello {name} You are {age} years old");
            //Console.WriteLine("Enter your favourite color");
            //string color = Console.ReadLine();
            //Console.WriteLine($"Hello {name} You are {age} years old. Your favourite color is {color}");
            //Console.ReadLine();

            //3
            //Console.WriteLine("Enter two numbers");
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //double a = Convert.ToDouble(num1);
            //double b = Convert.ToDouble(num2);
            //double sum = a + b;
            //double difference = a - b;
            //double product = a * b;
            //double division;
            //Console.WriteLine("Sum of the numbers: " + sum);
            //Console.WriteLine("Difference of the numbers: " + difference);
            //Console.WriteLine("Product of the numbers: " + product);
            //if (b == 0)
            //{
            //    Console.WriteLine("Cannot Divide by zero");
            //}
            //else
            //{
            //    division = a / b;
            //    Console.WriteLine("Division of the numbers: " + division);
            //}
            //Console.ReadLine();

            //4 Temperature conversion
            //Console.WriteLine("Enter temperature in Celsius");
            //decimal c = Convert.ToDecimal(Console.ReadLine());
            //decimal x = Convert.ToDecimal(9) / Convert.ToDecimal(5);
            //decimal f = (c * (x) + 32);
            //Console.WriteLine($"{c} celsius in fahrenheit is {f}");
            //Console.ReadLine();

            //5 Simple interest
            //Console.WriteLine("Enter principal amount");
            //decimal p = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter rate of interest");
            //decimal r = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter time in years");
            //decimal t = Convert.ToDecimal(Console.ReadLine());
            //decimal interest = (p * r * t) / 100;
            //Console.WriteLine($"Interest is {interest}");
            //Console.ReadLine();

            //6 Area of circle
            //Console.WriteLine("Enter radius of circle");
            //double r = Convert.ToDouble(Console.ReadLine());
            //double area = 3.14159 * r * r;
            //Console.WriteLine($"Area is {area}");
            //Console.ReadLine();

            //7 time calculation
            //Console.WriteLine("Enter time in seconds");
            //decimal s = Convert.ToDecimal(Console.ReadLine());
            //int hour = (int)(s / (60 * 60));
            //Console.WriteLine(Convert.ToInt32(hour) + " hours");
            //decimal a = s/(60 * 60) - hour;
            //decimal minutes = a * 60;
            //Console.WriteLine(Convert.ToInt32(minutes) + " minutes");
            //decimal b = minutes - (int)minutes;
            //decimal seconds = b * 60;
            //Console.WriteLine(Convert.ToInt32(seconds) + " seconds");
            //Console.ReadLine();

            //8 string length
            //Console.WriteLine("Enter string");
            //string s = Console.ReadLine();
            //s = s.Replace(" ", "");            
            //int length = s.Length;
            //Console.WriteLine($"length of string is {length}");
            //Console.ReadLine();

            //9 bmi
            //Console.WriteLine("Enter height");
            //double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter weight");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //double bmi = weight / (height * height);
            //Console.WriteLine($"Body mass index is: {bmi}");
            //Console.ReadLine();

            //10 variables and constants
            //int a = 5;
            //float b = 4.01f;
            //double c = 4.2648;
            //char d = 'd';
            //string e = "Hello";
            //bool f = true;
            //Console.WriteLine($"{a}  {Convert.ToString(a.GetType())}");
            //Console.WriteLine($"{b}  {Convert.ToString(b.GetType())}");
            //Console.WriteLine($"{c}  {Convert.ToString(c.GetType())}");
            //Console.WriteLine($"{d}  {Convert.ToString(d.GetType())}");
            //Console.WriteLine($"{e}  {Convert.ToString(e.GetType())}");
            //Console.WriteLine($"{f}  {Convert.ToString(f.GetType())}");
            //Console.ReadLine();

            //11 area
            //const double PI = 3.14159;
            //Console.WriteLine("Enter radius of circle");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double areaOfCircle = pi * radius * radius;
            //Console.WriteLine("Enter length of rectangle");
            //double rectangleLength = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter breadth of rectangle");
            //double rectangleBreadth = Convert.ToDouble(Console.ReadLine());
            //double areaOfRectangle = 2 * rectangleLength * rectangleBreadth;
            //Console.WriteLine($"Area of Circle is {areaOfCircle} and area of rectangle is {areaOfRectangle}");
            //Console.ReadLine();

            //12 circumference
            //const double PI = 3.14159;
            //const int DAYS_IN_WEEK = 7;
            //Console.WriteLine("Enter radius of circle");
            //double radius = Convert.ToDouble(Console.ReadLine());
            //double circumference = 2 * PI * radius;
            //Console.WriteLine($"Circumference of circle is {circumference}, and No. of days in a week is {DAYS_IN_WEEK}");
            //Console.ReadLine();

            //13
            //Console.WriteLine("Enter width and height of rectangle in centimetres");
            //double width = Convert.ToDouble(Console.ReadLine());
            //double height = Convert.ToDouble(Console.ReadLine());
            //double areaSquareCm = width * height;
            //const double divideFactor = 6.452;
            //double areaSquareInch = areaSquareCm / divideFactor;
            //Console.WriteLine($"Area in square cm: {areaSquareCm}, Area in square inches: {areaSquareInch}");
            //Console.ReadLine();

            //14
            //Console.WriteLine("Enter employee name");
            ////save name to variable employeeName
            //string employeeName = Console.ReadLine();
            //Console.WriteLine("Enter employee age");
            ////save name to variable employeeAge
            //string employeeAge = Console.ReadLine();
            //Console.WriteLine("Enter employee salary");
            ////save name to variable employeeSalary
            //string employeeSalary = Console.ReadLine();
            ////Display details
            //Console.WriteLine($"Name: {employeeName}, Age: {employeeAge}, Salary: {employeeSalary}");
            //Console.ReadLine();

            //15 coding standards            
            ////store first number in variable num1
            //int firstNumber = 5;
            ////store second number in variable num2
            //int secondNumber = 3;
            ////disply the sum of the numbers
            //Console.WriteLine(firstNumber+secondNumber);

            //16
            //int a = 5;
            //int b = 0;
            //b = a;
            //Console.WriteLine($"a = {a}, b = {b}");
            //Console.ReadLine();

            //17 power of number
            //Console.WriteLine("Enter number");
            //double number = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter power");
            //double power = Convert.ToDouble(Console.ReadLine());

            //double result = Math.Pow(number, power);
            //Console.WriteLine($"{number} to the power of {power} is {result}");
            //Console.ReadLine();

            //18 check voting eligibility
            //Console.WriteLine("Enter age");
            //double age = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter citizenship");
            //string citizenship = Console.ReadLine();

            //if (age >= 18)
            //{
            //    if (citizenship.ToLower() == "indian")
            //    {
            //        Console.WriteLine("The person is eligible to vote");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Person is not an Indian citizen");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Person is not old enough to vote");
            //}
            //Console.ReadLine();


            //19 loan eligibility
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your yearly income in $");
            //double income = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Do you have any outstanding loans? Yes/No");
            //string loanStatus = Console.ReadLine();
            //if (age > 21) {
            //    if (income >= 30000)
            //    {
            //        if (loanStatus.ToLower() == "no")
            //        {
            //            Console.WriteLine("The person is eligible for loan");
            //        }else
            //        {
            //            Console.WriteLine("Not Eligible. You have outstanding loans");
            //        }
            //    }else
            //    {
            //        Console.WriteLine("Not Eligible. Low Income");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible. You are less than 21 year");
            //}
            //Console.ReadLine();

            //20 loan eligibility II
            //Console.WriteLine("Enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter work experience in years");
            //double workExperience = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Do you have a college degree? Yes/No");
            //string collegeDegree = Console.ReadLine();

            //if (age>=18 && age<=35)
            //{
            //    if (workExperience >= 2)
            //    {
            //        if (collegeDegree.ToLower() == "yes" || workExperience >= 5)
            //        {
            //            Console.WriteLine("You are eligible for loan");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Not Eligible. You do not have a college degree");
            //        }
            //    }else
            //    {
            //        Console.WriteLine("Not Eligible. You do not have enough work experience");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Not Eligible. Age is not within limits");
            //}
            //Console.ReadLine();


            //21 vowel or consonant
            //Console.WriteLine("Enter alphabet");
            //string alphabet = Console.ReadLine();
            //alphabet = alphabet.ToLower();
            //if (alphabet == "a" || alphabet == "e" || alphabet == "i" || alphabet == "o" || alphabet == "u")
            //{
            //    Console.WriteLine($"{alphabet} is a vowel");

            //}else
            //{
            //    Console.WriteLine($"{alphabet} is a consonant");
            //}
            //Console.ReadLine();

            //22 check number is positive, negative or zero
            //Console.WriteLine("Enter the number");
            //double number = Convert.ToDouble(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("The number is zero");
            //} else if (number > 0) {
            //    Console.WriteLine("The number is positive");
            //}

            //23
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number%5 == 0 && number%11 == 0)
            //{
            //    Console.WriteLine($"The number {number} is divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine($"The number {number} is not divisible by 5 and 11");
            //}

            //24 simple calculator
            Console.WriteLine("Enter first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation +, -, *, /");
            string operation = Console.ReadLine();
            if (operation == "+"){
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
            }else if (operation == "-"){
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            }else if(operation == "*")
            {
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            }else if(operation == "/")
            {
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            }






            Console.ReadLine();





        }
    }
}
