using System;

namespace parrot
{
    public class Parrot
    {
        readonly ParrotTypeEnum _type;
        readonly int _numberOfCoconuts;
        protected double _voltage;
        readonly bool _isNailed;
        private readonly Parrot other;
        public Parrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            other = CreateParrot(type, numberOfCoconuts, voltage, isNailed);

            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed; 
        }

        protected Parrot()
        {
        }

        private Parrot CreateParrot(ParrotTypeEnum type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return new EuropeanParrot();
                case ParrotTypeEnum.AFRICAN:
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                default:

                    return null;
            }
        }
        
        public virtual  double GetSpeed()
        {
            switch (_type)
            {
                case ParrotTypeEnum.EUROPEAN:
                    return other.GetSpeed();
                case ParrotTypeEnum.AFRICAN:
                    return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
                case ParrotTypeEnum.NORWEGIAN_BLUE:
                    return (_isNailed) ? 0 : GetBaseSpeed(_voltage);
            }

            throw new Exception("Should be unreachable");
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        private double GetLoadFactor()
        {
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
            return 12.0;
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
