using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._1 {
    public class BSTNode<T> where T : IComparable<T> {

        public T Data { get; set; }
        public BSTNode<T> Left { get; set; }
        public BSTNode<T> Right { get; set; }

        public bool IsBSTSatisfied() {

            return this.IsBSTSatisfied(default(T), false, default(T), false);
        }

        // We have a useMax so that we don't have to pass in the maximum value for a generic type (which may not exist)
        private bool IsBSTSatisfied(T max, bool useMax, T min, bool useMin) {

            var satisfiesMax = (!useMax || this.Data.CompareTo(max) <= 0);
            var satisfiesMin = (!useMin || this.Data.CompareTo(min) >= 0);

            var satisfiesLeft = this.Left == null || (this.Left.IsBSTSatisfied(this.Data, true, min, useMin));
            var satisfiesRight = this.Right == null || (this.Right.IsBSTSatisfied(max, useMax, this.Data, true));

            return satisfiesMax && satisfiesMin && satisfiesLeft && satisfiesRight;
        }
    }
}
