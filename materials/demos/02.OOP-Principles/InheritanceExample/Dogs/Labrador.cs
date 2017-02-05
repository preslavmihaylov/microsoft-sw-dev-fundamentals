using System;

namespace InheritanceExample.Dogs
{
    class Labrador : Dog
    {
        public void SayHowSmartYouAre()
        {
            Console.WriteLine("Yes I am really smart");
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Djaf Djaf");
        }
    }
}
