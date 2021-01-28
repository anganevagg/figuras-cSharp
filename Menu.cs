using System;

namespace Figures
{
    class Menu
    {
        string[] options;
        public Menu(string[] options){
            Console.Clear();
            Console.WriteLine("Cálculo del área de figuras gemétricas");
            this.options=options;
        }
        public int show(){
            Console.WriteLine("Elija una opción\n");
            int selection=0;
            while(selection<1 || selection>this.options.Length+1){
                for(int i = 0; i < this.options.Length; i++){
                    Console.WriteLine("{0} {1}", i+1, this.options[i]);
                }
                selection = Convert.ToInt32(Console.ReadLine());
            }
            return selection;
        }
    }
}
