
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
            //------------
            //Prompting the user application purpose and how it can be operated.
            //------------

            Console.WriteLine("Welcome!This application will prompt you to create a data set which can be read,modified in later stages");

            //------------
            //Declaring variables
            //------------

            List<int> luckyNumbers = new List<int>(10);//Limits the list capacity by 10 numbers
            List<string> key = new List<string>();
            int menuOption = -1;


            //-------------
            // Creating a Menu for User to select between Adding or Read or Exit
            //------------

            while (menuOption != 0)

            {

                Console.WriteLine("Menu\n------\n1.ADD \n2.READ.\n0.EXIT: Press Enter key");
                Console.Write("Please enter a menu option:");
                menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("ADD Option will allow you to enter maximum 10 luckyNumbers");

                        PopulateList(luckyNumbers);

                        break;
                    case 2:
                        Console.WriteLine("READ Option will allow you to read the entered luckyNumbers");

                        Output(luckyNumbers);

                        break;
                    default:
                        Console.WriteLine("Invalid Input selected; Press Enterkey to exit");

                        Exit(key);

                        break;
                }
            }

        }


        //------------
        // Add entries to the list
        //------------

        static void PopulateList(List<int> inputStore)
        {
            string userInput;// Required for sentineval value
            do
            {
                Console.Write("Please enter maximum 10 lucky numbers, or \"done\" to finish the list: ");// This allows the user to enter data until the array is full, and keep the program loop running until exited with a sentinel value of done is entered.
                userInput = Console.ReadLine();

                try
                {

                    inputStore.Add(int.Parse(userInput)); // If this parse fails, none of the rest of the try block will execute.
                }
                catch
                {

                    if (userInput.ToLower().Trim() != "done") //Trim() function removes any leading whitespaces at the start or at the end;Lower() is used to prevent from case sensitive
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }
            } while (userInput.ToLower().Trim() != "done");
        }


        //-------------
        // Displays entries of the list
        //------------

        static void Output(List<int> myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"Item#.{i + 1}:" + myList[i]);
            }

        }

        //-------------
        // Exits of the menu
        //------------

        static void Exit(List<string> key)
        {
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\n Press enter key to end the program");
            }
        }
    }


}








