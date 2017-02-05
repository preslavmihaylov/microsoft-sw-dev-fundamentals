using System;

namespace InheritanceExample.Dogs
{
    class EnglishPointer : Dog
    {
        public void SayHowBeautifulYouAre()
        {
            Console.WriteLine("Yes I am pretty handsome");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof woof");
        }

        public override void LookCute()
        {
            Console.WriteLine("Get out of here noob");
        }

    }
}
