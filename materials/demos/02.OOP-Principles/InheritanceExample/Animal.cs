using System;

namespace InheritanceExample
{
    public abstract class Animal
    {
        private string name;

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public abstract void ProduceSound();

    }
}
