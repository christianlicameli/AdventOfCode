using AOC2022lib;
using System;

namespace AOC_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Advent of Code!");

            //AOC2022lib.Day01 aoc2022d1 = new();
            //Console.WriteLine("2022 Day 01 A:  {0}", aoc2022d1.A());
            //Console.WriteLine("2022 Day 01 B:  {0}", aoc2022d1.B());

            //AOC2022lib.Day02 aoc2022d2 = new();
            //Console.WriteLine("2022 Day 02 A:  {0}", aoc2022d2.A());  
            //Console.WriteLine("2022 Day 02 B:  {0}", aoc2022d2.B());

            AOC2022lib.Day03 aoc2022d3 = new();
            Console.WriteLine("2022 Day 03 A:  {0}", aoc2022d3.A());  //15410 too hign
            //Console.WriteLine("2022 Day 03 B:  {0}", aoc2022d3.B());



            Console.ReadLine();
        }
    }
}