﻿using System;

class Program
{
    static void Main()
    {
        int val; // uninitialized variable
        refMethod(out val);
        Console.WriteLine(val);
        Console.ReadLine();
    }

    static void refMethod(ref int i)
    {
        i = i + 1;
    }
}