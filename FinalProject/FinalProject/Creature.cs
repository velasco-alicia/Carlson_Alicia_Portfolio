﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject
{
    abstract class Creature
    {
        string name;
        int health;

        public Creature(string _name, int _health)
        {
            name = _name;
            health = _health;
        }

        public int ThrowHand()
        {
            int handTrown = 0;

            Random random = new Random();
            handTrown = random.Next(1, 3);

            switch (handTrown)
            {
                case 1:
                    {
                        Console.WriteLine($"{this.name} has thrown Rock.");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine($"{this.name} has thrown Paper.");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine($"{this.name} has thrown Scissors.");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Valid number was not thrown");
                    }
                    break;
            }

            return handTrown;
        }

    }
}
