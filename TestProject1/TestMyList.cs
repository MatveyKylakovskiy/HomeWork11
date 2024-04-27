using HomeWork11.FirstTask;
using HomeWork11.ThirdTask;

namespace TestProject1
{
    public class TestMyList
    {   
        MyList<int> list = new MyList<int>() {1, 2, 3, 4, 5};

        [Theory(DisplayName = "Test Add")]
        [InlineData(6, 2)]
        public void AddTest(int expect, int item)
        {   
            list.Add(item);
            var result = list.Count;
            Assert.Equal(expect, result);
        }

        [Theory(DisplayName = "Test Remove")]
        [InlineData(4, 2)]
        public void RemoveTest(int expect, int item)
        {
            list.Remove(item);
            var result = list.Count;
            Assert.Equal(expect, result);
        }

        [Theory(DisplayName = "Test Remove positive")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        public void RemoveTestPositive(int item)
        {
            Assert.True(list.Remove(item));
        }

        [Theory(DisplayName = "Test Remove negative")]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(-1)]
        public void RemoveTestNegative(int item)
        {
            Assert.False(list.Remove(item));
        }

        [Theory(DisplayName = "Search by index, positive")]
        [InlineData(0, 1)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 4)]
        [InlineData(4, 5)]
        public void SearchByIndexTest(int index, int item)
        {
            Assert.Equal(list[index], item);
        }

    }

}