using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations_DLL;

namespace Sorting_MathOperations
{
    class Program
    {
        void sortArray()
        {
            int size;
            int[] a = new Int32[50];
            Console.WriteLine("Enter the size of array: ");
            size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements to the array: ");
            for (int i = 0; i < size; i++)
                a[i] = Int32.Parse(Console.ReadLine());
            Console.Write("Before Sorting: ");
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.Write("\nAfter Sorting: ");
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + " ");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Class1 c = new Class1();
            MathOperations e = new MathOperations();
            int choice1, a, b;
            for (; ; )
            {
                Console.WriteLine("Enter Choice: ");
                Console.WriteLine("1: Sorting of Array\n2: MathOperations(.dll)\n3: MathOperations(.exe)");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: Console.WriteLine("\n*** SORTING ***"); p.sortArray(); break;
                    case 2:
                        Console.WriteLine("\n** .DLL **");
                        Console.WriteLine("1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n5: Moduli");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                        switch (choice1)
                        {
                            case 1:
                                Console.WriteLine("\n*** ADDITION ***");
                                Console.WriteLine("Enter two values for Addition: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Addition of " + a + " and " + b + " is " + c.Add(a, b));
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\n*** SUBTRACTION ***");
                                Console.WriteLine("Enter two values for Subtraction: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Subtraction of " + a + " and " + b + " is " + c.Sub(a, b));
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\n*** MULTIPLICATION ***");
                                Console.WriteLine("Enter two values for Multiplication: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Multiplication of " + a + " and " + b + " is " + c.Mul(a, b));
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\n*** DIVISION ***");
                                Console.WriteLine("Enter two values for Division: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Division of " + a + " and " + b + " is " + c.Div(a, b));
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\n*** MODULUS ***");
                                Console.WriteLine("Enter two values for Modulus");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Moduli of " + a + " and " + b + " is " + c.Mod(a, b));
                                Console.ReadLine();
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n** .EXE **");
                        Console.WriteLine("1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n5: Moduli");
                        int choice2 = Convert.ToInt32(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                Console.WriteLine("\n*** ADDITION ***");
                                Console.WriteLine("Enter two values for Addition: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Addition of " + a + " and " + b + " is " + e.Add(a, b));
                                Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("\n*** SUBTRACTION ***");
                                Console.WriteLine("Enter two values for Subtraction: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Subtraction of " + a + " and " + b + " is " + e.Sub(a, b));
                                Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("\n*** MULTIPLICATION ***");
                                Console.WriteLine("Enter two values for Multiplication: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Multiplication of " + a + " and " + b + " is " + e.Mul(a, b));
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("\n*** DIVISION ***");
                                Console.WriteLine("Enter two values for Division: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Division of " + a + " and " + b + " is " + e.Div(a, b));
                                Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("\n*** MODULUS ***");
                                Console.WriteLine("Enter two values for Modulus");
                                a = Convert.ToInt32(Console.ReadLine());
                                b = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Moduli of " + a + " and " + b + " is " + e.Mod(a, b));
                                Console.ReadLine();
                                break;
                        }
                        break;
                }
            }

        }
    }
}
