using System;
using InheritanceExample.Dogs;
using InheritanceExample.Rabbits;

namespace InheritanceExample
{
    class InheritanceExample
    {
        static void Main()
        {
            Dog rex = new Labrador();

            Dog persi = new EnglishPointer();

            rex.Name = "Rex";
            persi.Name = "Persi";
            PrintDogInfo(rex);
            PrintDogInfo(persi);

            /*
            Rabbit aaa = new Rabbits.Rabbit();
            Rabbit bbb = new HomeRabbit();
            */


            //aaa.WhatIsYourHairColor();
            //bbb.WhatIsYourHairColor();
            /*
            Dog betty = new EnglishPointer();
            betty.ProduceSound();

            Dog persi = new Labrador();
            persi.ProduceSound();

            Labrador a = new Dog();
            */

            /*
            Animal minka = new Rabbit();
            minka.ProduceSound();
            */
            /*
            EnglishPointer sharo = new EnglishPointer();
            sharo.Name = "Sharo";

            Labrador mitko = new Labrador();
            mitko.Name = "Mitko";

            PrintDogInfo(sharo);
            PrintDogInfo(mitko);
            */
        }

        static void PrintDogInfo(Dog dog)
        {
            dog.SayYourName();
            
            if (dog is EnglishPointer)
            {
                ((EnglishPointer)dog).SayHowBeautifulYouAre();
            }
            else if (dog is Labrador)
            {
                (dog as Labrador).SayHowSmartYouAre();
            }
        }
    }
}
