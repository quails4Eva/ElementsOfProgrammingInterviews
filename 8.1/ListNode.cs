using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._1 {
    public class ListNode<T> : IEnumerable<T> {

        public T Data { get; set; }

        public ListNode<T> Next { get; set; }

        // To make debuggin easier
        public override string ToString() {
            return Data.ToString();
        }

        // So can more easily test
        public IEnumerator<T> GetEnumerator() {

            yield return this.Data;

            if (this.Next != null) {
                foreach (var data in this.Next) {

                    yield return data;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {

            return this.GetEnumerator();
        }
    }
}
