using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsQueue
{
    public static class Menu
    {
        public static void ChooseOptionMenu() //If auto is -1 we ask for an input
        {
            
            int option = 0;
            int cont = 1;
            bool continueMenu = true; 

            //for instance
            while (continueMenu)
            {
    
                    ShowMenu();
                    option = Convert.ToInt32(Console.ReadLine()); //Using inputs
               
                switch (option)
                {
                    case 1:



                        int requestNumber = cont;

                        cont++;

                            Console.Write("Enter Customer name: ");

                            string name = Console.ReadLine();

                            Console.Write("Enter problem description: ");

                            string description = Console.ReadLine();

                            Console.Write("Enter Urgency Level: ");

                            int urgencyLevel = Convert.ToInt32(Console.ReadLine());
                        
                        
                        Technical_Support.AddRequest(requestNumber,name,description,urgencyLevel);
                        break;
                    case 2:
                        Technical_Support.AttendToRequests(); 
                        break;
                    case 3:
                        Technical_Support.ShowRequests();
                        break;
                    case 4:

                        Console.WriteLine("Enter the request number you want to update:");
                        int requestNumberToUpdate = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the new urgency level:");
                        int newUrgencyLevel = Convert.ToInt32(Console.ReadLine());

                        Technical_Support.UpdateUrgencyLevel(requestNumberToUpdate,newUrgencyLevel);
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
