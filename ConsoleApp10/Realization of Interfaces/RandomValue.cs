using System;

namespace OOPExample
{
    class RandomValue : IRandom
    {
        private static readonly Random rnd = new Random();
        private static readonly object syncLock = new object();

        int IRandom.GetInt(int MinValue, int MaxValue)
        {
            lock (syncLock)
            {
                return rnd.Next(MinValue, MaxValue + 1);
            }
        }

        double IRandom.GetDouble(double MinValue,double MaxValue)
        {
            lock (syncLock)
            {
                return rnd.NextDouble() * (MaxValue - MinValue) + MinValue;
            }
        }

    }
}
