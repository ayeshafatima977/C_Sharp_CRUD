/*Title:Creat1e,Read,Update and Delete the data set
Purpose of the Project: An application that will maintain a dataset of items and allow the user to manipulate that dataset.
Author:Ayesha Fatima
Last Modified:15th August,2020
*/

using System;

namespace c_assignment_crud_ayeshafatima977
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------
            //Prompting the user application purpose and how it can be operated.
            //------------

            Console.WriteLine("Welcome!This application will prompt you to create a data set which can be read,updated and modified");

            //------------
            //Declaring variables
            //------------

            int[] inputArray = new int[10], storeArray = new int[10], outputArray = new int[10];
    
            int menuOption;
        
            //-------------
            //MenuOption Selection
            //--------------
        do
            {
                
                Console.WriteLine("Menu\n------\n1.Add \n2.Read \n3.Exit");
                Console.Write("Please enter a menu option:");
                menuOption = int.Parse(Console.ReadLine());
                switch(menuOption) 
                {

                    case 1:
                    Console.WriteLine("Running option {0}",menuOption);
                    break;
                    case 2: 
                    Console.WriteLine("Running option {0}",menuOption);
                    break;
                    case 3:
                    Console.WriteLine("Exiting program");
                    break;
                    default :
                    Console.WriteLine("Invalid option selected.");
                    break;
                }

            }while(menuOption==2 && menuOption!= 3);//When menuoption is not equal to start filling the data set to 10 values to display the output automatically
            
            //Calling output Array

            PopulateArray(inputArray);  //Calling input Array for userInput for dataset
        }
        //-----------
        //Adding elements to Array
        //------------
        static void PopulateArray(int[] Array)
        {
            string userInput;// Required for sentineval value
            int storeArray = 0;//The no. of elements that we actually care about in the array
            int[] inputArray = new int[10];
            do
            {
                
            
                int userInputInt;
                Console.Write("Please enter a integer, or \"quit\" to output: ");
                userInput = Console.ReadLine();

                try

                {
                    // If this parse fails, none of the rest of the try block will execute, meaning we won't add garbage data
                    // to our array, and the logical size will not go up.
                    userInputInt = int.Parse(userInput); //Converting string to integer

                    inputArray[storeArray] = userInputInt;
                    storeArray++;
                }
                catch
                {
                    // To let user know wthey have entered an invalid input

                    if (userInput.ToLower().Trim() != "quit")
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }

                // Exit the program when the user enters a sentinel value Quit

            } while (storeArray < inputArray.Length && userInput.ToLower().Trim() != "quit");

            //----------------
            //Displaying Output to the User:
            //----------------
             /*      static void Display(int[] Array)
            {*/
               // int storeArray = 0;
              //  int[] inputArray = new int[10];
                int[] outputArray = new int[10];

                for (int i = 0; i < storeArray; i++)
                {
                    Console.Write("The dataset contains value of:");
                    outputArray[i]=inputArray[i];
                    Console.WriteLine(outputArray[i]); // Console.WriteLine(inputArray[i]);
                }
            
            
 

        }
    }
}






