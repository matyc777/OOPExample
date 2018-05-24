using System;
using System.Collections;
using System.Collections.Generic;

namespace OOPExample
{
    class Pairs : IEnumerator, IPairsList
    {
        List<(double Min, double Max)> pairsList;
        int position = -1;
        int Number;

        public Pairs(int Number)
        {
            this.Number = Number;
        }

        List<(double Min, double Max)> IPairsList.GetPairsList(double Max)
        {
            double step = Max / Number;
            pairsList = new List<(double Min, double Max)>();
            (double Min, double Max) pair = (0, step);
            while (pair.Max <= Max)
            {
                pairsList.Add(pair);
                pair.Min += step;
                pair.Max += step;
            }
            return pairsList;
        }

        public bool MoveNext()
        {
            position++;
            return (position < pairsList.Capacity);
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
                    return pairsList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
