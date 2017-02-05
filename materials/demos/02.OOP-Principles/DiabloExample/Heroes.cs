using System;
using DiabloExample.Interfaces;

namespace DiabloExample
{
    public abstract class Hero
    {
        public abstract void SayYourClassName();
    }

    public class Barbarian : Hero
    {
        private IHeavyWeapon weapon;

        public override void SayYourClassName()
        {
            Console.WriteLine("I am a great Barbarian");
        }

        public void Equip(IHeavyWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void WhatsYourWeapon()
        {
            Console.WriteLine(this.weapon.Name);
        }
    }

    public class Paladin : Hero
    {
        public override void SayYourClassName()
        {
            Console.WriteLine("I am a noble Paladin");
        }
    }

    public class Sorceress : Hero
    {
        private IMagicWand wand;

        public override void SayYourClassName()
        {
            Console.WriteLine("I am a sexy sorceress");
        }

        public void EquipMagicWand(IMagicWand wand)
        {
            this.wand = wand;
        }

        public void WhatsYourWeapon()
        {
            Console.WriteLine(this.wand.Name);
        }
    }
}
