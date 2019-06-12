using System;
using System.Linq;

namespace HomeWorkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //DisplayByIndex();
            //ReverseArr();
            //GetNbOfOccurences();
            //InsertNewElement();
            //RemoveElement();
            //UniqueElement();
            //PrintDistinctElem();
            //SumAllElemens();
            //Merging2ArrAndSort();
            //GetSmallestElem();
            //GetBigestElem();
            //OddAndEven();
            //SortingAscending();
            //SortingDescending();
            // SecondLargest();
            // SecondSmallest();

            //Matrix();
            AdditionOfTwoMaTrices();

        }

        //    Arrays
        //1. Write a method to create an array of 5 integers and display the array items.Access individual elements and display them through indexes.
        public static void DisplayByIndex()
        {
            int[] myfirstarr = new int[5];
            myfirstarr[0] = 1;
            myfirstarr[1] = 2;
            myfirstarr[2] = 3;
            myfirstarr[3] = 4;
            myfirstarr[4] = 5;

            Console.WriteLine("index 0 = {0}\nindex 1 = {1}\nindex 2 = {2}\nindex 3 = {3}\nindex 4 = {4}", myfirstarr[0], myfirstarr[1], myfirstarr[2], myfirstarr[3], myfirstarr[4]);
        }

        //2. Write a method to reverse the order of the items in the array

        public static void ReverseArr()
        {
            var myArr = GetArrayFromUser();
            for (int i = myArr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{myArr[i]}, ");
            }
        }

        //3. Write a method to get the number of occurrences of a specified element in an array

        public static void GetNbOfOccurences()
        {
            var myArray = GetArrayFromUser();
            var count = 0;
            Console.WriteLine("Enter a number to begin search ...");
            int number = int.Parse(Console.ReadLine());

            foreach (var element in myArray)
            {
                if (element == number)
                {
                    count++;
                }
            }
            Console.WriteLine($"{number} found {count} times");
        }

        //4. Write a method to insert a new item before the second element in an existing array

        public static void InsertNewElement()
        {
            Console.WriteLine("Add elements to array!");

            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = new int[10];
            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());
            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());
            for (i = 5; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;
            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }


        //5. Write a method to remove a specified item using the index from an array.

        public static void RemoveElement()
        {
            int i = 0;
            int pos = 0;
            int[] arr = new int[10];

            Console.WriteLine("Enter numbers : ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter position to delete item : ");
            pos = int.Parse(Console.ReadLine());

            for (i = pos - 1; i < 5; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("Array elements after deletion : ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
            }

            Console.WriteLine();
        }

        //6. Write a program to find the sum of all elements of the array

        public static void SumAllElemens()
        {
            var myArray = GetArrayFromUser();
            var sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i]; // sum= sum + myArray[i]
            }
            Console.WriteLine($"Sum of my arr is {sum}");

        }

        //7. Write a program to print all unique elements in an array.
        public static void UniqueElement()
        {
            var myArr = GetArrayFromUser();
            int[] arrayToPrint = new int[myArr.Length];
            var index = -1; // to know where to add element

            for (int i = 0; i <= myArr.Length; i++)
            {
                if (GetIndexOf(myArr[i], arrayToPrint) == -1)
                {
                    index++;

                    arrayToPrint[index] = myArr[i];
                }

            }
        }


        public static void PrintDistinctElem()
        {
            int[] array1 = GetArrayFromUser();
            // Invoke Distinct extension method.
            var result = array1.Distinct();
            // Display results.
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }

        //8. Write a program to merge two arrays of same size sorted in ascending order.
        public static void Merging2ArrAndSort()
        {
            int[] arr1 = GetArrayFromUser();
            int[] arr2 = GetArrayFromUser();
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int i, j, k;


            for (i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < arr2.Length; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            for (i = 0; i < arr3.Length; i++)
            {
                for (k = 0; k < arr3.Length - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }


            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }


        //9. Write a program to find maximum and minimum element in an array.
        public static void GetSmallestElem()
        {
            var myArray = GetArrayFromUser();
            var Min = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < Min)
                {
                    Min = myArray[i];
                }
            }
            Console.WriteLine($"Smallest: {Min}");
        }

        public static void GetBigestElem()
        {
            var myArray = GetArrayFromUser();
            var Max = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > Max)
                {
                    Max = myArray[i];
                }

            }
            Console.WriteLine($"Maximum: {Max}");
        }

        //10. Write a programin to separate odd and even integers in separate arrays
        public static void OddAndEven()
        {
            int[] myArr = GetArrayFromUser();
            int[] myArrOdd = new int[10];
            int[] myArrEven = new int[10];
            int i, j = 0, k = 0;
            for (i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    myArrEven[j] = myArr[i];
                    j++;
                }
                else
                {
                    myArrOdd[k] = myArr[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", myArrEven[i]);
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", myArrOdd[i]);
            }

        }

        //11. Write a program to sort elements of array in ascending order.
        public static void SortingAscending()
        {
            var myArray = GetArrayFromUser();

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }
            Console.WriteLine();
            foreach (var elem in myArray)
            {
                Console.WriteLine($"{elem}, ");
            }

        }

        //12. Write a program to sort elements of the array in descending order.
        public static void SortingDescending()
        {
            var myArray = GetArrayFromUser();

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }

            foreach (var elem in myArray)
            {
                Console.WriteLine($"{elem}, ");
            }
        }

        //13. Write a program to find the second largest element in an array.

        public static void SecondLargest()
        {
            int[] myArray = GetArrayFromUser();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }
            Console.WriteLine("The second largest is {0}", myArray[1]);


        }
        //14. Write a program to find the second smallest element in an array.

        public static void SecondSmallest()
        {
            int[] myArray = GetArrayFromUser();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }
            Console.WriteLine("The second smallest is {0}", myArray[1]);
        }

        //TODO 
        //Write a program for a 2D array of size 3x3 and print the matrix.

        public static void Matrix()
        {

            int[,] myMatrix =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < myMatrix.GetLength(1); col++)
                {
                    Console.WriteLine($"myArray[{row},{col}]={myMatrix[row, col]}");
                }
            }
        }

        //Write a program in C# Sharp for addition of two Matrices of same size

        public static void AdditionOfTwoMaTrices()
        {
            int i, j, n;
            int[,] a = new int[50, 50];
            int[,] b = new int[50, 50];
            int[,] rez = new int[50, 50];

            Console.Write("Input the size of the square matrix (less than 5): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the first matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input elements in the second matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("First Matrix");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    
                    Console.Write("{0}\t", a[i, j]);
            }
            Console.Write("\n");
            Console.WriteLine("Second Matrix");

            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                Console.Write("{0}\t", b[i, j]);
            }
            for (i = 0; i < n; i++)
                for (j = 0; j < n; j++)
                    rez[i, j] = a[i, j] + b[i, j];
            Console.Write("\n");
            Console.WriteLine("The result is......");
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < n; j++)
                    Console.Write("{0}\t", rez[i, j]);
            }

        }


        public static int[] GetArrayFromUser()
        {
            Console.WriteLine("Enter lenght of the Arr: ");
            int length = int.Parse(Console.ReadLine()); //get lenght
            int[] myArray = new int[length]; // inizialize
            for (int i = 0; i < length; i++)//add elem
            {
                Console.WriteLine($"Add Elemen {i}");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            return myArray;
        }
        public static int GetIndexOf(int element, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void SortingAsc()
        {
            var myArray = GetArrayFromUser();

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }


        }

        public static void SortingDesc()
        {
            var myArray = GetArrayFromUser();

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        var temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }

                }
            }

        }

    }

}
