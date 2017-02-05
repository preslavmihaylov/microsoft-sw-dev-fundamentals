using System;
using DiabloExample.Interfaces;

namespace DiabloExample.Weapons
{
    class WandOfPower : IMagicWand
    {
        public WandOfPower()
        {
            this.SpellPower = 10;
            this.Name = "Wand of power";
        }

        public string Name
        {
            get; private set;
        }

        public int SpellPower
        {
            get; private set;
        }

        public void CastSpell()
        {
            Console.WriteLine("I hit you with a fireball of damage " + this.SpellPower);
        }
    }
}
