using System;

namespace Figures
{
    class Program{
        static void Main(string[] args){
            string[] options = {"Triángulo", "Rectángulo", "Círculo", "Salir"};
            int selection;
            Menu menu=new Menu(options);
            selection = menu.show();
            switch(selection){
                case 1:
                    Triangle triangle = new Triangle();
                    triangle.getArea();
                    break;
                case 2:
                    Rectangle rectangle = new Rectangle();
                    rectangle.getArea();
                    break;
                case 3:
                    Circle circle = new Circle();
                    circle.getArea();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Hasta la próxima");
                    break;
            }
        }
    }
}
