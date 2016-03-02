using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1 {
    public class Problem13_1 {

        public static Dictionary<string, List<string>> GroupStrings(IEnumerable<string> input) {

            Dictionary<string, List<string>> groupedStrings = new Dictionary<string, List<string>>(input.Count());

            foreach (var val in input) {

                var key = new string(val.OrderBy(c => c).ToArray()); // Could maybe use string.Join rather than new String()

                List<string> currentMatches;

                if (!groupedStrings.TryGetValue(key, out currentMatches)) {

                    currentMatches = new List<string>();
                    groupedStrings.Add(key, currentMatches);
                }
                currentMatches.Add(val);
            }

            return groupedStrings.Where(kvp => kvp.Value.Count > 1).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            //return input.GroupBy(s => new string(s.OrderBy(c => c).ToArray())).Where(g => g.Count() > 1).ToDictionary(g => g.Key, global => global.ToList());
        }
    }
}
