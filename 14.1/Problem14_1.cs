using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1 {
    public static class Problem14_1 {
        public static int[] GetSortedArrayIntersection(int[] array1, int[] array2) {

            List<int> elements = new List<int>();

            int i = 0;
            int j = 0;
            int? lastElement = null;

            while (i < array1.Length || j < array2.Length) {

                var val1 = i == array1.Length ? (int?)null : array1[i];
                var val2 = j == array2.Length ? (int?)null : array2[j];

                if (val2 == null || val1 < val2) {
                    if (val1 != lastElement) {

                        elements.Add(val1.Value);
                        lastElement = val1;
                    }
                    i++;
                }
                else {
                    if (val2 != lastElement) {

                        elements.Add(val2.Value);
                        lastElement = val2;
                    }
                    j++;
                }
            }

            return elements.ToArray();
        }
        public static int[] GetSortedArrayIntersection1(int[] array1, int[] array2) {
            
            return new HashSet<int>(array1.Concat(array2)).OrderBy(i => i).ToArray();
        }
    }
}
