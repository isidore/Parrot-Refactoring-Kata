using System;

namespace parrot
{
    public abstract class Parrot
    {
        public abstract double GetSpeed();

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}