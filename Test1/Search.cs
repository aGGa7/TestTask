using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Search<T> where T : IComparable<T>

	{
		/*бинарный поиск, только для отсортированных массивов, element наш волшебный элемент
		 * также возможно все это реализовать в рекурсивном виде, но он по идеи будет работать медленнее 
		 * */
		public static int BinarySearch(List<T> originalList, T element)
		{
			// return originalList.IndexOf(element); (если не изобретать велосипед)
            if (originalList.Count() > 0)
            {
                var left = 0;
                var right = originalList.Count() - 1;
                while (left < right)
                {
                    var middle = (right + left) / 2;
                    if (element.CompareTo(originalList[middle]) <= 0)
                        right = middle;
                    else left = middle + 1;
                }
                if (element.CompareTo(originalList[right]) == 0)
                    return right; // товернуть индекс элемента 
            }
            return -1; //если элемент не найден то вернуть -1
        }
	}
}
