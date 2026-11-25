namespace CSharpLearning
{
    class DataTypes
    {
        public void Display()
        {
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
            //int a = 5, b = 10, c = a + b;

            //Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
            float a = 0.1f;
            float b = 0.2f;

            Console.WriteLine(a + b);

            double x = 0.1;
            double y = 0.2;

            Console.WriteLine(x + y);

            decimal p = 0.1m;
            decimal q = 0.2m;

            Console.WriteLine(p + q);

            /* Implicit Casting
Implicit casting is done automatically when passing a smaller size type to a larger size type: */
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble1);   // Outputs 9.78
            Console.WriteLine(myInt1);      // Outputs 9


            /* It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long): */

            int myInt1 = 10;
            double myDouble1 = 5.25;
            bool myBool1 = true;

            Console.WriteLine(Convert.ToString(myInt1));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt1));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble1));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool1));   // convert bool to string


            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("Enter your age:");
            int age12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age12);

            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);/*  */

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;     // 800 (400 + 400)

            /* Assignment operators are used to assign values to variables.

In the example below, we use the assignment operator (=) to assign the value 10 to a variable called x: */


            int x = 10;
            x += 5;

            int x = 5;
            int y = 3;
            Console.WriteLine(x > y); // returns True because 5 is greater than 3

            /* As with comparison operators, you can also test for True or False values with logical operators.

            Logical operators are used to determine the logic between variables or values: 
            Math.Max(x,y)
            The Math.Max(x,y) method can be used to find the highest value of x and y:*/

            Math.Max(5, 10);
            /* Math.Round()
            Math.Round() rounds a number to the nearest whole number:

            Example
             */
            Math.Round(9.99);
            int a = 5, b = 10, c = a + b;

            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);

            double d = 5.55426315894253155584;
            double d1 = 5.55426315894253155584d;
            decimal d2 = 5.55426315894253155584m;
            double d3 = 5.55426315894253155584f;
            float f = 5.55426315894253155584f;
            
            //Console.WriteLine(d);
            Console.WriteLine("by default d is double data type: {0}", d);
            Console.WriteLine("d1 is double data type: {0}", d1);
            /* Console.WriteLine("d2 is decimal data type: {0}", d2);
            Console.WriteLine("d3 is double data type: {0}", d3);
            Console.WriteLine("f is float data type: {0}", f); */

        }
    }
}