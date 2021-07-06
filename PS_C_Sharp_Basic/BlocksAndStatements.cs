using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS_C_Sharp_Basic
{
    class BlocksAndStatements
    {
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
    }
}
