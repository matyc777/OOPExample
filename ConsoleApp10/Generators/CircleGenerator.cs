using System;

namespace OOPExample
{
    class CircleGenerator : IGenerator
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Circle), random.GetDouble(1.0, 50)) as Figure;
        }
    }
}
