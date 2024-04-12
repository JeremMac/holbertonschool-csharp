using System
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys = 0;
        if (myDict != null)
        {
            foreach(var key in myDict)
            {
                keys++;
            }
            return keys;
        }
        else
        {
            return 0;
        }
    }
}

