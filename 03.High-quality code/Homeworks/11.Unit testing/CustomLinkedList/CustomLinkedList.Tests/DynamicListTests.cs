namespace CustomLinkedList.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private const int IntegerTestValue = 5;
        private const int IntegerTestValue2 = 20;

        private static DynamicList<string> dynamicStringList;
        private static DynamicList<int> dynamicIntList;

        [TestInitialize]
        public void TestInitialize()
        {
            dynamicStringList = new DynamicList<string>();
            dynamicIntList = new DynamicList<int>();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            dynamicStringList = null;
            dynamicIntList = null;
        }

        [TestMethod]
        public void Add_OneValueTypeElementAdded_CountShouldBeEqualToOne()
        {
            dynamicIntList.Add(IntegerTestValue);
            Assert.AreEqual(1, dynamicIntList.Count, "Count of dynamic list must be 1, after adding 1 element");
        }

        [TestMethod]
        public void Add_TwoValueTypeElementsAdded_CountShouldBeEqualToTwo()
        {
            dynamicIntList.Add(IntegerTestValue);
            dynamicIntList.Add(IntegerTestValue2);
            Assert.AreEqual(2, dynamicIntList.Count, "Count of dynamic list must be 2, after adding 2 elements");
        }

        [TestMethod]
        public void Add_OneReferenceTypeElementAdded_ShouldBeEqual()
        {
            string checkValue = "Pesho";
            dynamicStringList.Add(checkValue);
            Assert.AreEqual("Pesho", dynamicStringList[0], "The value of \"Pesho\" string should be equal as the value of the first element of the dynamic list");
        }

        [TestMethod]
        public void Add_OneReferenceTypeElementAdded_ShouldBeTheSame()
        {
            string checkValue = "Pesho";
            dynamicStringList.Add(checkValue);
            Assert.AreSame(checkValue, dynamicStringList[0], "The first element of the dynamic list should point to the same place where the \"Pesho\" string is in the heap");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerGetter_BiggerOutOfRangeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            dynamicIntList.Add(IntegerTestValue);
            int someNum = dynamicIntList[2];
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void IndexerGetter_NegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            dynamicIntList.Add(IntegerTestValue);
            int someNum = dynamicIntList[-10];
        }

        [TestMethod]
        public void IndexerSetter_OneAddedElement_ChangeValueAtIndex()
        {
            dynamicIntList.Add(IntegerTestValue);
            dynamicIntList[0] = IntegerTestValue2;
            Assert.AreEqual(IntegerTestValue2, dynamicIntList[0], string.Format("The value of the element {0} on index 0 must have changed with the value {1}", IntegerTestValue, IntegerTestValue2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexerSetter_BiggerOutOfRangeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            dynamicIntList.Add(IntegerTestValue);
            dynamicIntList[5] = IntegerTestValue2;
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void IndexerSetter_NegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            dynamicIntList.Add(IntegerTestValue);
            dynamicIntList[-10] = IntegerTestValue2;
        }

        [TestMethod]
        public void RemoveAt_DynamicListWithOneElement_ShouldRemoveElementAtGivenIndex()
        {
            dynamicStringList.Add("Pesho");
            var returnedElement = dynamicStringList.RemoveAt(0);
            Assert.AreEqual("Pesho", returnedElement, "Returned element must be equal to the string \"Pesho\"");
            Assert.AreEqual(0, dynamicIntList.Count, "Count must be equal to 0, after removing the only element left in the dynamic list");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void RemoveAt_OutOfRangeIndex_ShouldThrowAgumentOutOfRangeException()
        {
            dynamicIntList.RemoveAt(0);
        }

        [TestMethod]
        public void Remove_TwoElementsInDynamicList_ShouldReturnTheIndexOfSecondElement()
        {
            dynamicIntList.Add(IntegerTestValue);
            dynamicIntList.Add(IntegerTestValue2);
            var indexOfSecondElement = dynamicIntList.Remove(IntegerTestValue2);
            Assert.AreEqual(1, indexOfSecondElement, "The index of the second added element in a row, should be equal to 1");
            Assert.AreEqual(1, dynamicIntList.Count, "The count of the dynamic list after removing one of the two elements in the list, must be equal to 1");
        }

        [TestMethod]
        public void Remove_UnexistingElement_ShouldReturnMinusOne()
        {
            dynamicIntList.Add(IntegerTestValue);
            var indexOfUnexistingElement = dynamicIntList.Remove(IntegerTestValue2);
            Assert.AreEqual(-1, indexOfUnexistingElement, "The index of a non existing element in the dynamic list should be -1");
        }

        [TestMethod]
        public void IndexOf_OneElementInDynamicList_ShouldReturnZeroAsIndex()
        {
            dynamicIntList.Add(IntegerTestValue);
            var indexOfFirstElement = dynamicIntList.IndexOf(IntegerTestValue);
            Assert.AreEqual(0, indexOfFirstElement, "Index of the first added elemnt in the dynamic list must be equal to 0");
        }

        [TestMethod]
        public void IndexOf_OneElementInDynamicListAddedButItSearchesForDifferentOne_ShouldReturnMinusOne()
        {
            dynamicIntList.Add(IntegerTestValue);
            var indexOfUnexistingElement = dynamicIntList.IndexOf(IntegerTestValue2);
            Assert.AreEqual(-1, indexOfUnexistingElement, "Index of a non existing element in the dynamic list should be equal to -1");
        }

        [TestMethod]
        public void Contains_OneElementInDynamicList_ShouldReturnTrue()
        {
            dynamicStringList.Add("Pesho");
            bool containsValue = dynamicStringList.Contains("Pesho");
            Assert.AreEqual(true, containsValue, "Contains method should return true if the element we check is present in the dynamic list");
        }

        [TestMethod]
        public void Contains_OneElementInDynamicListButItSearchesForAnotherOne_ShouldReturnFalse()
        {
            dynamicIntList.Add(IntegerTestValue);
            bool containsOtherValue = dynamicIntList.Contains(IntegerTestValue2);
            Assert.AreEqual(false, containsOtherValue, "Contains method should return false if the element we check is not present in the dynamic list");
        }
    }
}
