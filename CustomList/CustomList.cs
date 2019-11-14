using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{


    public class CustomList<T>
    {
        private int count;
        public int capacity;
        public bool IsEqual;

        public int Count { get { return count; } }


        private T[] items;
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
            count = 0;

        }


        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                IncreaseCapacity();
            }

            items[count] = itemToAdd;
            count++;
        }


        private void IncreaseCapacity()
        {

            T[] SecondArray = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                SecondArray[i] = items[i]; //if else for remove method
            }

            capacity *= 2;
            items = SecondArray;
        }


        public void Remove(T itemsToRemove)
        {
            IsEqual = false;
            T[] SecondArray = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                if (itemsToRemove.Equals(items[i]) && IsEqual == false)
                {
                    IsEqual = true;
                    if (i < count - 1)
                    {
                        items[i] = items[i + 1];

                    }
                    else
                    {
                        items[i] = default;
                    }
                    count--;

                }

                else
                {
                    IsEqual = false;
                }
            }
        }

        public override string ToString()
        {
            string NewString = "";

            for (int i = 0; i < count; i++)
            {
                NewString += items[i].ToString();


            }
            return NewString;

        }


        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            ///i want to add two lists together and return the results in a new object list
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                result.Add(listOne[i]);
            }
            for (int j = 0; j < listTwo.count; j++)
            {
                result.Add(listTwo[j]);
            }
            return result;
        }




        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            ///i want to add two lists together and return the results in a new object list
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < listOne.count; i++)
            {
                for(int j =0; j<listTwo.count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        break;
                    }
                    else if (j== listTwo.count)
                    {
                        result.Add(listOne[i]);
                    }
                }
                
            }
            return result;
        }


        public static CustomList<T> ZipListTogether(CustomList<T> listOne, CustomList<T> listTwo)
        {
            //i want to combine two list together and have the indices alternating
            //use overloaded + operator and somehow have the indices from both lists alternate
            //one list is odd numbers and the other even number

            CustomList<T> zipResult = new CustomList<T>();
            for(int i =0; i < listOne.Count || i < listTwo.Count; i++)
            {
                if( i < listOne.Count)
                {

                    zipResult.Add(listOne[i]); 
                }
                if(i < listTwo.Count)
                {
                    zipResult.Add(listTwo[i]);


                }

            }
            return zipResult;

        }






    }

}

    
    

