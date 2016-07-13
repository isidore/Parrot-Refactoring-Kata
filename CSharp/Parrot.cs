using System;

namespace parrot
{
    public abstract class Parrot
    {
      

        public static Parrot CreateParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                case ParrotTypeEnum.AFRICAN:
                    return new AfricanParrot(numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return new NorwegianBlueParrot(isNailed, voltage);
                default:

                    return null;
            }
        }

        public abstract double GetSpeed();

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}