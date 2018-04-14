using System.Collections.Generic;

namespace OOPExample
{
    class Group : IGrouping
    {
        List<List<Figure>> IGrouping.Grouping(int Number, List<Figure> list)
        {
            List<List<Figure>> Array = new List<List<Figure>>();
            List<Figure> arr;
            ISort Heir = new SortFigures();
            Heir.Sort(list);
            double Max = FiguresList.GetMax(list);
            double step = Max / Number;
            (double Min, double Max) pair = (0, step);
            while (pair.Max <= Max)
            {
                arr = new List<Figure>();
                foreach (Figure fg in list)
                {
                    if (fg.area() >= pair.Min && fg.area() <= pair.Max)
                    {
                        arr.Add(fg);
                    }
                }
                Array.Add(arr);
                pair.Min += step;
                pair.Max += step;
            }
            return Array;
        }
    }
}
