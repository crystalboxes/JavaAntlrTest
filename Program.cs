﻿using Antlr4.Runtime;
using JavaAST.Helpers;
using JavaAST.AntlrParser;

public static class Program
{
    public static void Main()
    {
        // var def = TreeLoaderHelper.FromFile("Tests/HelloWorld.java");
        var def = TreeLoaderHelper.FromSource(@"class A {
            class B {}
        }");

        Console.WriteLine("heloo world ");
    }
}
