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
    }
}
