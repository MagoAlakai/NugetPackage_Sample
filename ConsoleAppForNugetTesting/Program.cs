// See https://aka.ms/new-console-template for more information
using NugetPackage_Sample;

Console.WriteLine("Hello, World!");

TestClass testClass = new() { Test = true };

Console.WriteLine(testClass.Test);
Console.ReadLine();
