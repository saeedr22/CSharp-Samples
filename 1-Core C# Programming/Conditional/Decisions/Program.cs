using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IfElsePatternMatching();
            IfElsePatternMatchingUpdatedInCSharp9();
        }

        static void IfElsePatternMatching()
        {
            Console.WriteLine("===If Else Pattern Matching ===/n");
            object testItem1 = 123;
            object testItem2 = "Hello";
            if (testItem1 is string g)
            {
                Console.WriteLine($"{g} is a string");
            }
            if (testItem1 is int myValue1)
            {
                Console.WriteLine($"{myValue1} is an int");
            }
            if (testItem2 is string myStringValue2)
            {
                Console.WriteLine($"{myStringValue2} is a string");
            }
            if (testItem2 is int myValue2)
            {
                Console.WriteLine($"{myValue2} is an int");
            }
            Console.WriteLine();
        }

        static void IfElsePatternMatchingUpdatedInCSharp9()
        {
            Console.WriteLine("================ C# 9 If Else Pattern Matching Improvements ===============/n");
            object testItem1 = 123;
            Type t = typeof(string);
            char c = 'f';
            //Type patterns
            if (t is Type)
            {
                Console.WriteLine($"{t} is a Type");
            }
            //Relational, Conjuctive, and Disjunctive patterns
            if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
            {
                Console.WriteLine($"{c} is a character");
            };
            //Parenthesized patterns
            if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
            {
                Console.WriteLine($"{c} is a character or separator");
            };
            //Negative patterns
            if (testItem1 is not string)
            {
                Console.WriteLine($"{testItem1} is not a string");
            }
            if (testItem1 is not null)
            {
                Console.WriteLine($"{testItem1} is not null");
            }
            Console.WriteLine();
        }
    }
}
