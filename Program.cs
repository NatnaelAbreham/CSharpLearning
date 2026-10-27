// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(5 + 5);


///////////
/// the method can be above or below the calling variable it does not matter
Console.WriteLine(add(5, 5));
 int add(int a, int b)
{
    return a + b;
}

Console.WriteLine(add(5, 5));


//second for reuse the method it is better to use a class
int result = Math.Add(5, 5);
Console.WriteLine(result);
class Math
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}