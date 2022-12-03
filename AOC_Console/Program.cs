using AOC2022lib;
using System;

namespace AOC_Console  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Advent of Code!");

            AOC2022lib.Day01 aoc2022d1 = new AOC2022lib.Day01();
            //Console.WriteLine("2022 Day 01 A:  {0}", aoc2022d1.A());
            Console.WriteLine("2022 Day 01 B:  {0}", aoc2022d1.B());


            
            Console.ReadLine();
        }
    }
}