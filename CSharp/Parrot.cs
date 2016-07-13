using System;

namespace parrot
{
    public class Parrot
    {
        protected double _voltage;
        protected bool _isNailed;
        private readonly Parrot other;
        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            other = CreateParrot(type, numberOfCoconuts, voltage, isNailed);

        }

        protected Parrot()
        {
        }

        private Parrot CreateParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot( isNailed, voltage);
                default:

                    return null;
            }
        }
        
        public virtual  double GetSpeed()
        {

                    return other.GetSpeed();
        }

        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

       

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }

    public class NorwegianBlueParrot : Parrot
    {
        public NorwegianBlueParrot(bool isNailed, double voltage)
        {
            this._isNailed = isNailed;
            this._voltage = voltage;
        }

        public override double GetSpeed()
        {
            return (_isNailed) ? 0 : GetBaseSpeed(_voltage);
        }
    }

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

    public class EuropeanParrot : Parrot
    {
        override  public double GetSpeed()
        {
           return  GetBaseSpeed();
        }
    }
}
