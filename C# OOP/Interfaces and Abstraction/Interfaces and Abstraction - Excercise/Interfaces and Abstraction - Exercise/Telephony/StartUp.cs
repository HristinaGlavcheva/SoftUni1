﻿using System;
using Telephony.Contracts;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Run();
        }
    }
}