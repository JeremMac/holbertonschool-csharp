using System;
using System.Collections.Generic;
using System.Linq;

class List {
    public static int Sum(List<int> myList) {
        int sum = 0;
        List<int> newList = myList.Distinct().ToList();

        if (myList != null) {
            foreach (int num in newList) {
                sum += num;
            }
        }
        return sum;
    }
}
