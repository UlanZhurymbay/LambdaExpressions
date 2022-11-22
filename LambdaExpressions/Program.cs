// See https://aka.ms/new-console-template for more information

using LambdaExpressions.Models;

MyClass myClass = new MyClass("Ulan");
MyClass myClass2 = null;
Console.WriteLine(myClass.AnyMethod(m => m.Name == "Ulan"));
Console.WriteLine(myClass.AnyMethod(m => m.Name == "Ula"));
Console.WriteLine(myClass.AnyMethod());
Console.WriteLine(myClass2.AnyMethod());

