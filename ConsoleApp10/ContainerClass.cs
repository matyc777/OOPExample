using StructureMap;

namespace OOPExample
{
    class ContainerClass
    {
        public static Container GenerateContainer(int NumberOfFigures, int NumberOfGroups)
        {
            var container = new Container(_ =>
            {
                _.For(typeof(IFigureListGenerator)).Use(typeof(FiguresListGenerator)).Ctor<int>().Is(NumberOfFigures);
                _.For(typeof(IContentGenerator)).Use(typeof(ContentGenerator));//***
                _.For(typeof(IGrouping)).Use(typeof(Group)).Ctor<int>().Is(NumberOfGroups);
                _.For(typeof(ITextGenerator)).Use(typeof(RussianTextGenerator));
                _.For(typeof(IRandom)).Use(typeof(RandomValue));
                _.For(typeof(ISort)).Use(typeof(SortFigures));
                _.For(typeof(IPairsList)).Use(typeof(Pairs)).Ctor<int>().Is(NumberOfGroups);
            }
            );
            return container;
        }
    }
}
