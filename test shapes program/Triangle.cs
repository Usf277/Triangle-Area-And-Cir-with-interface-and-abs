using System;
using System.Collections.Generic;
using System.Text;

namespace test_shapes_program
{
    class Triangle:AShape,Shape
    {
        private double l1;
        private double l2;
        private double l3;
        private double baselength;
        private double heigh;
        public double L1
        {
            set { this.l1 = value; }
            get { return this.l1; }
        }
        public double L2
        {
            set { this.l2 = value; }
            get { return this.l2; }
        }
        public double L3
        {
            set { this.l3 = value; }
            get { return this.l3; }
        }
        public double baseLength
        {
            set { this.baselength = value; }
            get { return this.baselength; }
        }
        public double Heigh
        {
            set { this.heigh = value; }
            get { return this.heigh; }
        }
        public Triangle()
        {
            Console.WriteLine("Enter L1");
            L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter L2");
            L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter L3");
            L3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The base length and the heigh : ");
            baseLength = double.Parse(Console.ReadLine());
            Heigh = double.Parse(Console.ReadLine());
        }
        public Triangle(double z)
        {
            
        }
        public override double area()
        {
            return 0.5*(baseLength * Heigh);
        }
        public override double Cir()
        {
            return L1 + L2 + L3;
        }
        void Shape.printProgramJob()
        {
            Console.WriteLine("This Program Is Calc The Area And Cirr Of Triangle");
        }
        public override void PrintCir()
        {
            Console.WriteLine("The Cir Of Triangle Is {0}", Cir());
        }
        public override void printArea()
        {
            Console.WriteLine("The Area Of Triangle Is {0}", area());
        }
    }
}
