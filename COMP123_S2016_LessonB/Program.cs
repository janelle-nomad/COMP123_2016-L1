using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /*
        Janelle Heron AKA Janelle Nomad
        Date: 2016-05-13
        Student Number: 300839820
        Description: This program demonstrates Github and best practices, we also explore unit testing 
        Version: 0.4 - Extracted OutputString to console from our GetUsername method
        
    */
namespace COMP123_S2016_LessonB

    /**
     *  @ This is the driver class for our program
     *  
     *  @class Program
     */
{
    class Program
    {
        /**
         * 
         * @param {string[]} args
         * @Constructor Main
         */
        static void Main(string[] args)

        {
            GetUserName();
        }

        /**
         * 
         *  @This method creates a username from the console
         *  @return {string} Username 
         */
        #region
        public static string GetUserName()
        {

            //Initialize Variables
            String UserName = "";

            OutputStringToConsole("Enter Username: ", true);
            UserName = Console.ReadLine();

            Console.WriteLine("\n==============================\n");
            Console.WriteLine("You entered: " + UserName);
            return UserName;
        }

        /**
         * This method writes a string to the console, 
         * Parameters allow the user to choose to add a newline character
         * @method OutputStringToCOnsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return {string} outputString
         */
        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {

            if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }
           
            Console.Write(outputString);
            return outputString;
        }

        #endregion
    }
}
