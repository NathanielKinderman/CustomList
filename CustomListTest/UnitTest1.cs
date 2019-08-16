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
            string expected = "123456";
            string actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            actual = testList + testList2;

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]
        public void AddOverLoad_TwoListOfString_CombineBothList()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            string expected = "ABCDEF";
            string actual;

            //act
            testList.Add("ABC");
            testList2.Add("DEF");
            actual = testList + testList2;

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddOverLoad_TwoListOfDifferntSizeList_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "12345";
            string actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            actual = testList + testList2;


            //assert
            Assert.AreEqual(expected, actual.ToString());

        }

        [TestMethod]
        public void AddOverLoad_TwoListsWithOneListEmpty_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "123";
            string actual;


            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            actual = testList + testList2;



            //assert
            Assert.AreEqual(expected, actual.ToString());
        }


            [TestMethod]
            public void SubtractOverLoad_TwoListOfInt_CombineBothList()
            {
                //arrange
                CustomList<int> testList = new CustomList<int>();
                CustomList<int> testList2 = new CustomList<int>();
                string expected = "23";
                string actual;


                //act
                testList.Add(1);
                testList.Add(2);
                testList.Add(3);
                testList2.Add(4);
                testList2.Add(1);
                testList2.Add(6);
                actual = testList - testList2;


                 //assert
                Assert.AreEqual(expected, actual.ToLower());

            }
        [TestMethod]
        public void SubtractOverLoad_TwoListOfString_CombineBothList()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            string expected = "RedGreen";
            string actual;


            //act
            testList.Add("Red");
            testList.Add("Yellow");
            testList.Add("Green");
            testList2.Add("Blue");
            testList2.Add("Yellow");
            testList2.Add("Purple");
            actual = testList - testList2;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void SubtractOverLoad_TwoListOfIntOfDifferentSizes_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "124";
            string actual;



            //act

            testList.Add("1");
            testList.Add("2");
            testList.Add("3");
            testList.Add("4");
            testList2.Add("3");
            actual = testList - testList2;


            //assert

            Assert.AreEqual(expected, actual.ToLower());
        }

        [TestMethod]
        public void SubtractOverLoad_TwoListOfIntOneIsAnEmptyList_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "123";
            string actual;



            //act

            testList.Add("1");
            testList.Add("2");
            testList.Add("3");
            actual = testList - testList2;


            //assert

            Assert.AreEqual(expected, actual.ToLower());

        }
        //.zip take list one and list two and put the items in both in a new list 

        [TestMethod]
        public void Zip_TwoListOfInt_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "123456";
            string actual;



            //act
            testList.Add("1");
            testList.Add("3");
            testList.Add("5");
            testList2.Add("2");
            testList2.Add("4");
            testList2.Add("6");
            actual = testList.Zip(testList2);



            //assert
            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void Zip_TwoListOfString_CombineBothList()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            string expected = "TheCatInTheHat";
            string actual;



            //act
            testList.Add("The");
            testList.Add("In");
            testList.Add("Hat");
            testList2.Add("Cat");
            testList2.Add("The");
           
            actual = testList.Zip(testList2);



            //assert
            Assert.AreEqual(expected, actual.ToString());


        }

        [TestMethod]
        public void Zip_TwoListOfIntDifferentSizes_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "12345";
            string actual;



            //act
            testList.Add("1");
            testList.Add("3");
            testList.Add("5");
            testList2.Add("2");
            testList2.Add("4");
            
            actual = testList.Zip(testList2);



            //assert
            Assert.AreEqual(expected, actual.ToString());


        }


        [TestMethod]
        public void Zip_TwoListOfIntOneListIsEmpty_CombineBothList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expected = "135";
            string actual;



            //act
            testList.Add("1");
            testList.Add("3");
            testList.Add("5");
            
            actual = testList.Zip(testList2);



            //assert
            Assert.AreEqual(expected, actual.ToString());


        }


    }   
}
