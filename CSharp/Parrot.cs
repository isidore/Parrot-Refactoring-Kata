using System;

namespace parrot
{
    public class Parrot
    {
        private readonly Parrot other;

        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            other = CreateParrot(type, numberOfCoconuts, voltage, isNailed);
        }

        protected Parrot()
        {
        }

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

        public virtual double GetSpeed()
        {
            return other.GetSpeed();
        }


        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}