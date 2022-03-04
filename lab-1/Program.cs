using System;
using System.Runtime.InteropServices;

public class ColourValidator
{
    [DllImport("/Users/egorsergeev/RiderProjects/lab-1/Csharp_1/libCsharp_interop1.dylib", EntryPoint = "sum")]
    private static extern int Sum(int a, int b);

    [DllImport("/Users/egorsergeev/RiderProjects/lab-1/Csharp_1/libCsharp_interop1.dylib", EntryPoint = "mult")]
    private static extern int Mult();

    public static void Main(string[] args)
    {
        Console.WriteLine(Sum(1, 2) + "\n");
        
        Console.WriteLine(Mult());
    }
}
