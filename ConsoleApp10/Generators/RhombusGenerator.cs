using System;

namespace OOPExample
{
    class RhombusGenerator : IGenerator
    {
        IRandom rd = new RandomValue();
        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Rhombus), rd.GetDouble(1.0, 100), rd.GetInt(1, 89)) as Figure;
        }
    }
}
