using System;

namespace InheritanceExample.Rabbits
{
    class HomeRabbit : Rabbit
    {
        public int FeedingCapacity { get; set; }

        public override void WhatIsYourHairColor()
        {
            Console.WriteLine("My color is Black");
        }
    }
}
