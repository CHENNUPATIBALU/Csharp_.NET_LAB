using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Drawing_Application
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Base-Draw Method");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
            Console.WriteLine(" ------ ");
            Console.WriteLine(" |    | ");
            Console.WriteLine(" ------ ");

        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
            Console.WriteLine("O");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
            Console.WriteLine("▲");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Square");
            Console.WriteLine(" ---- ");
            Console.WriteLine(" |  | ");
            Console.WriteLine(" ---- ");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape s;
            while (true)
            {
                Console.WriteLine("\nChoose an Option:");
                Console.Write("1: Rectangle\n2: Circle\n3: Triangle\n4: Square\n5: Exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: s = new Rectangle(); s.Draw(); break;
                    case 2: s = new Circle(); s.Draw(); break;
                    case 3: s = new Triangle(); s.Draw(); break;
                    case 4: s = new Square(); s.Draw(); break;
                    case 5: Environment.Exit(0); break;
                }
            }
            Console.ReadLine();
        }
    }
}
