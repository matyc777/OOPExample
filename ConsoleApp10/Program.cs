using System;
using System.Collections.Generic;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)//количество фигур, количество групп
        {
            try
            {
                IListGenerator list = new FullListGenerator(int.Parse(args[0]), int.Parse(args[1]));
                ITextGenerator Text = new EnglishTextGenerator();
                FileOutput.WriteFile(Text.GenerateText(list.ListGenerate() as IEnumerable<Tuple<List<Figure>, (double Min, double Max)>>));
            }
            catch
            {
                Console.WriteLine("Введены некорректные параметры");
            }
        }
    }
}
