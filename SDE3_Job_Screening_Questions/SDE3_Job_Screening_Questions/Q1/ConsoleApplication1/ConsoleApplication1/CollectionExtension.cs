using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class CollectionExtension
    {
        public static int Pos(this object obj, params object[] input)
        {
            if (input != null)
            {
                foreach (var item in input.Select((value, index) => new { index, value }))
                    if (obj.Equals(item.value))
                        return item.index;
            }
            return -1;
        }
        public static bool In(this object obj, params object[] input)
        {
            if (input == null)
                return false;

            return input.Any(i => i.Equals(obj));
        }
    }
}
