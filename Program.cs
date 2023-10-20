using System;

namespace ArrayReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] M = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            Divide.ArrayReplace(M, fizz: 3, buzz: 5, s1: "fizz", s2: "buzz");
            Console.WriteLine();
            Divide.ArrayReplace(M, fizz: 3, buzz: 5, muzz: 4, guzz: 7, s1: "fizz", s2: "buzz", s3: "muzz", s4: "guzz");
            Console.WriteLine();
            Divide.ArrayReplaceComplex(M, fizz: 3, buzz: 5, muzz: 4, guzz: 7, s1: "fizz", s2: "muzz", s3: "muzz", s4: "guzz");
            Console.ReadLine();
        }
    }
}
