using System;

namespace OOPExample
{
    class CircleGenerator : IGenerator
    {
        IRandom rd = new RandomValue();
        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Circle), rd.GetDouble(1.0, 50)) as Figure;
        }
    }
}
