using System;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!. Darwin's programming");

            // Variables

            double height = 181;
            int age = 20;
            string nombre = "Darwin Quiñones Sanchez";
            string placeHolderText = "The information you requested is: ";
            string information = placeHolderText + height + " "+ age + " " + nombre;
            Console.WriteLine(information);
        }
    }
}
