using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
    The variables in C#, are categorized into the following types −

        Value types  ==. all primitive data type
        Reference types
        Pointer types
 

            Value Type :- Value type variables can be assigned a value directly. They are derived from the class System.ValueType.
                    The value types directly contain data. 
                    Some examples are int, char, and float, which stores numbers, alphabets, and floating point numbers,
                    respectively. When you declare an int type, the system allocates memory to store the value.


            Reference Type:- The reference types do not contain the actual data stored in a variable, 
                             but they contain a reference to the variables
                             In other words, they refer to a memory location. Using multiple variables,
                             the reference types can refer to a memory location. 
                             If the data in the memory location is changed by one of the variables,
                             the other variable automatically reflects this change in value. 
                             Example of built-in reference types are: object, dynamic, and string

              pointer :-  it special variable which stores memory address of another type.
                          pointers in C# have the same capabilities as the pointers in C or C++.

                        
 *  
 */
namespace _02_DataType
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Display size of value type in byte");
            //1
            showSizeOfValueTypeinByte();
            //2
            showReferenceType();
            showBoxingUnboxingConcept();
            //3 Pointer type
            showpointerType();
            Console.ReadLine();
        }
        public static void showSizeOfValueTypeinByte()
        {
            Console.WriteLine($"size of sbyte {sizeof(sbyte)} "); // range -128 to 127
            Console.WriteLine($"size of byte {sizeof(byte)} " ); //  0 to 255.
           


            Console.WriteLine($"size of bool {sizeof(bool)} ");
            Console.WriteLine($"size of char {sizeof(char)} ");

            //== integer
            Console.WriteLine($"size of short {sizeof(short)} "); // this int same like in C#  -32767 to +32767

            Console.WriteLine($"size of ushort {sizeof(ushort)} "); // unsigned short having positive value only +65535

            Console.WriteLine($"size of int {sizeof(int)} ");

            Console.WriteLine($"size of long {sizeof(long)} ");
            Console.WriteLine($"size of ulong {sizeof(ulong)} ");//positive long only


            //===
            Console.WriteLine($"size of float {sizeof(float)} ");
            Console.WriteLine($"size of double {sizeof(double)} ");
            Console.WriteLine($"size of decimal {sizeof(decimal)} ");

       
         
        }
        public static void showReferenceType()
        {
            //object type ==> it base type for all type in cts, it is baseclass, system.object. for this type checking happening at compile time
            Console.WriteLine("Declaring Object type");
            object obj;
            obj= 100;
            Console.WriteLine(obj);

            //dynamic type ==> same like object type but type checking happening at run time
            Console.WriteLine("Declaring Dyanmic type");

            dynamic dobj;
            dobj = 200;
            Console.WriteLine(dobj);

            //string ==> it allows you to assign any string value to the variables.
            Console.WriteLine("Declaring String type");
            String str = "Hello C#";
            Console.WriteLine(str);

            //The user-defined reference types are: class, interface, or delegate
        }

        public static void showBoxingUnboxingConcept()
        {
            // value to reference type is boxing
            object obj;
            obj = 100; //boxing
            Console.WriteLine("Boxing");
            Console.WriteLine(obj);

            // reference to value type is unboxing
            int number = (int)obj; ///this is unboxing
            Console.WriteLine("After UnBoxing");
            Console.WriteLine(number);

            //for better practice try to avoid it since it will bring overhead not good practice.
        }

        public  static void showpointerType()
        {
            //general syntax type* identifier;
            int number = 100;        
            //int* intpointer = &number;     
        }
    }
}
