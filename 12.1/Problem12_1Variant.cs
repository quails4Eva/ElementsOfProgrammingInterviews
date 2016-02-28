using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1 {
    public class Problem12_1Variant {

        // Doing the strict version
        public static int FindMaxInAscendingThenDescendingSequnce(int[] sequence, int min = 1, int? max = null) {

            if (sequence.Length < 3) {
                throw new ArgumentException($"Argument {nameof(sequence)} must be of length at least 3 to have an ascending then descending sequence");
            }
            max = max ?? (sequence.Length - 2);


            var midway = (min + max.Value) / 2;

            if (sequence[midway - 1] < sequence[midway]) {
                if (sequence[midway] > sequence[midway + 1]) {

                    return midway;
                }
                else {
                    return FindMaxInAscendingThenDescendingSequnce(sequence, midway + 1, max);
                }
            }
            else {

                return FindMaxInAscendingThenDescendingSequnce(sequence, min, midway - 1);
            }
        }
    }
}
