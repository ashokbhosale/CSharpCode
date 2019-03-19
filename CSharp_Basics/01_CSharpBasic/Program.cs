using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    It is worth to note the following points −

        C# is case sensitive.
        All statements and expression must end with a semicolon (;).
        The program execution starts at the Main method.
        Unlike Java, program file name could be different from the class name.


    C# is an object-oriented programming language. 
    In Object-Oriented Programming methodology, a program consists of various objects that interact with each other
    by means of actions. The actions that an object may take are called methods.
    Objects of the same kind are said to have the same type or, are said to be in the same class.

 */
namespace _01_CSharpBasic // namespace declaration
{
    class recetangle // identifier
    {
        double length; //member variable
        double width;
        public void getdata(double length, double width) //member functions
        {
            this.length = length;
            this.width = width;
        }
        public double getArea()
        {
            return length * width;
        }
    } 
    //class attribute
    class Program // class declaration
    {
        static void Main(string[] args) // main method
        {
            Console.WriteLine("Hello World");
            recetangle obj = new recetangle(); //instantiating the class.
            obj.getdata(100, 120);
            System.Console.WriteLine("Area :" + obj.getArea());
            Console.ReadKey();
        }
    }
}
