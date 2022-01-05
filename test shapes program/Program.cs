using System;

namespace test_shapes_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s3 = new Triangle(2);
            s3.printProgramJob();
            AShape s = new Triangle();
            s.area();
            s.Cir();
            s.PrintCir();
            s.printArea();
            
        }
    }
}
