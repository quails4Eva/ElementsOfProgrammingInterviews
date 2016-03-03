using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1 {
    public static class Problem14_1 {
        public static int[] GetSortedArrayIntersection(int[] array1, int[] array2) {

            return new HashSet<int>(array1.Concat(array2)).ToArray();
        }
    }
}
