using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignment;
namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t***Assignment module 1***");
                Console.WriteLine("1.To check if number is even or odd.");
                Console.WriteLine("2.To check if no. is postive or neagtive.");
                Console.WriteLine("3.To check if no. is Prime.");
                Console.WriteLine("4.To Find sum of n naural no.");
                Console.WriteLine("5.To Find sum of squares of n natural no.");
                Console.WriteLine("6.To find sum of cubes of n natural no. ");
                Console.WriteLine("7.To Find sum of even no.");
                Console.WriteLine("8.To Find sum of odd no.");
                Console.WriteLine("9.To Find factorial of a no.");
                Console.WriteLine("10.To Find nth fibonacci series.");
                Console.WriteLine("11.To Find Fibonacci series.");
                Console.WriteLine("12.To print pascal triangle.");
                Console.WriteLine("13.To Print Largest of two no.");
                Console.WriteLine("14.To print smallest of two no.");
                Console.WriteLine("15.To print largest of 3 no.");
                Console.WriteLine("16.To print smallest of 3 no.");
                Console.WriteLine("17.To Find LCM");
                Console.WriteLine("18.To Find HCF");
                Console.WriteLine("19.Calcualtor");
                Console.WriteLine("20.Neon no.");
                Console.WriteLine("21.Perfect no.");
                Console.WriteLine("22.Armstrong no.");
                Console.WriteLine("23.User Input summation.");
                Console.WriteLine("24.Size of Data type.");
                Console.WriteLine("25.Illustration of Operators");
                Console.WriteLine("26.Floyd Triangle");
                Console.WriteLine("27. Pyramid pattern printing.");
                Console.WriteLine("28.Pyrmaind pattern printing having alphabets.");
                Console.WriteLine("29.Right Angled triangle pattern ");
                Console.WriteLine("30.Reversed Pyramid pattern");
                Console.WriteLine("31.Reversed right angles traingle");
                Console.WriteLine("32.Speacial aphabetic pattern printing");
                Console.WriteLine("33.To find reverse of a no.");
                Console.WriteLine("34.To find sum of digits.");
                Console.WriteLine("35.To find magnitude of a no.");
                Console.WriteLine("36.To check for leapYear");
                Console.WriteLine("37.To display date.");
                Console.WriteLine("38.Merge single dimensional array and sorting.");
                Console.WriteLine("39.Binary pattern printing");
                Console.WriteLine("40.Bubble sort");
                Console.WriteLine("41.Linear search");
                Console.WriteLine("42.Binary Search");
                Console.WriteLine("43.Insertion into array");
                Console.WriteLine("44.Deletion from array");
                Console.WriteLine("45.Function overloading");
                Console.WriteLine("46.Exception handling");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        new pascal().oddneven();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Clear();
                        new pascal().posorneg();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Clear();
                        new pascal().prime();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Clear();
                        new pascal().sumofn();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Clear();
                        new pascal().sumofn2();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.Clear();
                        new pascal().sumofn3();
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.Clear();
                        new pascal().sumofeven();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.Clear();
                        new pascal().sumofodd();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.Clear();
                        new pascal().fact();
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.Clear();
                        new pascal().fibterm();
                        Console.WriteLine();
                        break;
                    case 11:
                        Console.Clear();
                        new pascal().fibseries();
                        Console.WriteLine();
                        break;
                    case 12:
                        Console.Clear();
                        new pascal().Fun_pas();
                        Console.WriteLine();
                        break;
                    case 13:
                        Console.Clear();
                        new pascal().largestof2();
                        Console.WriteLine();
                        break;
                    case 14:
                        Console.Clear();
                        new pascal().smallestof2();
                        Console.WriteLine();
                        break;
                    case 15:
                        Console.Clear();
                        new pascal().largestof3();
                        Console.WriteLine();
                        break;
                    case 16:
                        Console.Clear();
                        new pascal().smallestof3();
                        Console.WriteLine();
                        break;
                    case 17:
                        Console.Clear();
                        Console.WriteLine("Enter 2 no. to find Lcm");
                        int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        int l = new pascal().Lcm(a, b);
                        Console.WriteLine("LCM ={0}", b);
                        break;
                    case 18:
                        Console.Clear();
                        new pascal().hcf();
                        Console.WriteLine();
                        break;
                    case 19:
                        Console.Clear();
                        new pascal().calculator();
                        Console.WriteLine();
                        break;
                    case 20:
                        Console.Clear();
                        new pascal().neon();
                        Console.WriteLine();
                        break;
                    case 21:
                        Console.Clear();
                        new pascal().perfect();
                        Console.WriteLine();
                        break;
                    case 22:
                        Console.Clear();
                        new pascal().Func_Armstrong();
                        Console.WriteLine();
                        break;
                    case 23:
                        Console.Clear();
                        new pascal().inputs();
                        Console.WriteLine();
                        break;
                    case 24:
                        Console.Clear();
                        new pascal().datatypes();
                        Console.WriteLine();
                        break;
                    case 25:
                        Console.Clear();
                        new pascal().ops();
                        Console.WriteLine();
                        break;
                    case 26:
                        Console.Clear();
                        new pascal().FloydTriangle();
                        Console.WriteLine();
                        break;
                    case 27:
                        Console.Clear();
                        new pascal().Pyramind();
                        Console.WriteLine();
                        break;
                    case 28:
                        Console.Clear();
                        new pascal().PyramidTriangleAlphabets();
                        Console.WriteLine();
                        break;
                    case 29:
                        Console.Clear();
                        new pascal().RightAngledTriangle();
                        Console.WriteLine();
                        break;
                    case 30:
                        Console.Clear();
                        new pascal().ReversedPyramid();
                        Console.WriteLine();
                        break;
                    case 31:
                        Console.Clear();
                        new pascal().ReversedRightAngle();
                        Console.WriteLine();
                        break;
                    case 32:
                        Console.Clear();
                        new pascal().alpha();
                        Console.WriteLine();
                        break;
                    case 33:
                        Console.Clear();
                        new pascal().revs();
                        Console.WriteLine();
                        break;
                    case 34:
                        Console.Clear();
                        new pascal().sumofdigits();
                        break;
                    case 35:
                        Console.Clear();
                        new pascal().magnitude();
                        break;
                    case 36:
                        Console.Clear();
                        new pascal().leapyear();
                        break;
                    case 37:
                        Console.WriteLine("Todays date");
                        string today = DateTime.Now.ToShortDateString();
                        Console.WriteLine(today);
                        break;
                    case 38:
                        Console.Clear();
                        new pascal().merge();
                        break;
                    case 39:
                        Console.Clear();
                        new pascal().binary();
                        break;
                    case 40:
                        Console.Clear();
                        new pascal().bubblesort();
                        break;
                    case 41:
                        Console.Clear();
                        new pascal().linearSearch();
                        break;
                    case 42:
                        Console.Clear();
                        new pascal().binarySearch();
                        break;
                    case 43:
                        Console.Clear();
                        new pascal().insert();
                        break;
                    case 44:
                        Console.Clear();
                        new pascal().delete();
                        break;
                    case 45:            
                        Console.Clear();
                        new pascal().functionOverloading();
                        break;
                    case 46:                
                        Console.Clear();
                        Console.WriteLine("Exception handling");
                        new pascal().Fun1();
                        try
                        {
                            new pascal().Fun2();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception handled in main");
                        }
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
