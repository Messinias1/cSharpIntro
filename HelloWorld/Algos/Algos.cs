using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Algos
{
    class Algos
    {
        int firstDuplicate(int[] a)
        {
            if (a.Length == a.Distinct().Count())
                return -1;

            HashSet<int> hs = new HashSet<int>();
            foreach (var item in a)
                if (!hs.Add(item))
                    return item;
            return -1;
        }
    }
}
