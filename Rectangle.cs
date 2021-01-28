using System;

namespace Figures
{
    class Circle
    {
        private int radious;
        public Circle(){
            Console.Clear();
            Console.WriteLine("Cálculo del área de un rectángulo\n");
        }
        public void getArea(){
            Console.Write("Ingresa el radio: ");
            this.radious = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El área del triángulo es {0}cm²", (this.radious*Math.PI));
        }
    }
    class Rectangle
    {
        private int width;
        private int height;
        public Rectangle(){
            Console.Clear();
            Console.WriteLine("Cálculo del área de un rectángulo\n");
        }
        public void getArea(){
            Console.Write("Ingresa la base: ");
            this.width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa la altura: ");
            this.height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El área del triángulo es {0}cm²", (this.width*this.height));
        }
    }
}
