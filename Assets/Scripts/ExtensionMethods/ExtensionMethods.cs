using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.ExtensionMethods
{
    public static class ExtensionMethods
    {
        private static Random random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;

            while (count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                T value = list[k];
                list[k] = list[count];
                list[count] = value;
            }
        }
    }
}
