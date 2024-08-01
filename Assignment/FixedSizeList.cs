using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        //FixedSize 
        //predetermined capacity -- Done
        //list should not allow more items that it's capacity 
        //provide clear message it one tries to access invalid indices 

        T[] arr;
        int counter = 0; //this will count how many times we add to the array

        public FixedSizeList(int _capacity) 
        {
            arr = new T[_capacity];
        }

        public void Add(T item) 
        {
           if(counter < arr.Length) 
            {
                arr[counter++] = item;
                Console.WriteLine("Item has been Added.");
            }
            else 
            {
                throw new ArgumentException("There is no Free spaces");
            }
        }

        //Usin indexer
        public T this[int index] 
        {
            get 
            {
               return arr[index];
            }
        }


        public T Get(int index) 
        {
            if(index >= arr.Length || index < 0) 
            {
                throw new ArgumentException("Invalid Indix");
            }
            else 
            {
                return arr[index];
            }
        }



    }
}
