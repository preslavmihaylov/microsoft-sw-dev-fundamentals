using System;
using DiabloExample.Interfaces;

namespace DiabloExample.Weapons
{
    class BigSword : IHeavyWeapon
    {
        private int damage;
        
        public BigSword()
        {
            this.damage = 20;
            this.Speed = 10;
            this.Name = "Big Sword";
        }

        public string Name { get; private set; }

        public int Speed
        {
            get; private set;
        }

        public int HitSomeone()
        {
            return this.damage;
        }
    }
}
