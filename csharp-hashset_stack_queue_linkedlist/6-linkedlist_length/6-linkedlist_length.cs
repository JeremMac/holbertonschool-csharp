class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        foreach (var item in myLList)
        {
            count++;
        }
        return count;
    }
}
