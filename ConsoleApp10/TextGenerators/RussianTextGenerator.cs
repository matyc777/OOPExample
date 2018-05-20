using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class RussianTextGenerator : ITextGenerator
    {
        List<string> ITextGenerator.GenerateText(IEnumerable<Tuple<List<Figure>, (double Min, double Max)>> Groups)
        {
            List<string> Text = new List<string>();

            foreach (Tuple<List<Figure>, (double Min, double Max)> tuple in Groups)
            {
                Text.Add(string.Format("От: {0} до: {1}", tuple.Item2.Min, tuple.Item2.Max));
                if (tuple.Item1.Count == 0) Text.Add("Нет фигур");
                else
                {
                    foreach (Figure fg in tuple.Item1)
                    {
                        if (fg.GetType() == typeof(Circle))
                        {
                            Text.Add(string.Format("Круг, {0}", fg.area()));
                        }
                        else if (fg.GetType() == typeof(Rhombus))
                        {
                            Text.Add(string.Format("Ромб, {0}", fg.area()));
                        }
                        else if (fg.GetType() == typeof(Square))
                        {
                            Text.Add(string.Format("Квадрат, {0}", fg.area()));
                        }
                    }
                }
            }
            return Text;
        }
    }
}
