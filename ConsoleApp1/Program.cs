using ConsoleApp1.Models;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {

        public static int SumArray(ArrayList arr) 
        {
            int sum = 0;
            for(int i = 0; i < arr.Count; i++) 
            {
                if (arr[i] is int) 
                {
                    sum += (int)arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Non-Generic-Collections [ArrayList]
            //// What is ArrayList?
            ///*
            // * Arraylist simply it's an array with Objects that can hold 
            // * any ojbects from anytype like(int - string - bool )
            // * and it's pro it's size is dynamic increase meaning
            // * if the size of the array is 3 and we put 4 
            // * automaticly it's create a new array in the heap then copy the old array ojects
            // * from the old one then paste it into the new one 
            // * 
            // */

            ////Count - Capacity 
            ///*Array List has two Attributes 
            // * Count => it's the number of item in the Array list 
            // * Capacity => number of items that array list can hold
            // */

            //ArrayList array = new ArrayList(); //count = 0 , capacity = 0 
            //Console.WriteLine($"Count = {array.Count} - Capacity: {array.Capacity}");

            ////If we start to add an element to it the default capacity will be increased from 0 to 4
            //array.Add(1);
            //Console.WriteLine("After Adding");
            //Console.WriteLine($"Count = {array.Count} - Capacity: {array.Capacity}");

            ////Is he change the size of the array?
            ///*
            // * But how he change the size from 0 to 4 and it's type array?
            // * simply he create a new array in the heap with the new capacity 
            // * then he move the item from the old array to the new array
            // */


            //array.AddRange(new int[] { 1, 2, 3, 4, 5, });
            //Console.WriteLine($"Count = {array.Count} - Capacity: {array.Capacity}");
            ////The capacity increase because we have added items in the array larger than it's capacity
            ////so compiler create a new array with capacity of old array * 2 then move the elements
            ////from the old array to the new one
            ////so it has a dynamic size


            ////we can use object intializer to create the array list 
            //ArrayList arr = new ArrayList() { 1,"Ebrahem",true,2,3};  //غير متجانسة
            //Console.WriteLine($"Count = {arr.Count} - Capacity: {arr.Capacity}");

            //arr.TrimToSize(); //we use it to remove unsed bytes from the array by creating new array
            //Console.WriteLine($"Count = {arr.Count} - Capacity: {arr.Capacity}");

            ////Sum arraylist Function
            //int result = SumArray(arr);
            //Console.WriteLine(result);



            #endregion

            #region ArrayListMod Example
            //ArrayListMod<int> arr = new ArrayListMod<int>(3);
            //arr.Add(2);
            //arr.Add(3);
            //arr.Add(4);
            //arr.Resize();
            //arr.Add(4);
            //arr.Add(7);
            //arr.Add(8);
            //arr.Resize();
            //arr.Add(10); 
            //arr.PrintArrayElement();
            #endregion

            #region List - Generics
            ////Lists is a dynamic storage

            ////this will create a new List to store int values
            //List<int> numbers = new List<int>();

            ////also we can use object intializer
            //List<string> names = new List<string>() { "Ebrahem","Ashraf","Ahmed"};

            ////Add Method
            //names.Add("Alhebahsy");

            ////AddRange Method
            //names.AddRange(["Hema","Ots"]);


            //foreach(string name in names) 
            //{
            //    Console.WriteLine(name);
            //}

            ////List Methods
            //numbers.Insert(0,10); //put item on spacific index
            //Console.WriteLine(numbers[0]);

            //numbers.InsertRange(0,new int[] {5,5}); //insert rangeon spacific index

            //numbers.Clear(); //will remove all items in the list

            //Console.WriteLine(names.Contains("Ebrahem")); //check if the item is already in the list or not 


            //Console.WriteLine("================================");

            //string[] nubmers02 = new string[5]; 
            //names.CopyTo(2, nubmers02,1,2);

            //foreach(string n in nubmers02) 
            //{
            //    Console.WriteLine(n);
            //}

            //Console.WriteLine($"Capacity: {names.Capacity}");
            //names.EnsureCapacity(10);
            //Console.WriteLine($"Capacity: {names.Capacity}");




            #endregion

            #region Linked List
            //Has two important things 
            //Value 
            //POinter that point to another Node 

            // LinkedList<string> list = new LinkedList<string>();

            // list.AddFirst("my"); //add to the firt or list
            // list.AddLast("ebrahem"); // add to the last of the list

            // //i need to add name is 

            // //add name after first node 
            // //first we need to get the first Node Pointer adress

            //LinkedListNode<string> firstElement =  list.Find("my");

            // list.AddAfter(firstElement,"name");

            // LinkedListNode<string> lastElement = list.Find("ebrahem");
            // list.AddBefore(lastElement, "is");


            // foreach(string name in list) 
            // {
            //     Console.Write(name + " ");
            // }


            #endregion

            #region Array - ArrayList - List - Linked List
            /*
             * When to Use Each of these?
             * 
             * Hemogenous           Non Hemogenous
             *    |                    ArrayList => Array OF objects
             * Fixed Size => Array
             * Not Fixed Size
             *    |
             * List => if we need to search more than we Add 
             * LinkedList => if we need to Add more than search
             * 
             */
            #endregion

            #region Stack [Fisrt In Last out]

            //Stack<string> visitedWebsite = new Stack<string>();

            ////We use push method to add elements to the stack
            //visitedWebsite.Push("google.com");
            //visitedWebsite.Push("facebook.com");
            //visitedWebsite.Push("youtube.com");

            ////Try peak will try to return the last element enterd in the stack
            ////bool isValid = visitedWebsite.TryPeek(out string result);
            ////Console.WriteLine(isValid);
            ////Console.WriteLine($"Last Visited Website is : {result}");

            ////Pop will remove the last element entered in the stack
            //bool isValid = visitedWebsite.TryPop(out string result);
            //Console.WriteLine(isValid);
            //Console.WriteLine($"Last Visited Website is : {result}");


            //foreach (string website in visitedWebsite)
            //{
            //    Console.WriteLine(website);
            //}



            #endregion

            #region Queue [First In First Out]
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //foreach(int q in queue) 
            
            //{
            //    Console.WriteLine(q);
            //}


            ////bool isValid = queue.TryPeek(out int result);
            ////Console.WriteLine(isValid);
            ////Console.WriteLine(result);


            //bool isValid = queue.TryDequeue(out int result);
            //Console.WriteLine(isValid);
            //Console.WriteLine(result);


            #endregion





        }
    }
}
