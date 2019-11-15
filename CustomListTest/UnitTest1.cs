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
            actual = testList.Count;


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
            int expected = 0;
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

        [TestMethod]
        public void ConvertToString_TakeANumber_ReturnTheStringNumber()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "3";
            string actual;


            //act
            testList.Add(3);

            actual = testList.ToString();


            //assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void ConvertToString_TakeADouble_ReturnTheStringDouble()
        {
            //arrange
            CustomList<double> testList = new CustomList<double>();
            string expected = "12.34";
            string actual;


            //act
            testList.Add(12.34);

            actual = testList.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ConvertToString_CreateAListToHoldManyCharacters_GetCountOfStrings()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            int expected = 3;
            int actual;


            //act
            testList.Add("ABC");
            testList.Add("DEF");
            testList.Add("GHI");

            actual = testList.Count;


            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOverLoad_TwoListOfInt_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> result;

            int expected = 6;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            result = testList + testList2;
            actual = result.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddOverLoad_TwoListOfString_CombineBothList()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            string expected = "ABC";
            CustomList<string> actual = new CustomList<string>(); ;

            //act
            testList.Add("ABC");
            testList2.Add("DEF");
            actual = testList + testList2;

            //assert
            Assert.AreEqual(expected, actual[0]);

        }

        [TestMethod]
        public void AddOverLoad_TwoListOfDifferntSizeList_CheckTheIndexAtACertainSpot()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expected = 4;
            CustomList<int> actual = new CustomList<int>();

            //act
            testList.Add(1);
            testList.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            actual = testList + testList2;


            //assert
            Assert.AreEqual(expected, actual[3]);

        }

        [TestMethod]
        public void AddOverLoad_TwoListsWithOneListEmpty_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expected = 3;
            CustomList<int> actual = new CustomList<int>();


            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            actual = testList + testList2;



            //assert
            Assert.AreEqual(expected, actual[2]);
        }


            [TestMethod]
            public void SubtractOverLoad_TwoListOfInt_CheckIndex()
            {
                //arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();
                CustomList<int> actual = new CustomList<int>(); //2 will be at 0 index and 3 will be at 1 index of returned CustomList object
            int expected = 0;


                //act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList2.Add(4);
                testList2.Add(1);
                testList2.Add(6);
                actual = testList - testList2;


                 //assert
                Assert.AreEqual(expected, actual[1]);

            }
        [TestMethod]
        public void SubtractOverLoad_CheckIndexOfItemAfterRemovalOfNumberFromList_IndexIsCorrect()
        {
            //arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> resultsList = new CustomList<int>();
            int expected = 0;
            int actual;

            //act
            testOne.Add(1);
            testOne.Add(2);
            testOne.Add(3);
            testTwo.Add(2);
            testTwo.Add(5);
            testTwo.Add(6);
            resultsList = testOne - testTwo;
            actual = resultsList[1];

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void SubtractOverload_SubtractTwoMatchingLists_ListOneIsEmpty()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> newList;
            int expected = 0;
            int actual;

            //Act
            testOne.Add(1);
            testOne.Add(2);
            testTwo.Add(1);
            testTwo.Add(2);
            newList = testOne - testTwo;
            actual = newList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractOverLoad_TwoListOfIntOneIsAnEmptyList_CheckIndexOftestList2()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expected = 0;
            CustomList<int> actual = new CustomList<int>();



            //act

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actual = testList - testList2;


            //assert

            Assert.AreEqual(expected, actual[2]);

        }
        //.zip take list one and list two and put the items in both in a new list 


        [TestMethod]
        public void Zip_ZipTwoListsOfOneTogether_ZippedListOrderedOneThenTwo()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 2;
            int actual;

            //Act
            testOne.Add(1);
            testTwo.Add(2);
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipListOfEvenAndListOfOddTogether_TheAtIndexOneIsTwo()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 2;
            int actual;

            //Act
            testOne.Add(1);
            testOne.Add(3);
            testTwo.Add(2);
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipWhenListOneHasHigherCount_IndexThreeIsFive()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 5;
            int actual;

            //Act
            testOne.Add(1);
            testOne.Add(3);
            testOne.Add(5);
            testTwo.Add(2);
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ListsOfSingleValueTogether_CountIsTwo()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 2;
            int actual;

            //Act
            testOne.Add(1);
            testTwo.Add(2);
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_zipTwoEmptyLists_CountZero()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 0;
            int actual;

            //Act
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoFullListsOfInts_CountOfNine()
        {
            //Arrange
            CustomList<int> testOne = new CustomList<int>();
            CustomList<int> testTwo = new CustomList<int>();
            CustomList<int> Zipped;
            int expected = 9;
            int actual;

            //Act
            testOne.Add(1);
            testOne.Add(3);
            testOne.Add(5);
            testOne.Add(7);
            testOne.Add(9);
            testTwo.Add(2);
            testTwo.Add(4);
            testTwo.Add(6);
            testTwo.Add(8);
            Zipped = CustomList<int>.ZipListTogether(testOne, testTwo);
            actual = Zipped.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }       


    }   
}
