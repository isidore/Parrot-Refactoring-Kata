namespace parrot
{
    public class EuropeanParrot : Parrot
    {
        override  public double GetSpeed()
        {
            return  GetBaseSpeed();
        }
    }
}