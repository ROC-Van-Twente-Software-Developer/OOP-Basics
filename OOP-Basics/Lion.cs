using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Lion : Animal
    {
        // Is leider van groep?
        public bool isAlfa { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
    }
}
