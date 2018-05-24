using System;

namespace OOPExample
{
    class SquareGenerator : IGenerator
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Square), random.GetDouble(1.0, 100)) as Figure;
        }
    }
}
