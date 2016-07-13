using System;

namespace parrot
{
    public class NorwegianBlueParrot : Parrot
    {
        protected double _voltage;
        protected bool _isNailed;

        public NorwegianBlueParrot(bool isNailed, double voltage)
        {
            this._isNailed = isNailed;
            this._voltage = voltage;
        }

        public override double GetSpeed()
        {
            var baseSpeed = Math.Min(24.0, _voltage*GetBaseSpeed());
            return (_isNailed) ? 0 : baseSpeed;
        }
    }
}