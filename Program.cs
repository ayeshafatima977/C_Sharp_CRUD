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

            PopulateArray(inputArray);  //Calling input Array for userInput for dataset
        }

            //-----------
            //Adding elements to Array
            //------------
        static void PopulateArray(int[] storeArray)
        {
            string userInput;
            int inputArrayLogical = 1;
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

                    inputArray[inputArrayLogical] = userInputInt;
                    inputArrayLogical++;
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

            } while (inputArrayLogical < inputArray.Length && userInput.ToLower().Trim() != "quit");

            //----------------
            //Displaying Output to the User:
            //----------------

            for (int i = 1; i < inputArrayLogical; i++)
            {
                Console.Write("The dataset contains value of:");
                Console.WriteLine(inputArray[i]);
            }


        }


    }

}


/*  static char GetValidChar(string prompt,char menuItem)
{
  bool valid=false;
  int myChar=-1;

  do
  {
      char menuItem;
      Console.WriteLine("Please select option prompt  'A','R' or 'E'");
      menuItem = char.ToUpper(char.Parse(Console.ReadLine()));
      try
      {

          myChar = char.ToUpper(char.Parse(Console.ReadLine()));
          if (menuItem != 'A' && menuItem != 'R' && menuItem != 'E')
          {
              throw new Exception("Invalid menu Item selected");
          }
          valid = true;
      }
      catch (Exception ex)
      {
          Console.WriteLine($"Parse Failed:{ex.Message}");

      } while (!valid) ;
      return myChar;

  }*/

/*for(int i=0;i<inputArrayLogical;i++)
{
    if(inputArray[i]<10)
    {
        Console.WriteLineLine("Enter maximum 10 elements");
newArray[newArrayLogical] = inputArray[i];
newArrayLogical++;   
    }
    else
    {
        
    }*/




