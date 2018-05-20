using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPExample
{
    class ContentGenerator : IContentGenerator
    {
        IFigureListGenerator listGenerator;
        IGrouping group;
        IPairsList pairs;
        List<Figure> Figures;

        public ContentGenerator()
        {
            listGenerator = Program.container.GetInstance<IFigureListGenerator>();//int.Parse(args[0])
            Figures = listGenerator.GenerateList() as List<Figure>;

            group = Program.container.GetInstance<IGrouping>();

            pairs = new Pairs(20, FiguresListGenerator.GetMax(Figures));//-------1
        }

        object IContentGenerator.GenerateContent()
        {
            return group.Grouping(Figures).Zip(pairs.GetPairsList(), (first, second) 
                => new Tuple<List<Figure>, (double Min, double Max)>(first, second)) as object;
        }
    }
}
