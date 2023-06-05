using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basics
{
    public class Elephant : Animal
    {
        public int Height { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
    }
}
