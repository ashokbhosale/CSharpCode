using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
   Implicit conversion:- 
   
    − These conversions are performed by C# in a type-safe manner. 
      For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.


    Explicit Conversion:-These conversions are done explicitly by users using the pre-defined functions
    1. (type)
    2. .To<Type>() 
    3. Convert.ToString() 

    Difference 2 and 3 in 3rd If their is any null value then it will automatically handled in 2nd approach nullexception happens
 * 
 * 
 */
namespace _03_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            implictConversionExample();
            ExplicitConversionExample();
            Console.ReadLine();
        }
        public static void implictConversionExample() // so be careful while doing implict conversion
        {
            //upward always pass like int to double
            int number = 10;
            double dbl = number;

            Console.WriteLine($" dbl {dbl}");

            //downward always fails from double to int
            double dbl1 = 53.43;
            Console.WriteLine($" dbl1 {dbl1}");
            //int num = dbl1;  // this throws compile time error
            int num = (int)dbl1;  // this pass but you will loose after precesion data.

            Console.WriteLine($" num {num}");
        }

        public static void ExplicitConversionExample()// for explicit
        {

            // approach =1
            // double dbl1 = 126.773;
            decimal dbl1 = 34.51M;

            Console.WriteLine($" dbl1 {dbl1}");
           // int num = dbl1;  // this throws compile time error
            int num = (int)dbl1;  // this pass but you will loose after precesion data.

            //Console.WriteLine($" num {num}");


            //approach 2
            string strnum = dbl1.ToString()    ;  // this pass but you will loose after precesion data.
            Console.WriteLine($" strnum {strnum}");

            //approach 3
            int num2 = Convert.ToInt32 (dbl1 );  // this pass but you will loose after precesion data.
            Console.WriteLine($" num2 {num2}");


            //to verify difference bw approach 1 and 3  make dbl1= as null; eg double? dbl1 = null;
            //approach will theow System.InvalidOperationException: 'Nullable object must have a value.' 
            //approach 2  will return empty string 3 will return 0

            // approach 3 will round out number  if precision value more than 126.773 then it will round off to 127
            // so for better accuracy use decimal value.  decimal dbl1 = 34.54M;  till 34.50 its taking 34 after >=34.50
            // it taking 35



        }
    }
}
