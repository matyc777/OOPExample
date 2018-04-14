using System.Collections.Generic;

namespace OOPExample
{
    class FiguresList : IListGenerator
    {
        List<IGenerator> Generators = new List<IGenerator>();
        List<Figure> Figures = new List<Figure>();
        IRandom rd = new RandomValue();
        int Number;

        public FiguresList(int Number)
        {
            this.Number = Number;
        }

        object IListGenerator.ListGenerate()
        {
            Generators.Add(new CircleGenerator());
            Generators.Add(new SquareGenerator());
            Generators.Add(new RhombusGenerator());
            for (int i = 0; i < Number; i++)
            {
                Figures.Add(Generators[rd.GetInt(0, 2)].Generate());
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

        public List<Figure> GetList
        {
            get { return Figures; }
        }
    }
}
