using System.Collections.Generic;

namespace P04BubbleSort
{
    public static class Bubble
    {
        public static void Sort(List<int> elements)
        {
            bool hasSwapped = true;
            while (true)
            {
                if (hasSwapped == false)
                {
                    return;
                }
                hasSwapped = false;
                for (int i = 0; i < elements.Count - 1; i++)
                {
                    if (elements[i] > elements[i + 1])
                    {
                        hasSwapped = true;
                        var temp = elements[i + 1];
                        elements[i + 1] = elements[i];
                        elements[i] = temp;
                    }
                }
            }
        }
    }
}
