namespace CSharpLearning
{
    class DataType
    {
        public void Display()
        {
            double d = 5.55426315894253155584;
            double d1 = 5.55426315894253155584d;
            decimal d2 = 5.55426315894253155584m;
            double d3 = 5.55426315894253155584f;
            float f = 5.55426315894253155584f;
            //Console.WriteLine(d);
            Console.WriteLine("by default d is double data type: {0}", d);
            Console.WriteLine("d1 is double data type: {0}", d1);
            Console.WriteLine("d2 is decimal data type: {0}", d2);
            Console.WriteLine("d3 is double data type: {0}", d3);
            Console.WriteLine("f is float data type: {0}", f);
        }
    }
}