using System;
using System.Collections.Generic;
using StructureMap;

namespace OOPExample
{
    class Program
    {
        static public IContainer container;

        static void Main(string[] args)//количество фигур, количество групп
        {
            container = ContainerClass.GenerateContainer(int.Parse(args[0]), int.Parse(args[1]));

            Console.WriteLine("Press Spacebar for .html output, other for .txt");

            ConsoleKeyInfo key = Console.ReadKey(false);

            if (key.Key == ConsoleKey.Spacebar)
            {
                container.Configure(_ =>
                {
                    _.For(typeof(IOutput)).Use(typeof(HtmlFileOutput));
                });
            }
            else
            {
                container.Configure(_ =>
                {
                    _.For(typeof(IOutput)).Use(typeof(TextFileOutput));
                });
            }

            try
            {
                IContentGenerator content = container.GetInstance<IContentGenerator>();

                ITextGenerator Text = container.GetInstance<ITextGenerator>();

                IOutput fileOutput = container.GetInstance<IOutput>();

                fileOutput.Write(Text.GenerateText(content.GenerateContent() as IEnumerable<Tuple<List<Figure>, (double Min, double Max)>>));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
