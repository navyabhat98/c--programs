using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pascal;
namespace assignemnt
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
             while(true)
             {
                    
                    Console.WriteLine("***Assignment module 1***");
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
                    Console.WriteLine("12.To print Pascal triangle.");
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
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                            case 1: new pascal().evenorodd();
                                    Console.WriteLine();
                                    break;
                            case 2: new pascal().posorneg();
                                    Console.WriteLine();
                                    break;
                            case 3: new pascal().prime();
                                    Console.WriteLine();
                                    break;
                            case 4: new pascal().sumofn();
                                    Console.WriteLine();
                                    break;
                            case 5: new pascal().sumofn2();
                                    Console.WriteLine();
                                    break;
                            case 6: new pascal().sumofn3();
                                    Console.WriteLine();
                                    break;
                            case 7: new pascal().sumofeven();
                                    Console.WriteLine();
                                    break;
                            case 8: new pascal().sumofodd();
                                    Console.WriteLine();
                                    break;
                            case 9: new pascal().factorial();
                                    Console.WriteLine();
                                    break;
                            case 10: new pascal().fibterm();
                                     Console.WriteLine();
                                     break;
                            case 11: new pascal().fibseries();
                                     Console.WriteLine();
                                    break;
                            case 12:new pascal().Fun_pas();
                                    Console.WriteLine();
                                    break; 
                            case 13: new pascal().largestof2();
                                     Console.WriteLine();
                                     break;
                            case 14: new pascal().smallestof2();
                                     Console.WriteLine();
                                     break;
                            case 15: new pascal().largestof3();
                                     Console.WriteLine();
                                     break;
                            case 16: new pascal().smallestof3();
                                     Console.WriteLine();
                                     break;
                            case 17: Console.WriteLine("Enter 2 no. to find Lcm");
                                     int a = int.Parse(Console.ReadLine());
                                     int b = int.Parse(Console.ReadLine());
                                     int  l = new pascal().Lcm(a,b);
                                     Console.WriteLine("LCM ={0}",b);
                                     break;
                            case 18: new pascal().hcf();
                                     Console.WriteLine();
                                     break;
                            case 19: Console.Clear();
                                     new pascal().calculator();
                                     Console.WriteLine();
                                     break;
                            case 20 : new pascal().neon();
                                      Console.WriteLine();
                                      break;
                            case 21: new pascal().perfect();
                                     Console.WriteLine();
                                     break;
                            case 22: new pascal().Fun_Armstrong();
                                     Console.WriteLine();
                                     break;
                            case 23: new pascal().inputs();
                                     Console.WriteLine();
                                     break;
                            case 24: new pascal().datatypes();
                                     Console.WriteLine();
                                     break;
                            case 25: new pascal().ops();
                                     Console.WriteLine();
                                     break;                                  
                             case 26: new Pascal().FloydTriangle();
                                     Console.WriteLine();
                                     break;
                            case 27: new Pascal().Pyramind();
                                     Console.WriteLine();
                                     break;
                            case 28: new Pascal().PyramidTriangleAlphabets();
                                     Console.WriteLine();
                                     break;
                            case 29: new Pascal().RightAngledTriangle();
                                     Console.WriteLine();
                                     break;
                            case 30: new Pascal().ReversedPyramid();
                                     Console.WriteLine();
                                     break;
                            case 31: new Pascal().ReversedRightAngle();
                                     Console.WriteLine();
                                     break;
                            case 32: new Pascal().alpha();
                                     Console.WriteLine();
                                     break;
                            default: Console.WriteLine("Invalid Input");
                    }
                Console.ReadKey();
             }
        }
    }
}

                    
             
            
        
                
             
              
             
           

