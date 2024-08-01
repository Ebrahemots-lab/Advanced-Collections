using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ArrayListMod<T>
    {
        T[] arry;
        int capacity = 1;
        int counter = 0;
        T[] newArray;

        public ArrayListMod()
        {
            arry = new T[0];
        }
        public ArrayListMod(int _capacity)
        {
            capacity = _capacity;
            arry = new T[_capacity];
        }



        public void Add(T item) 
        { 
            // 2 3 
           
            arry[counter++] = item;
        }

        //Method that will increase the size of the array 
        //by make a new array then copy the values from the old array then put it into the new array
        public void Resize() 
        {
            capacity *= 2;
            newArray = new T[capacity];
            Array.Copy(arry, newArray, arry.Length);
            arry = newArray;

        }

        public void PrintArrayElement() 
        {
            foreach(T t in arry) 
            {
                Console.WriteLine(t);
            }
        }
        

    }
}
