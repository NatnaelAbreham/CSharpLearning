// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine(5 + 5);

// C# is case sensitive language
// naming conventions 
/*
camelCase  local variables and parameters

example string firstName = "John";
add(firstName, lastName);

PascalCase Typical use: classes, methods, properties, namespaces
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
Name and Age are properties.

*/
using CSharpLearning;
///////////
/// the method can be above or below the calling variable it does not matter
Console.WriteLine(add(5, 5));
 int add(int a, int b)
{
    return a + b;
}

Console.WriteLine(add(5, 5));
Test test = new Test();
test.Display();

//second for reuse the method it is better to use a class
int result = Math.Add(5, 5);
System.Console.WriteLine(result);
class Math
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}