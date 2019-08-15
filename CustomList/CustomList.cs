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
                SecondArray[i] = items[i];
            }

            capacity *= 2;
            items = SecondArray;
        }
    }
        
        public void Remove(T itemsToRemove)
        {


        }

    
}
