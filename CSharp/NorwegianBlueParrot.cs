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
            return (_isNailed) ? 0 : GetBaseSpeed(_voltage);
        }
    }
}