using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_ToAnEmptyList_ItemGoesToIndexZero()
        {
            //arrange
            //to add an object
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;


            //act 
            // the variavbles im testing
            testList.Add(1);
            actual = testList[0];



            //assert
            // what the results are
            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            //arrange
            //to add to an array 
            //move item to end of the list
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;


            //act 
            // the variables im testing
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];



            //assert
            // what the results are
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;



            //act
            testList.Add(2345);
            actual = testList.count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        // write a test for when the array size changes (what is you array's starting size?)
        [TestMethod]
        public void Add_ToChangeCapacitySize()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //add 5 items and check last spot 

            //act
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            testList.Add(5);
            actual = testList.capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Remove_AddItemToList_ThenRemoveOneInstanceOfObject_EntireListCountIsZero()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected =0;
            int actual;


            //act
            testList.Add(2);
            testList.Remove(2);
            actual = testList.Count;
            

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_AddMultipleItemsToList_RemoveOnlyThatLastInstanceOfObject()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;


            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(2);
            testList.Remove(2);
            actual = testList.Count;



            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_AddMultpileItemsInARandomOrder_RemoveOnlyThatInstanceOfObject()
        {

            //arrange
             CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(3);
            actual = testList.Count;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_AddMultpileItemsInARandomOrder_RemoveObjectAtTheIndex1AndSeeIfEverythingShift()
        {

            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            //act
            testList.Add(2);
            testList.Add(4);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(2);
            actual = testList[0];

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Remove_AddAnItem_RemoveAnItemFromTheLastSpot_AndCheckIfIndexIsAtDefault()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            //act
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            actual = testList[1];

            //assert
            Assert.AreEqual(expected, actual);


        }


    }
}
