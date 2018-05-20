using System;

namespace OOPExample
{
    class CircleGenerator<T> : IGenerator<T>
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator<T>.Generate()
        {
            return Activator.CreateInstance(typeof(T), random.GetDouble(1.0, 50)) as Figure;
        }
    }
}
