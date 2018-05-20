using StructureMap;

namespace OOPExample
{
    class ContainerClass
    {
        public static Container GenerateContainer(int NumberOfFigures, int NumberOfGroups)
        {
            var container = new Container(_ =>
            {
                _.For(typeof(IGenerator<Circle>)).Use(typeof(CircleGenerator<Circle>));
                _.For(typeof(IGenerator<Rhombus>)).Use(typeof(RhombusGenerator<Rhombus>));
                _.For(typeof(IGenerator<Square>)).Use(typeof(SquareGenerator<Square>));
                _.For(typeof(IFigureListGenerator)).Use(typeof(FiguresListGenerator)).Ctor<int>().Is(NumberOfFigures);
                _.For(typeof(IContentGenerator)).Use(typeof(ContentGenerator));//***
                _.For(typeof(IGrouping)).Use(typeof(Group)).Ctor<int>().Is(NumberOfGroups);
                _.For(typeof(ITextGenerator)).Use(typeof(EnglishTextGenerator));
                _.For(typeof(IRandom)).Use(typeof(RandomValue));
                _.For(typeof(ISort)).Use(typeof(SortFigures));
                //_.For(typeof(IPairsList)).Use(typeof(Pairs)).Ctor<int>().Is(NumberOfGroups);
                //_.For(typeof(IGenerator)).Use(typeof());
            }
            );
            return container;
        }
    }
}
