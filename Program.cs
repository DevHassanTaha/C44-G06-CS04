using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("enter your number");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");




            //Console.WriteLine("enter your number");
            //int num = int.Parse(Console.ReadLine());

            //string massage = num switch
            //{
            //    int number when number % 3 == 0 && number % 4 == 0 => "Yes",
            //    _ => "No",
            //};

            //Console.WriteLine(massage);


            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("enter your number");
            //int.TryParse(Console.ReadLine(), out var X);
            //switch (X)
            //{
            //    case int value when value > 0:
            //        Console.WriteLine("positive");
            //            break;
            //    case int value when value < 0:
            //        Console.WriteLine("negative");
            //        break;
            //    default:
            //        Console.WriteLine("Zero");
            //        break;
            //}
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element
            //Console.WriteLine("enter your first number");
            //int.TryParse(Console.ReadLine(), out int A);

            //Console.WriteLine("enter your second number");
            //int.TryParse(Console.ReadLine(), out int B);

            //Console.WriteLine("enter your last number");
            //int.TryParse(Console.ReadLine(), out int C);

            //int Max = Math.Max(A,Math.Max(B,C));

            //int Min = Math.Min(A,Math.Min(B,C));

            //Console.WriteLine($"max element = {Max}");
            //Console.WriteLine($"min element = {Min}");
            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("enter your number");
            //int.TryParse(Console.ReadLine(),out int X);

            //string message = X switch
            //{
            //    int number when number%2 == 0 => $"number is even {number}",
            //    int number when number % 2 == 1 => $"number is odd {number}",
            //    _ => "invalid input"
            //};
            //Console.WriteLine(message);
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Console.WriteLine("enter character:");
            //char ch = char.Parse(Console.ReadLine().ToLower());

            //string message = ch switch
            //{
            //    'a' or 'e' or 'i' or 'o' or 'u' => $"{ch} is a vowel",
            //    _ => $"{ch} is a consonant"
            //};

            //Console.WriteLine(message); 
            #endregion

            #region 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("enter your number");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i <= number; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("enter your number");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(number * i);
            //}
            #endregion

            #region 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("enter your number");
            //int.TryParse(Console.ReadLine(),out int number);

            //for (int i = 1;i <= number; i++)
            //{
            //    if(i%2 == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 9- Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter your number:");
            //int number01 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter power:");
            //int power = int.Parse(Console.ReadLine());

            //int result = (int)Math.Pow(number01, power);

            //Console.WriteLine($"{number01}^{power} = {result}");

            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total,average and percentage.
            //int total = 0;
            //Console.WriteLine("enter marks of five subjects");
            //for (int i = 1; i <= 5; i++)
            //    total += int.Parse(Console.ReadLine());

            //double average = total / 5.0;
            //double percentage = (total /500.0) * 100;

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage);

            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("enter month");
            //int month = int.Parse(Console.ReadLine());
            //int days = DateTime.DaysInMonth(2025, month);
            //Console.WriteLine("Days in Month: " + days);

            #endregion

            #region 12- Write a program to create a Simple Calculator.
            //Console.WriteLine("enter firest number");
            //double a = double.Parse(Console.ReadLine());


            //Console.WriteLine("enter seconed number");
            //double b = double.Parse(Console.ReadLine());

            //Console.WriteLine("choice --->  +   , -  , *  ,  /  ");
            //char operetor = char.Parse(Console.ReadLine());


            //switch (operetor)
            //{
            //    case '+':
            //        Console.WriteLine(a + b); break;
            //    case '-':
            //        Console.WriteLine(a - b); break;
            //    case '*':
            //        Console.WriteLine(a * b); break;
            //    case '/':
            //        Console.WriteLine(a / b); break;
            //    default:
            //        Console.WriteLine("Invalid operator"); break;
            //} 
            #endregion

            #region 13- Write a program to allow the user to enter a string and print the REVERSE  of it.
            //Console.WriteLine("Enter string");
            //string a = Console.ReadLine();

            //char[] arr = a.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine(arr);

            #endregion

            #region 14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter number");
            //string number = Console.ReadLine();

            //char[] arr = number.ToCharArray();
            //Array.Reverse(arr);
            //Console.WriteLine(arr);

            #endregion

            #region 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            #endregion


            #region 16- Create a program that asks the user to input three points (x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("enter x1");
            //double x1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter y1");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter x2");
            //double x2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter y2");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter x3");
            //double x3 = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter y3");
            //double y3 = double.Parse(Console.ReadLine());

            //bool isCollinear = (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
            //string result = (isCollinear) ? "Points are on a straight line" : "Not on a straight line";
            //Console.WriteLine(result);
            #endregion

            #region 17- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.A worker's efficiency level is determined as follows:
            //double hours = double.Parse(Console.ReadLine());
            //if (hours >= 2 && hours < 3)
            //    Console.WriteLine("highly efficient");
            //else if (hours >= 3 && hours < 4)
            //    Console.WriteLine("increase their speed");
            //else if (hours >= 4 && hours <= 5)
            //    Console.WriteLine("enhance their speed");
            //else if (hours > 5)
            //    Console.WriteLine("leave the company");
            //else
            //    Console.WriteLine("invalid input"); 
            #endregion










        }
    }
}
