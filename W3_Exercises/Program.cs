using System;

namespace W3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //This is a single line comment
            /*This is a 
             multi-line comment*/

            //Create a variable named myNum and assign the value 50 to it.

            int myNum = 50;

            //Create a variable named myName and assign the value "John" to it.

            string myName = "John";

            //Display the sum of 5 + 10, using two variables: x and y.

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            //Create an int variable called z, assign x + y to it, and display the result.

            int a = 5;
            int b = 10;
            int c = a + b;
            Console.WriteLine(c);

            //Fill in the missing parts to create three variables of the same type, using a comma-separated list:

            int d = 5, e = 10, f = 2;
            Console.WriteLine(d + e + f);

            //Implicit casting is done automatically when passing a smaller size type to a larger size type:

            int myInt = 9;
            double myDouble = myInt;//automatic casting, int to double
            Console.WriteLine(myDouble);//outputs 9

            //Explicit casting must be done manually by placing the type in parentheses in front of the value:

            double myDoubles = 9.78;
            int myInts = (int)myDoubles;//manual casting; double to int
            Console.WriteLine(myInts);//outputs 9

            //Type Conversion Methods
            //It is also possible to convert data types explicitly by using built -in methods, such as Convert.ToBoolean,
            //Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            int thisInt = 8;
            double thisDouble = 8.98;
            bool myBool = false;

            Console.WriteLine(Convert.ToString(thisInt));
            Console.WriteLine(Convert.ToDouble(thisInt));
            Console.WriteLine(Convert.ToInt32(thisDouble));
            Console.WriteLine(Convert.ToInt32(myBool));
        }
    }
}
