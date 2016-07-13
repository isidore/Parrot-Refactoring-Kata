using System;

namespace parrot
{
    public class AfricanParrot : Parrot
    {
        protected int _numberOfCoconuts;

        public AfricanParrot(int numberOfCoconuts)
        {
            this._numberOfCoconuts = numberOfCoconuts;
        }
        protected double GetLoadFactor()
        {
            return 9.0;
        }
        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }
}