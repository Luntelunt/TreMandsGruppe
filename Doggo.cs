﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreMandsGruppe
{
    internal class Doggo
    {
        public string name;
        public string race;

        public void PetDogg()
        {
            Console.WriteLine("Good boi! *pet* *pet*");
        }

        public void ShowDoggo()
        {
            string doge = @"
                        |\__/|
                        |o  o|
                        |_O__ \_____
                           |        \
                           |_________|";

            Console.WriteLine(doge);
        }
    }
}
