using System;
using System.Collections.Generic;

namespace OOPExample
{
    interface ITextGenerator
    {
        List<string> GenerateText(IEnumerable<Tuple<List<Figure>, (double Min, double Max)>> Groups);
    }
}
