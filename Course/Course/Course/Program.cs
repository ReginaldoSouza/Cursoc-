using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20 ;

            Console.WriteLine(p);
            string teste = "";
            teste = "A";

            p = new Point();

            Console.WriteLine(p);

        }
    }
}
