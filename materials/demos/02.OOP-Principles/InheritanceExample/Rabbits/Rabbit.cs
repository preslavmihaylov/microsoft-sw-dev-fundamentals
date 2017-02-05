using System;

namespace InheritanceExample.Rabbits
{
    class Rabbit : Animal
    {
        public double Speed { get; set; }

        public override void ProduceSound()
        {
            Console.WriteLine("MnmnMnmnM");
        }

        public virtual void WhatIsYourHairColor()
        {
            Console.WriteLine("White");
        }
    }
}
