using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1 {
    public static class Problem19_1 {

        public static bool ArrayHasPath(bool[,] maze, Tuple<int, int> currentPosition, Tuple<int, int> endPosition) {

            return ArrayHasPath(maze, currentPosition, endPosition, new HashSet<Tuple<int, int>>());
        }


        private static bool ArrayHasPath(bool[,] maze, Tuple<int, int> currentPosition, Tuple<int, int> endPosition, HashSet<Tuple<int, int>> visitedLocations) {

            if (currentPosition.Item1 == endPosition.Item1 && currentPosition.Item2 == endPosition.Item2) {
                return true;
            }
            else if (visitedLocations.Contains(currentPosition)) {
                return false;
            }

            visitedLocations.Add(currentPosition);

            var x = currentPosition.Item1;
            var y = currentPosition.Item2;

            if (x > 0 && maze[x - 1, y] && ArrayHasPath(maze, Tuple.Create(x - 1, y), endPosition, visitedLocations)) {

                return true;
            }
            else if (x < maze.GetLength(0) - 1 && maze[x + 1, y] && ArrayHasPath(maze, Tuple.Create(x + 1, y), endPosition, visitedLocations)) {

                return true;
            }
            else if (y > 0 && maze[x, y - 1] && ArrayHasPath(maze, Tuple.Create(x, y - 1), endPosition, visitedLocations)) {

                return true;
            }
            else if (y < maze.GetLength(1) - 1 && maze[x, y + 1] && ArrayHasPath(maze, Tuple.Create(x, y + 1), endPosition, visitedLocations)) {

                return true;
            }

            visitedLocations.Remove(currentPosition);

            return false;
        }
    }
}
