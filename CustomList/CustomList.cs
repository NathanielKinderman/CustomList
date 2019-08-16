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
                


                //Result = SB.Append;
                //SB.Append([i].ToString());
                //Console.WriteLine(SB.ToString());
            }
            return NewString;

        }


    }  
       
}

    
    

