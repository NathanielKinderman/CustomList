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



    }
}
