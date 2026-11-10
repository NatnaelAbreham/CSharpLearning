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
        }
    }
}