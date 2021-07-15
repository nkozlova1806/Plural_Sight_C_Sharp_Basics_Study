using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS_C_Sharp_Basic
{
    class BlocksAndStatements
    {
        #region Blocks and Statements
        //public int BlocksAndStatementsMethod()
        public void BlocksAndStatementsMethod()
        {
            string x = "59";
            //int y = 11;
            double y = 11;
            //string r = x + y;
            double r = Int32.Parse(x) + y;
            //int r = Int32.Parse(x) + y; // can't convert double to int

            if (r > 30)
            {
                Console.WriteLine(r);
            }
            if (r == 5911)
            {
                Console.WriteLine("Wrong");
            }
            if (r == 70)
            {
                Console.WriteLine("Good");
            }

        }
        #endregion

        #region CreatingArray
        public void CreatingArrays()
        {
            var array1 = new int[5];
            array1[0] = 10;
            array1[1] = 20;
            array1[2] = 30;
            array1[3] = 40;
            array1[4] = 50;

            var array2 = new string[3] { "value0", "value1", "value2" };

            foreach (var value in array1)
            {
                Console.WriteLine(value);
            }

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            foreach (var item in array2)
            {
                Console.WriteLine(item + "TEST");
            }

            var newArray = array2.ToList();
            foreach (var item in array1)
            {
                newArray.Add(item.ToString());
            }
        }
        #endregion

        #region LoopingThruArray
        
        int[] array3 = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

        public void LoopingThruArray()
        {
            foreach (var i in array3)
            {
                Console.WriteLine(i);
            }

            //reverse order starting from the last array element
            for (int i = array3.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array3[i]);
            }

            //reverse order starting from the first array element
            for (int i = 0; i <= array3.Length - 1; i++)
            {
                var currentValue = array3[array3.Length - i - 1];
                Console.WriteLine(currentValue);
            }

            //calculating sum of array elements
            int sum = 0;
            foreach (var item in array3)
            {
                sum += item;
            }
            Console.WriteLine($"Sum is " + sum);
        }
        #endregion

        #region Looping Through the List
        public void LoopingThruTheList()
        {
            var arrayList = new List<int>();
            arrayList.Add(21);
            arrayList.Add(22);
            arrayList.Add(23);
            arrayList.Add(24);
            arrayList.Add(25);
            arrayList.Add(26);
            arrayList.Add(27);
            arrayList.Add(28);
            arrayList.Add(29);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //reverse order starting from the last array element
            for (int i = arrayList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(arrayList[i]);
            }

            //reverse order starting from the first array element
            for (int i = 0; i <= arrayList.Count - 1; i++)
            {
                int currentValue = arrayList[arrayList.Count - i - 1];
                Console.WriteLine(currentValue);
            }

            //calculating sum of array elements
            int sum = 0;
            foreach (var item in arrayList)
            {
                sum += item;
            }
            Console.WriteLine($"Sum is " + sum);

            //adding int array into list array
            var convertedArray = array3.ToList();
            foreach (int item in convertedArray)
            {
                arrayList.Add(item);
            }
            //OR
            //foreach (int item in array3)
            //{
            //    arrayList.Add(item);
            //}

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //calculating sum after array was expanded
            int sumModified = 0;
            foreach (var item in arrayList)
            {
                sumModified += item;
            }
            Console.WriteLine($"Sum after array was modified is " + sumModified);

            //checking calculation was correct
            if (sumModified > 225)
            {
                Console.WriteLine("List was modified successfully!");
            }
            if (sumModified == sum)
            {
                Console.WriteLine("Something went wrong!");
                arrayList.Clear();
            }
        }
        #endregion

        #region Odd Elements
        public void ReturnEvenArrayElements()
        {
            int[] array4 = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            foreach (var item in array4)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"The even array element is " + item);
                }
            }
        }
        #endregion

        #region Copy Elements From Array with condition
        public void CopyElementsOnCondition()
        {
            int[] array5 = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            var arrayListCopyTo = new List<int>();

            foreach (var item in array5)
            {
                if (item > 10)
                {
                    arrayListCopyTo.Add(item);
                }
            }

            foreach (var item in arrayListCopyTo)
            {
                Console.WriteLine($"This array element is > 10: " + item);
            }
        }
        #endregion

        #region Find Max Element in Array
        public void MaxArrayElement()
        {
            int[] array6 = new int[] { 110,12,13,14,15,16,17,18,19,200 };
            int maxValue = 0;

            foreach (var item in array6)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }
            
            Console.WriteLine($"This array element has max value: " + maxValue);
        }
        #endregion

        #region Find Min Element in Array
        public void MinArrayElement()
        {
            int[] array7 = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 200 };
            int minValue = array7[0];

            for (int i = 0; i < array7.Length; i++)
            {
                if (array7[i] < minValue)
                {
                    minValue = array7[i];
                }
            }

            Console.WriteLine($"This array element has min value: " + minValue);
        }
        #endregion

        #region Find Similar Elements in Array
        public void SimilarArrayElements()
        {
            int[] array8 = new int[] { 7, 12, 13, 17, 15, 16, 7, 18, 19, 27 };
            var numberOf7s = 0;

            foreach (var item in array8)
            {
                if (item == 7)
                {
                    numberOf7s++;
                }
            }

            Console.WriteLine($"This is the number of 7 in array: " + numberOf7s);
        }
        #endregion

        #region Calculate Similar Elements in Array
        public void CalculateSimilarArrayElements()
        {
            int[] array9 = new int[] { 7, 12, 13, 17, 15, 16, 7, 18, 19, 7 };
            var numberOf7s = 0;

            foreach (var item in array9)
            {
                if (item == 7)
                {
                    numberOf7s++;
                }
            }

            if (numberOf7s == 3)
            {
                Console.WriteLine($"Number of same values is 3!");
            }
            else
            {
                Console.WriteLine($"Number of same values is not 3!");
            }
            
        }
        #endregion
    }
}
