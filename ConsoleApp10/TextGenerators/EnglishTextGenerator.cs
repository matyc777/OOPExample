using System;
using System.Collections.Generic;

namespace OOPExample
{
    class EnglishTextGenerator : ITextGenerator
    {
        List<string> ITextGenerator.GenerateText(IEnumerable<Tuple<List<Figure>, (double Min, double Max)>> Groups)
        {
            List<string> Text = new List<string>();
            foreach (Tuple<List<Figure>, (double Min, double Max)> tuple in Groups)
            {
                Text.Add(string.Format("From: {0} to: {1}", tuple.Item2.Min, tuple.Item2.Max));
                if (tuple.Item1.Count == 0) Text.Add("No figures");
                else
                {
                    foreach (Figure fg in tuple.Item1)
                    {
                        Text.Add(fg.ToString());
                    }
                }
            }
            return Text;
        }
    }
}
