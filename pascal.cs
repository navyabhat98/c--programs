using System;
namespace pascal
{
    public class Pascal
    {
        public Pascal()
        {
        }
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
                Console.WriteLine("{0} is not an Armstrong number.",a);

        }
        void oddneven()
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
        void posorneg()
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
        void prime()
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
        void sumofn()
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
        void sumofn2()
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
        void sumofn3()
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
        void sumofeven()
        {
            int n, i, sum = 0;
            Console.WriteLine("sum of n even");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    sum = sum + i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        void sumofodd()
        {

            int n, i, sum = 0;
            Console.WriteLine("Sum of n odd");
            Console.WriteLine("Enter a no");
            n = int.Parse((Console.ReadLine()));
            for (i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    sum = sum + i;
            }
            Console.WriteLine("Sum= {0}", sum);

        }
        void fact()
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
        void fibseries()
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
        void fibterm()
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
            Console.WriteLine("nth term:{0}",c);

        }
        void perfect()
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
        void neon()
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
            int rows,i, j, space;
            char a = 'A';
            Console.WriteLine("Enter n");
            rows = int.Parse(Console.ReadLine());
            for(i=0;i<rows;i++)
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
            
            for (k = rows-1; k > 0; k--)
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
            int i,j,k,n;
            Console.WriteLine("enter rows");
            n = int.Parse(Console.ReadLine());
            char a;
            for(i=0;i<n;i++)
                {
                a ='A';
                for(j=0;j<=i;j++)
                    {
                    a+=i;
                    Console.Write("{0} ",a);
                    a--;

                    }
                Console.WriteLine();
                }
            }
        public static void largestof2()
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
        public static void largestof3()
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
        public static void smallestof3()
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = (a<b)&&(a<c)?a:(b<c)?b:c;
            Console.WriteLine("The smalles of three is:{0}.",d);
            
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
            y= int.Parse(Console.ReadLine());
            for (i = 1; i <= x || i <= y; ++i)
            {
                if (x % i == 0 && y % i == 0)
                {
                    hcf = i;
                }
            }
            Console.Write("\nCommon Factor is :{0} ",hcf);
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
                    case 6: Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Invalid choise!!");
                        break;
                }
            }
        }

        public void inputs()
        {
            
            Console.WriteLine("Enter a number:");
            int number,sum=0;
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
            Console.WriteLine("Size of Boolean: {0}", sizeof(bool));
            Console.WriteLine("Size of byte: {0}", sizeof(byte));
            Console.WriteLine("Size of character: {0}", sizeof(char));
            Console.WriteLine("Size of Integer: {0}", sizeof(int));
            Console.WriteLine("Size of Float: {0}", sizeof(float));
            Console.WriteLine("Size of Double: {0}", sizeof(double));
            Console.WriteLine("Size of Long integer: {0}", sizeof(long));
            Console.WriteLine("Size of Decimal: {0}", sizeof(decimal));
        }

       public void ops()
        {
            Console.WriteLine("Arithmatic operators:");
            Console.WriteLine("Enter two nos.:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ++ -> {1}",a, a++);
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
            Console.WriteLine("{0} ~: {2}", p,~p);
        }
       
    }
}
