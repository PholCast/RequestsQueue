using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsQueue
{
    public static class Menu
    {
        public static void ChooseOptionMenu(int auto = -1)
        {
            int count_option = 0;//in case int auto is not given
            int option = 0;

            bool continueMenu = true; 

            List<int> options = new List<int>() { 1,2,3};//for instance
            while (continueMenu)
            {
                if (auto == -1)
                {
                    ShowMenu();
                    option = Convert.ToInt32(Console.ReadLine());
                }
                //list with automatic options?
                else if (count_option==options.Count)
                {
                    continueMenu = false;
                    
                    
                }
                else
                {
                    option = options[count_option];
                    count_option++;
                   
                }

                switch (option)
                {
                    case 1:

                        Technical_Support.AddRequest();
                        break;
                    case 2:
                        Technical_Support.AttendToRequests(); 
                        break;
                    case 3:
                        Technical_Support.ShowRequests();
                        break;
                    case 4: 
                        Technical_Support.UpdateUrgencyLevel();
                        break;
                    case 5:
                        continueMenu = false;
                        break;
                }
            }

        }

        public static void ShowMenu()
        {
            Console.WriteLine("Technical Support:\n" +
                "\n1.Add Request" +
                "\n2.Attend To Requests" +
                "\n3.Show Requests" +
                "\n4.Update Urgency Level" +
                "\n5.Exit" +
                "\nChoose an option:");
        }
    }
}
