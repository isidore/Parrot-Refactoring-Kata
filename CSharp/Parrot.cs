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
}
