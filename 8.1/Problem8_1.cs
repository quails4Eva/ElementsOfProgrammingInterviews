using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1 {
    public static class Problem8_1 {

        public static ListNode<int> MergeTwoSortedLists(ListNode<int> firstList, ListNode<int> secondList) {

            if ((firstList ?? secondList) == null) {

                return null;
            }

            var sortedNodes = Order(firstList, secondList);

            var newList = sortedNodes[0];
            var currentNode = newList;
            sortedNodes = Order(sortedNodes[0].Next, sortedNodes[1]);

            while (sortedNodes.Any(n => n != null)) {

                currentNode.Next = sortedNodes[0];
                currentNode = sortedNodes[0];
                sortedNodes = Order(sortedNodes[0].Next, sortedNodes[1]);
            }

            return newList;
        }

        private static ListNode<int>[] Order(ListNode<int> firstList, ListNode<int> secondList) {
            
            return secondList == null || (firstList != null && firstList.Data < secondList.Data) ? new[] { firstList, secondList } : new[] { secondList, firstList };
        }
    }
}
