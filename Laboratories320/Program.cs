﻿using Laboratories320.Abdrakov.ThreadLock;
using Laboratories320.Abdrakov.Threads;
using System;

namespace Laboratories320
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leave hope behind all who enters here...");
            Console.WriteLine();
            ThreadLock.PseudoMain();
        }
    }
}
