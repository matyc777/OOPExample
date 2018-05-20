using System;

namespace OOPExample
{
    class RhombusGenerator<T> : IGenerator<T>
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator<T>.Generate()
        {
            return Activator.CreateInstance(typeof(T), random.GetDouble(1.0, 100), random.GetInt(1, 89)) as Figure;
        }
    }
}
/*class RhombusGenerator : IGenerator
    {
        IRandom random = Program.container.GetInstance<IRandom>();

        Figure IGenerator.Generate()
        {
            return Activator.CreateInstance(typeof(Rhombus), random.GetDouble(1.0, 100), random.GetInt(1, 89)) as Figure;
        }
    }
 */
