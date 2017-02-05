using System;

namespace DiabloExample.Interfaces
{
    public interface IMagicWand
    {
        string Name { get; }

        int SpellPower { get; }

        void CastSpell();
    }
}
