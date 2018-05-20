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
            
            try
            { 
                IContentGenerator content = new ContentGenerator();

                ITextGenerator Text = container.GetInstance<ITextGenerator>();

                FileOutput.WriteFile(Text.GenerateText(content.GenerateContent() as IEnumerable<Tuple<List<Figure>, (double Min, double Max)>>));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
