﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
   public  class Cat 
    {
        Butt butt = new();
        private readonly MeowBox meowBox = new MeowBox();
        private readonly string name = "Kitty";
        public void Poop()
        {
            butt.Poop();
        }
        public void Meow()
        {
            meowBox.Meow(name);
        }
    }
}
