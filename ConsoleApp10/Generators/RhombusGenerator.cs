using System;

namespace OOPExample
{
    class RhombusGenerator : IGenerator
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Rhombus), random.GetDouble(1.0, 100), random.GetInt(1, 89)) as Figure;
        }
    }
}
