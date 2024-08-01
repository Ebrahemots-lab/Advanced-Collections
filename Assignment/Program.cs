using System.Collections;

namespace Assignment
{
    internal class Program
    {
        public static void ReverseArray<T>(ArrayList arr)
        {

            /*
             * take the first element of the array then save it 
             * int firstelement = arraylist[0]
             * [2,4,6,7,8]
             * [0,4,6,7,8]
             * [4,6,7,8,0]
             * [4,6,7,8,2]
             * [0,6,7,8,2]
             * [6,7,8,0,2]
             */

            if (arr is not null)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    //Save the first element
                    T element = (T)arr[0]; //4  
                                           //Assign it to 0
                    arr[0] = 0;

                    //[2,4,6,7,8]
                    //[0,4,6,7,8]
                    //[4,6,7,8,2]
                    //[0,6,7,8,2]

                    //this loop with Push the second element to the Befor index
                    //Ex => [0,4,5,6,7] => [4,5,6,7,7]
                    for (int z = 1; z < arr.Count - i; z++)
                    {
                        arr[z - 1] = arr[z];

                    }

                    //Assign the last element with Element that we saved Befor then each loop we decreeses the index by one
                    //based on I
                    arr[arr.Count - i - 1] = element;

                }


            }

            Console.WriteLine("Reversed Array");
            foreach (T n in arr)
            {
                Console.WriteLine(n);
            }
        }

        public static List<int> FindEven(List<int> numbers) 
        {
            List<int> evenNumbers = new List<int>();

            foreach(int number in numbers) 
            {
                if(number % 2 == 0) 
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        public static void WebsiteHolder() 
        {
            string userChoice = "y";
            Stack<string> websiteNames = new Stack<string>();
            int counter = 1;
            while(userChoice == "y")
            {
            Console.Write($"PLease enter website Number {counter++}: ");
            string websiteName = Console.ReadLine()!;
            websiteNames.Push(websiteName);
            Console.Write("Add another Website: y - n: ");
            userChoice = Console.ReadLine()!;
            }
            Console.WriteLine("Your History");
            foreach (string website in websiteNames) 
            {
                Console.WriteLine(website);
            }
        }
        static void Main(string[] args)
        {
            #region Part 01

            ////Array 
            ////We use it if we have Hemogenous Data with Fixed Size 
            ////if we have 5 classes and we need to coLLect Exam degree for each class

            //int[] classDegres = new int[5] { 100, 200, 300, 400, 500 };

            ////List<>
            ////if we have a class that contains names of the students 
            ////but each year this class increased by 5 student

            //List<string> studentNames = new List<string>()
            //{
            //    "Ebrahem",
            //    "Ashraf",
            //    "Ahmed",
            //    "Alhebashy"
            //};

            ////LinkedList<>
            ////Efficient for adding Elements on spacific places
            ////if you have a todo Application and you want to add or update some tasks
            ////At spacific places to finish them befor something else

            //LinkedList<string> notes = new LinkedList<string>();


            //notes.AddFirst("Shopping"); //First Element

            //LinkedListNode<string> afterFirst = notes.Find("Shopping");

            //notes.AddAfter(afterFirst, "Study");


            //foreach (string n in notes)
            //{
            //    Console.WriteLine(n);
            //}


            //Stack
            //we use stack in websites for example if we need to step back one 
            //step and see what is the website that we visisted.

            //WebsiteHolder();


            //Queue
            //[First in First Out]
            //Appointment for a Doctor
            //
            //Queue<String> patientNames = new Queue<string>();
            //patientNames.Enqueue("A");
            //patientNames.Enqueue("b");
            //patientNames.Enqueue("C");



            //int counter = 1;
            //foreach(string name in patientNames) 
            //{
            //    Console.WriteLine($"Patient Number {counter++}: {name}");
            //}



            #endregion

            #region Part 02
            //ArrayList arrayList = new ArrayList() { 2, 4, 6, 7, 8 };

            //ArrayList names = new ArrayList() { "Ebrahem", "Ashraf", "Ahmed" };

            //ReverseArray<int>(arrayList);


            ////2
            //List<int> result = FindEven(new List<int>() { 1, 2, 3, 4, 5, 6 });

            //foreach (int evenNumber in result)
            //{
            //    Console.WriteLine(evenNumber);
            //}

            //3
            FixedSizeList<int> newList = new FixedSizeList<int>(3);
            newList.Add(1);
            newList.Add(2);
            newList.Add(3);

            //Console.WriteLine(newList[0]); /Using index

            Console.WriteLine(newList.Get(0));

            #endregion
        }

    }


}


