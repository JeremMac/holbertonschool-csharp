using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> currentNode = myLList.First;
        while (currentNode != null && currentNode.Value < n)
        {
            currentNode = currentNode.Next;
        }

        if (currentNode != null)
        {
            return myLList.AddBefore(currentNode, n);
        }
        else
        {
            return myLList.AddLast(n);
        }
    }
}

