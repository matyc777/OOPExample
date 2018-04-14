using System;

namespace OOPExample
{
    class SquareGenerator : IGenerator
    {
        IRandom rd = new RandomValue();
        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Square), rd.GetDouble(1.0, 100)) as Figure;
        }
    }
}
