using System.Collections.Generic;

namespace OOPExample
{
    class SortFigures : ISort
    {
        void ISort.Sort(List<Figure> list)
        {
            var temp = list[0];
            int item;
            for (int counter = 1; counter < list.Count; counter++)
            {
                temp = list[counter];
                item = counter - 1;
                while (item >= 0 && list[item].area() > temp.area())
                {
                    list[item + 1] = list[item];
                    list[item] = temp;
                    item--;
                }
            }
        }
    }
}
