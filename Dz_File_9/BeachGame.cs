﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_File_9
{
    public class BeachGame : IGame
    {
        public void Play(string teamName)
        {
            Console.WriteLine($"{teamName} играет в 'Пляж'.");
        }
    }
}
