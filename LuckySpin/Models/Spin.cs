﻿using System;
namespace LuckySpin.Models
{
    public class Spin
    {
        Random random = new Random();
        private int a, b, c; //instance variables

        //public Player Player { get; set; }
        public Player Player { get; set; }

        public int A
        {
            get
            {
                a = random.Next(10);
                return a;
            }
        }
        public int B
        {
            get
            {
                b = random.Next(10);
                return b;
            }
        }
        public int C
        {
            get
            {
                c = random.Next(10);
                return c;
            }
        }
        //: Create a public getter that makes the decision to display the image or not by returning "block" or "none" for the Razor templates CSS
        public string Display
        {
            get
            {
                if (a == 7 || b == 7 || c == 7)
                {
                    return "block";
                }
                else
                {
                    return "none";
                }
            }
        }
    }

}
