using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary {
    public static void PrintSorted(Dictionary<string, string> myDict) {
        if (myDict != null) {
            foreach (KeyValuePair<string, string> kvp in myDict.OrderBy(key => key.Key)) {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
