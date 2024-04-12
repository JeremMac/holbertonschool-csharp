using System;
using System.Collections.Generic;

class Dictionary {
    public static string BestScore(Dictionary<string, int> myList) {
        if (myList != null && myList.Count != 0) {
            int bestScore = 0;
            string bestStudent = "";
            foreach (KeyValuePair<string, int> kvp in myList) {
                if (bestScore <= kvp.Value) {
                    bestScore = kvp.Value;
                    bestStudent = kvp.Key;
                }
            }
            return bestStudent;
        }
        return "None";
    }
}
