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
            int[] inputArray=new int[10],storeArray=new int[10],outputArray=new int[10];//Physical size of array
            int inputArrayLogical=0;//storeArrayLogical=0,outputArrayLogical=0;//Number of things in the array we care about
            string userInput;
           // -----------
            // Input Logic:Requesting user to enter integers upto 10 values or type quit(case sensitive) to output;
            //Obtained from Even odd Sorter Solution repository by James(Refer Citaion simmary in README for link)
            // -----------
           
            do
            {
                int userInputInt;

                Console.Write("Please enter a integer, or \"quit\" to output: ");
                userInput = Console.ReadLine(); 
                
                try
                {
                    // If this parse fails, none of the rest of the try block will execute, meaning we won't add garbage data
                    // to our array, and the logical size will not go up.
                    userInputInt = int.Parse(userInput);//Converting string to integer

                    // Order of the next two lines is important because logical size serves as the index of the next available spot.
                    inputArray[inputArrayLogical] = userInputInt;
                    inputArrayLogical++;
                }
                catch
                {
                    // If the user has entered "done", the try will still fail, but because it's valid for our program,
                    // we don't want to tell the user they entered something bad.
                    if (userInput.ToLower().Trim() != "quit")
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }

            // While the array is not full (number of things we care about is less than max things)
            // (number of boxes on shelf is less than size of shelf), and the user has not entered
            // the sentinel value.
            } while(inputArrayLogical < inputArray.Length && userInput.ToLower().Trim() != "quit");



        }

        
    }
}




