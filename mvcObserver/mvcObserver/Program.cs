﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Cijfers getal = new Cijfers();
            getal.attach(new LetterView());

        }
    }
}
