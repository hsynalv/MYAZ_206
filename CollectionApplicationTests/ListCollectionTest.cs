using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CollectionApplicationTests
{
    public class ListCollectionTest
    {
        private List<int> leftList;
        private List<int> rightList;
        public ListCollectionTest()
        {
            leftList = new List<int> { 1,2,3,4,4,5};
            rightList = new List<int> { 4,5,6,6,7};
        }

        [Fact]
        public void InterSectionTest()
        {
            //Act
            var intersectionList = leftList.Intersect(rightList);

            //Assert
            Assert.Equal(2, intersectionList.ToList().Count);

            Assert.Collection(intersectionList,
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item));
        }

        [Fact]
        public void UnionTest()
        {
            var unionList = rightList.Union(leftList).OrderBy(item => item).ToList();

            Assert.Equal(7, unionList.Count);

            Assert.Collection(unionList,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item),
                item => Assert.Equal(7, item));
        }

        [Fact]
        public void LeftExceptRight()
        {
            var exceptList = leftList.Except(rightList).ToList();

            Assert.IsType<List<int>>(exceptList);
            Assert.Equal(3, exceptList.Count);
        }
    }
}
