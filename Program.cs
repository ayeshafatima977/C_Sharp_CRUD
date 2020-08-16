/*Title:Creat1e,Read,Update and Delete the data set
Purpose of the Project: An application that will maintain a dataset of items and allow the user to manipulate that dataset.
Author:Ayesha Fatima
Last Modified:15th August,2020
*/

using System;
using System.Collections.Generic;

namespace c_assignment_crud_ayeshafatima977
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(10);//Limits the list capacity by 10 numbers
            List<string> key = new List<string>();
            int menuOption = -1;
            while (menuOption != 0)

            {

                Console.WriteLine("Menu\n------\n1.Add \n2.Read");
                Console.Write("Please enter a menu option:");
                menuOption = int.Parse(Console.ReadLine());
                switch (menuOption)
                {

                    case 1:
                        PopulateList(numbers);  //Calling input Array for userInput for dataset
                        break;
                    case 2:
                        Output(numbers);
                        break;

                    /* case 3:
                     EditList(numbers);
                     break;*/

                    default:
                        Console.WriteLine(" Invalid Input selected; Press Enterkey to exit");
                        Exit(key);

                        break;
                }
            }

        }

        static void PopulateList(List<int> inputStore)
        {
            string userInput;
            do
            {
                Console.Write("Please enter a integer, or \"done\" to finish the list: ");

                userInput = Console.ReadLine();

                try
                {
                    inputStore.Add(int.Parse(userInput));
                }
                catch
                {
                    if (userInput.ToLower().Trim() != "done")
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }
            } while (userInput.ToLower().Trim() != "done");
        }

        // Display

        static void Output(List<int> theList)
        {
            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine(theList[i]);
            }

        }
        //Edit

  /*      static void EditList(List<int> myList)
        {
            myList.Add(15);
        }
*/

        // Exit
        static void Exit(List<string> key)
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press enter key to end the program");
            }
        }
    }

}