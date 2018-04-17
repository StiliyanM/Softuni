using NUnit.Framework;
using P04BubbleSort;
using System.Linq;

namespace UnitTests
{
    public class BubbleSortTests
    {
        [TestCase(1)]
        [TestCase(9, 6, 3, 12, 15, 7)]
        [TestCase(10,9,-5,-2,0,1)]
        public void BubbleSortShowsCorrectResult(params int[] values)
        {
            var list = values.ToList();
            Bubble.Sort(list);

            var isSorted = true;

            for (int i = 0; i < list.Count - 1; i++)
            {
                if(list[i] > list[i + 1])
                {
                    isSorted = false;
                    Assert.Fail();
                }
            }

            Assert.True(isSorted);
        }
    }
}
