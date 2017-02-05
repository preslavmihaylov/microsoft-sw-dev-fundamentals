using System;

namespace InheritanceExample.Dogs
{
    public enum HairColor
    {
        Orange,
        Yellow,
        White,
        WhiteAndBlack,
        Black
    }

    public class Dog : Animal
    {
        private HairColor color;

        public HairColor Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public void SayYourName()
        {
            Console.WriteLine("My name is " + this.Name);
        }
        
        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }    

        public virtual void LookCute()
        {
            Console.WriteLine("I am very cute");
        }
    }
}
