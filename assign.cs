using System;

namespace assignment
{
    public class pascal
    {
        public pascal()
        {
        }
        int[] a, b = new int[20];   //array used for illustrating array operation
        int n;
        public void Func_Armstrong()
        {
            Console.WriteLine("Armstrong number");
            Console.Write("Enter no:");
            int a = int.Parse(Console.ReadLine());
            int originalNumber = a;
            int result = new int();

            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                result += remainder * remainder * remainder;
                originalNumber /= 10;
            }

            if (result == a)
                Console.WriteLine("{0} is an Armstrong number.", a);
            else
                Console.WriteLine("{0} is not an Armstrong number.", a);

        }
        public void oddneven()
        {
            int a;
            Console.WriteLine("Odd or even");
            Console.WriteLine("Enter a no");
            a = int.Parse((Console.ReadLine()));
            if (a % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

        }
        public void posorneg()
        {
            int a;
            Console.WriteLine("Positive or negative");
            Console.WriteLine("Enter a no");
            a = int.Parse((Console.ReadLine()));
            if (a >= 0)
                Console.WriteLine("Positive");
            else
                Console.WriteLine("Negative");
        }
        public void prime()
        {
            int n, i, flag = 0;
            Console.WriteLine("Prime number");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    flag = 1;
            }
            if (flag == 0)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Comosite");


        }
        public void sumofn()
        {
            int n, i, sum = 0;
            Console.WriteLine("Sum of n:");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        public void sumofn2()
        {
            int n, i, sum = 0;
            Console.WriteLine("Sum of n squares ");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                sum = sum + i * i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        public void sumofn3()
        {
            int n, i, sum = 0;
            Console.WriteLine("sum of n cubes");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                sum = sum + i * i * i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        public void sumofeven()
        {
            int n, i, sum = 0;
            Console.WriteLine("sum of n even");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= 2*n; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        public void sumofodd()
        {

            int n, i, sum = 0;
            Console.WriteLine("Sum of n odd");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= 2*n; i++)
            {
                if (i % 2 != 0)
                    sum = sum + i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        public void fact()
        {
            int n, i, fact = 1;
            Console.WriteLine("Factorial");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Fact= {0}", fact);

        }
        public void fibseries()
        {
            int a = 0, b = 1, c, n, i;
            Console.WriteLine("fibonacci series");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            Console.Write("{0}\t{1}", a, b);
            for (i = 1; i <= (n - 2); i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write("\t{0}", c);
            }

        }
        public void fibterm()
        {
            int a = 0, b = 1, n;
            int c = new int();
            Console.WriteLine("nth fibonacci term");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));

            for (int i = 1; i <= (n - 2); i++)
            {
                c = a + b;
                a = b;
                b = c;

            }
            Console.WriteLine("nth term:{0}", c);

        }
        public void perfect()
        {
            int sum = 0, n, i;
            Console.WriteLine("Perfect no.");
            Console.WriteLine("Enter n");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }


            if (sum == n)
                Console.WriteLine("It is a pefect no\n");

            else
                Console.WriteLine("It is not a perfect no");

        }
        public void neon()
        {
            int x, a, rem, i, y = 0;
            Console.WriteLine("Neon no.:");
            Console.WriteLine("Enter x\n");
            x = int.Parse((Console.ReadLine()));
            a = x;
            x = x * x;
            while (x != 0)
            {
                rem = x;
                x = x / 10;
                rem = rem % 10;
                y = y + rem;
            }
            if (a == y)
            {
                Console.WriteLine("It is a neon number");
            }
            else
            {
                Console.WriteLine("It is not a neon number");
            }
        }

        public void Fun_pas()
        {
            int rows, coef = 1, space, i, j;

            Console.WriteLine("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = 0; i < rows; i++)
            {
                for (space = 1; space <= rows - i; space++)
                    Console.Write("  ");

                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        coef = 1;
                    else
                        coef = coef * (i - j + 1) / j;

                    Console.Write("{0,4}", coef);
                }
                Console.WriteLine();
            }

        }

        public void FloydTriangle()
        {
            int rows, i, j, number = 1;

            Console.Write("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("{0} ", number);
                    ++number;
                }

                Console.WriteLine();
            }

        }

        public void Pyramind()
        {
            int i, space, rows, k = 0;

            Console.WriteLine("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; ++i, k = 0)
            {
                for (space = 1; space <= rows - i; ++space)
                {
                    Console.Write("  ");
                }

                while (k != 2 * i - 1)
                {
                    Console.Write("* ");
                    ++k;
                }

                Console.WriteLine();
            }

        }

        public void PyramidTriangleAlphabets()
        {
            int rows, i, j, space;
            char a = 'A';
            Console.WriteLine("Enter n");
            rows = int.Parse(Console.ReadLine());
            for (i = 0; i < rows; i++)
            {
                for (space = 1; space < rows - i; space++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", a);
                }
                a++;
                Console.WriteLine();
            }

        }
        public void RightAngledTriangle()
        {
            Console.WriteLine("Enter number of Rows:");
            int i, j, k;
            int rows = int.Parse(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();

            }

            for (k = rows - 1; k > 0; k--)
            {
                for (int l = 1; l <= k; l++)
                {
                    Console.Write("{0} ", l);
                }
                Console.WriteLine();
            }
        }

        public void ReversedPyramid()
        {
            int i, j, rows;


            Console.WriteLine("Enter number of rows : ");
            rows = int.Parse(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {

                for (j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }


                for (j = 1; j <= (rows * 2 - (2 * i - 1)); j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
            }
        }

        public void ReversedRightAngle()
        {
            int i, j, rows;

            Console.WriteLine("Enter number of rows: ");
            rows = int.Parse(Console.ReadLine());

            for (i = rows; i >= 1; --i)
            {
                for (j = 1; j <= i; ++j)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
        public void alpha()
        {
            int i, j, k, n;
            Console.WriteLine("enter rows");
            n = int.Parse(Console.ReadLine());
            char a;
            for (i = 0; i < n; i++)
            {
                a = 'A';
                for (int space = 1; space < n - i; space++)
                    Console.Write(" ");
                for (j = 0; j <= i; j++)
                {
                    //a = 'A' + i;
                    Console.Write("{0} ",(char)(a+i));
                    a--;

                }
                Console.WriteLine();
            }
        }
        public void largestof2()
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("{0} is greater than {1}", a, b);

            }
            else
            {
                Console.WriteLine("{0} is greater than {1}", b, a);
            }
        }

        public void smallestof2()
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a < b)
            {

                Console.WriteLine("{0} is smaller than {1}", a, b);
            }
            else
            {
                Console.WriteLine("{0} is smaller than {1}", b, a);
            }
        }
        public void largestof3()
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a > b) && (a > c))
                Console.WriteLine("{0} is greater", a);
            else if (b > c)
                Console.WriteLine("{0} is greater", b);
            else
                Console.WriteLine("{0} is greater", c);
        }
        public void smallestof3()
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = (a < b) && (a < c) ? a : (b < c) ? b : c;
            Console.WriteLine("The smalles of three is:{0}.", d);

        }

        public int Lcm(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a;
                num2 = b;
            }
            else
            {
                num1 = b;
                num2 = a;
            }
            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                    return i * num1;
            }
            return num2;
        }

        public void hcf()
        {
            int x, y, i;
            int hcf = 0;
            Console.Write("\nEnter the two Numbers : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            for (i = 1; i <= x || i <= y; ++i)
            {
                if (x % i == 0 && y % i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("\nCommon Factor is :{0} ", hcf);
        }

        public void calculator()
        {
            Console.WriteLine("***Simple Calculator*** ");
            //int ch = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.Write("Menu\n1.Addition\t2.Subtraction\t3.Multiplication\n4.Division\t5.Factorial\t6.Exit\nEnter your Choise:");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter two numbers:");
                            int x = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            int c = x + y;
                            Console.WriteLine("Sum is: {0}", c);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter two numbers:");
                            int x = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            int c = x - y;
                            Console.WriteLine("Difference is: {0}", c);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter two numbers:");
                            int x = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            int c = x * y;
                            Console.WriteLine("Product is: {0}", c);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter two numbers:");
                            int x = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            try
                            {
                                float c = x / y;
                                Console.WriteLine("quotient is: {0}", c);
                                int d = x % y;
                                Console.WriteLine("Remainder is: {0}", d);
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("Divide by zero error");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("enter a num:");
                            int a = int.Parse(Console.ReadLine());
                            int res = 1;
                            for (int i = a; i >= 1; i--)
                            {
                                res = res * i;
                            }
                            Console.WriteLine("Facrorial is: {0}", res);
                        }
                        break;
                    case 6:
                        break;
                        
                    default:
                        Console.WriteLine("Invalid choise!!");
                        break;
                }
            }
        }

        public void inputs()
        {

            Console.WriteLine("Enter a number:");
            int number, sum = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                if (number > 0)
                    sum += number;
            } while (number != 0);

            Console.WriteLine("Sum = {0}", sum);
        }

        public void datatypes()
        {
            Console.WriteLine("Size of Boolean: {0} bytes", sizeof(bool));
            Console.WriteLine("Size of byte: {0} bytes", sizeof(byte));
            Console.WriteLine("Size of character: {0} bytes", sizeof(char));
            Console.WriteLine("Size of Integer: {0} bytes", sizeof(int));
            Console.WriteLine("Size of Float: {0} bytes", sizeof(float));
            Console.WriteLine("Size of Double: {0} bytes", sizeof(double));
            Console.WriteLine("Size of Long integer: {0} bytes", sizeof(long));
            Console.WriteLine("Size of Decimal: {0} bytes", sizeof(decimal));
        }

        public void ops()
        {
            Console.WriteLine("Arithmatic operators:");
            Console.WriteLine("Enter two nos.:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ++ -> {1}", a, a++);
            Console.WriteLine("{0} -- ->{1}", a, a--);
            Console.WriteLine("++{0} -> {1}", b, ++b);
            Console.WriteLine("--{0} -> {1}", b, --b);
            Console.WriteLine("Relational operators:");
            Console.WriteLine("Enter two nos.:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x == y)
                Console.WriteLine("{0} == {1}", x, y);
            if (x != y)
                Console.WriteLine("{0} != {1}", x, y);
            if (x > y)
                Console.WriteLine("{0} > {1}", x, y);
            if (x < y)
                Console.WriteLine("{0} < {1}", x, y);
            if (x >= y)
                Console.WriteLine("{0} >= {1}", x, y);
            if (x <= y)
                Console.WriteLine("{0} <= {1}", x, y);
            Console.WriteLine("bitwise operators:");
            Console.WriteLine("Enter two nos.:");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} AND {1}: {2}", p, q, (p & q));
            Console.WriteLine("{0} OR {1}: {2}", p, q, (p | q));
            Console.WriteLine("{0} XOR {1}: {2}", p, q, (p ^ q));
            Console.WriteLine("{0} >> {1}: {2}", p, q, (p >> q));
            Console.WriteLine("{0} << {1}: {2}", p, q, (p << q));
            Console.WriteLine("{0} ~: {2}", p, ~p);

        }
        public void revs()
        {
            Console.WriteLine("REverse of no.");
            Console.WriteLine("Enter a number:");
            int x = int.Parse(Console.ReadLine());
            //int temp = x;
            while (x != 0)
            {
                int temp = x;
                temp = temp % 10;
                x = x / 10;
                Console.Write("{0}", temp);
            }
        }

        public void magnitude()
        {
            int num, mag = 0;
            Console.WriteLine("Enter the Number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + num);
            while (num > 0)
            {
                mag++;
                num = num / 10;
            };
            Console.WriteLine("Magnitude: " + mag);
            Console.Read();
        }
        public void sumofdigits()
        {
            int n, sum = 0, m;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.Write("Sum is= " + sum);
        }
        public void leapyear()
        {
            Console.WriteLine("Enter the Year in Four Digits : ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", y);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", y);
            }
            Console.ReadLine();
        }
        public void merge()
         {
            int[] a = new int[100];
            int[] sorted = new int[100];
            Console.WriteLine("Enter n");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("Enter the array elements:");
            for (int i1 = 0; i1 < x; i1++)
            {
                string s2 = Console.ReadLine();
                a[i1] = Int32.Parse(s2);
            }
            int[] b = new int[100];
            Console.WriteLine("Enter m");
            string s1 = Console.ReadLine();
            int x1 = Int32.Parse(s);
            Console.WriteLine("Enter the array elements:");
            for (int i1 = 0; i1 < x1; i1++)
            {
                string s2 = Console.ReadLine();
                b[i1] = Int32.Parse(s2);
            }
            int i, j, k;

            j = k = 0;

            for (i = 0; i < x + n;)
            {
                if (j < x && k < x1)
                {
                    if (a[j] < b[k])
                    {
                        sorted[i] = a[j];
                        j++;
                    }
                    else
                    {
                        sorted[i] = b[k];
                        k++;
                    }
                    i++;
                }
                else if (j == x)
                {
                    for (; i < x + x1;)
                    {
                        sorted[i] = b[k];
                        k++;
                        i++;
                    }
                }
                else
                {
                    for (; i < x + x1;)
                    {
                        sorted[i] = a[j];
                        j++;
                        i++;
                    }
                }
            }
            Console.WriteLine("Sorted and merged array is:");
            for (int c = 0; c < x + x1; c++)
            {
                Console.Write("{0} ", sorted[c]);
            }

        } 
        public void binary()
        {
            int i, j;
            int count = 1;

            for (i = 1; i <= 4; i++)
            {
                Console.WriteLine();
                for (j = 1; j <= i; j++)
                {
                    Console.WriteLine("{0}", count % 2);
                    count++;
                }

                if (i % 2 == 0)
                    count = 1;
                else
                    count = 0;
            }
        }
        public void bubblesort()
        {
            int[] a = { 30, 56, 2, 4, 78, 34, 100, 45 };
            int temp;
            int numLength = a.Length;
            Console.WriteLine("unsorted array:");
            foreach (int num in a)
            {
                Console.Write("{0} ", num);
            }

            //sorting an array
            for (int i = 1; (i <= (numLength - 1)); i++)
            {
                
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (a[j + 1] > a[j])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        
                    }
                }
            }

            //Sorted array
            Console.WriteLine("sorted array:");
            foreach (int num in a)
            {
                Console.Write("{0} ", num);
            }
        }
        public void linearSearch()
        {
            int[] a = new int[100];
            Console.WriteLine("Enter n");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("\n Enter the array elements \n");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("Enter the Search element\n");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            for (int i = 0; i < x; i++)
            {
                if (a[i] == x2)
                {
                    Console.WriteLine("Search successful");
                    Console.WriteLine("Element {0} found at location {1}\n", x2, i + 1);
                    break;
                }
            }
            Console.WriteLine("Entered element not found. Search unsuccessful");
        }
       public void binarySearch()
        {
            int[] a = new int[100];
            bool b = false;
            Console.WriteLine("Enter n");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            Console.WriteLine("\n Enter the array elements \n");
            for (int i = 0; i < n; i++)
            {
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            int min = 0;
            int max = n - 1;
            Console.WriteLine("Enter the Search element\n");
            int key = Int32.Parse(Console.ReadLine());
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == a[mid])
                {
                    Console.WriteLine("Found at position:{0}", ++mid);
                    b = true;
                    break;
                }
                else if (key < a[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (b != true)
                Console.WriteLine("Element not found");
        }

        public void functionOverloading()
        {
            Fun(4, 4.2, "hello");
            Console.WriteLine();
            Fun(31, 7.6);
            Console.WriteLine();
            Fun(d:2, a: 31, b: 98.0, c: "hello");   //sending the parameter 
            Console.ReadKey();
        }

        public static void Fun(int a, double b, String c = "csharp")
        {
            Console.WriteLine("Fun(4, 4.2, \"hello\");");
            Console.WriteLine("a:{0}\nb:{1}\nc:{2}", a, b, c);            
        }
        public static void Fun(int a, double b)
        {
            Console.WriteLine(" Fun(31, 7.6);");
            Console.WriteLine("a:{0}\nb:{1}", a, b);
        }
        public static void Fun(int a, double b, String c = "csharp",int d =9)
        {
            Console.WriteLine("Fun(d:2, a: 31, b: 98.0, c: \"hello\");");
            Console.WriteLine("a:{0}\nb:{1}\nc:{2}", a, b, c);
        }
        public void Fun1()
        {
            try
            {
                int n,m;
                n = int.MaxValue;
                m = int.MinValue;
                unchecked    //unchecked will ignore the error and executes 
                {
                    m--;
                    Console.WriteLine("Inside Unchecked , m = {0}", m);
                }
                checked         //check will not ignore the error
                {
                    n++;
                }
                
                Console.WriteLine("n ={0}", n);
                

            }
            catch (OverflowException e)
            {
                Console.WriteLine("error:{0}", e.ToString());
            }
        }
        public void Fun2()
        {
            try
            {
                Console.WriteLine("Inside fun2");
                throw new Exception("new error");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("error");
            }
            finally             //finally will be executed before handling it.
            {
                Console.WriteLine("Finally executued before handling the error");
            }
        }
        
        public void insert()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter n");
            string x = Console.ReadLine();
            n = Int32.Parse(x);
            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
                a[i] = Int32.Parse(s);
            }

            Console.WriteLine("Enter position:");
            int pos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the item to be inserted:");
            String s1 = Console.ReadLine();
            int item = Int32.Parse(s1);
            if (pos <= n - 1)
            {
                for (int i = n - 1; i >= pos; i--)
                {
                    a[i + 1] = a[i];
                }
                n = n + 1;
                a[pos] = item;
            }
            else
            {
                Console.WriteLine("Invalid position\n");
            }
            Console.WriteLine("Array now:");
            for(int z=0; z< n; z++)
                Console.Write("{0} ", a[z]);
        }
        public void delete()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter n");
            string x = Console.ReadLine();
            n = Int32.Parse(x);
            Console.WriteLine("Enter elements");
            for (int i = 0; i < n; i++)
            {
                String s = Console.ReadLine();
                a[i] = Int32.Parse(s);
            }

            Console.WriteLine("Enter position:");
            int pos = Int32.Parse(Console.ReadLine());
            if (pos <= n - 1)
            {
               for (int i = pos; i < n - 1; i++)
               {
                 a[i] = a[i + 1];
               }
                n = n - 1;
                Console.WriteLine(" The deleted element is equal to %d", item);
            }
            else
            {
                Console.WriteLine("Invalid position\n");
            }
            Console.WriteLine("Array now:");
            for (int z = 0; z < n; z++)
                Console.Write("{0} ", a[z]);
        }
    }
}

