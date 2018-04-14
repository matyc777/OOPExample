using System;
using System.Collections;
using System.Collections.Generic;

namespace OOPExample
{
    class Pairs : IEnumerator
    {
        List<(double Min, double Max)> pairs;
        int position = -1;

        public Pairs(int Number, double Max)
        {
            double step = Max / Number;
            pairs = new List<(double Min, double Max)>();
            (double Min, double Max) pair = (0, step);
            while (pair.Max <= Max)
            {
                pairs.Add(pair);
                pair.Min += step;
                pair.Max += step;
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < pairs.Capacity);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public (double Min, double Max) Current
        {
            get
            {
                try
                {
                    return pairs[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public List<(double Min, double Max)> GetPairs
        {
            get { return pairs; }
        }
    }
}
