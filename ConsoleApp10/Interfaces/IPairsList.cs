using System.Collections.Generic;

namespace OOPExample
{
    interface IPairsList
    {
        List<(double Min, double Max)> GetPairsList(double Max);
    }
}
