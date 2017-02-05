using System;

namespace DiabloExample.Interfaces
{
    public interface IHeavyWeapon
    {
        string Name { get; }

        int Speed { get; }

        int HitSomeone();
    }
}
