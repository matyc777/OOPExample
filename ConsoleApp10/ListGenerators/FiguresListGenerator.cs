using System.Collections.Generic;

namespace OOPExample
{
    class FiguresListGenerator : IFigureListGenerator
    {
        List<IGenerator> Generators;
        public List<Figure> Figures { get; set; }
        IRandom random;
        int Number;

        public FiguresListGenerator(int Number)
        {
            this.Number = Number;
            random = Program.container.GetInstance<IRandom>();
        }

        object IFigureListGenerator.GenerateList()
        {
            Generators = new List<IGenerator>();
            Figures = new List<Figure>();
            Generators.Add(new CircleGenerator());
            Generators.Add(new SquareGenerator());
            Generators.Add(new RhombusGenerator());
            for (int i = 0; i < Number; i++)
            {
                Figures.Add(Generators[random.GetInt(0, 2)].Generate());
            }
            return Figures as object;
        }

        static public double GetMax(List<Figure> list)
        {
            double Max = 0;
            foreach (Figure fg in list)
            {
                if (fg.area() > Max) Max = fg.area();
            }
            return Max;
        }
    }
}
