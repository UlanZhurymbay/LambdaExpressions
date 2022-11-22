namespace LambdaExpressions.Models;

delegate int MyHandler(int i);

public delegate TResult ActionAny<in T, out TResult>(T t);
public class MyClass
{
    public MyClass()
    {
        
    }
    public MyClass(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    
    public void Run(int a)
    {
        var myClasses = new List<MyClass>();
        MyHandler handler = delegate(int i){
            Console.WriteLine(i * i);
            return i * i;
        };
        handler += Method;

        Console.WriteLine(handler(a));
    }

    private int Method(int i)
    {
        i += 5;
        return i;
    }
}

public static class Extensions
{
    public static bool AnyMethod(this MyClass myClass, ActionAny<MyClass, bool> actionAny)
    {
        if (myClass is null)
        {
            throw new ArgumentException();
        }
        return actionAny(myClass);
    }
    public static bool AnyMethod(this MyClass? myClass)
    {
        return myClass is not null;
    }
}