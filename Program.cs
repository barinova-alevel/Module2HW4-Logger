﻿using System;

namespace Logger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var starter = new Starter();
            starter.Run();

            Console.ReadKey();
        }
    }
}
