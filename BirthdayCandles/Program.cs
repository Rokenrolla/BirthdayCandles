
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {

        int n = ar.Length;
        int contor = 0;
        Int64 max = -900000000000000000;
        for (int i = 0; i < n; i++)
            if (ar[i] > max)
            {
                max = ar[i];
            }
        for (int i = 0; i < n; i++)
            if (ar[i] == max) contor = contor + 1;

        return contor;

    }

    static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);
        Console.WriteLine(result);
    }
}