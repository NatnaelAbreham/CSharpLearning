namespace CSharpLearning
{
    class Constant
    {
        public void Display()
        {
            const string TSEDEY_ACCOUNT = "123456789";
            
            Console.WriteLine(TSEDEY_ACCOUNT);
            Console.WriteLine("additional information", 5+5);
            Console.WriteLine("additional information {0}", 5 + 5);
            // the output is 10 +5 Console.WriteLine("{1} + {0}", 5, 10);
        }
    }
}