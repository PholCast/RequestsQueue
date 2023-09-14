using System;
using System.Collections.Generic;
using System.Diagnostics; // For measuring execution time
namespace RequestsQueue
{

    class Program
    {
        static void Main(string[] args)
        {          
            Menu.ChooseOptionMenu();


            List<int> numbersTest = new List<int>() {100};

            for (int i = 0; i<numbersTest.Count; i++) 
            {
                Test.testCode(numbersTest[i]);
            }
        }
    }
}