using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPExample
{
    class FullListGenerator : IListGenerator
    {
        List<Figure> Figures;
        int NumberOfFigures;
        int NumberOfGroups;

        public FullListGenerator(int NumberOfFigures, int NumberOfGroups)
        {
            this.NumberOfFigures = NumberOfFigures;
            this.NumberOfGroups = NumberOfGroups;
        }

        object IListGenerator.ListGenerate()
        {
            IListGenerator list = new FiguresList(NumberOfFigures);
            Figures = list.ListGenerate() as List<Figure>;
            IGrouping group = new Group();
            List<List<Figure>> groups = group.Grouping(NumberOfGroups, Figures);
            Pairs pairs = new Pairs(NumberOfGroups, FiguresList.GetMax(Figures));
            return groups.Zip(pairs.GetPairs, (first, second) => new Tuple<List<Figure>, (double Min, double Max)>(first, second)) as object;
        }
    }
}
