using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{


    public class CustomList<T>
    {
        public int count;



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
            items = new T[4];
            count = 0;
        }


        public void Add(T itemToAdd)
        {
            items[count] = itemToAdd;
            count++;
        }

        }


    
}
