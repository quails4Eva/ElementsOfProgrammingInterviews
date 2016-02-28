using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1 {
    public static class Problem12_1 {

        public static int BinarySearchFirstInstance(int[] array, int toFind, int min = 0, int? max = null) {

            if (!max.HasValue) {

                max = array.Length - 1;
            }

            var midway = (min + max.Value) / 2;
            
            if (array[midway] == toFind) {
                if (midway <= min) {

                    return min;
                }
                else {

                    return BacktrackForFirstElement(array, toFind, midway, min, midway - 1);
                }
            }
            else if (min >= max) {

                return -1;
            }
            else if (array[midway] < toFind) {

                return BinarySearchFirstInstance(array, toFind, midway + 1, max);
            }
            else {

                return BinarySearchFirstInstance(array, toFind, min, midway - 1);
            }
        }

        private static int BacktrackForFirstElement(int[] array, int toFind, int minFound, int min, int max) {

            if (min == max) {

                return array[min] == toFind ? min : minFound;
            }
            else {

                var midway = (min + max) / 2;

                if (array[midway] == toFind) {

                    return BacktrackForFirstElement(array, toFind, midway, min, midway - 1);
                }
                else {
                    return BacktrackForFirstElement(array, toFind, minFound, midway + 1, max);
                }
            }
        }
    }
}
