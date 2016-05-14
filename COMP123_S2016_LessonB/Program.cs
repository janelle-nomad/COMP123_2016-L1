using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 * 
 *   Author: Janelle Heron 
 *   Date Created: May 13 2016
 *   Date Modified: May 13 2016
 *   Student ID: 300839820
 *   Description: This program demonstrates Github and version control best practices. 
 *   We also explore unit testing
 *    
 *   Version: 0.7 - Added minor spelling corrections  
 * 
*/
namespace COMP123_S2016_LessonB

    /**
     *  @ This is the driver class for our program
     *  
     *  @class Program
     */
{
    public class Program
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

            OutputStringToConsole("Enter UserName: ", false);
            UserName = Console.ReadLine();

            Console.WriteLine("\n==============================");
            Console.WriteLine("You Entered: " + UserName + "\n");
            return UserName;
        }

        /**
         * This method writes a string to the console, 
         * Parameters allow the user to choose to add a newline character
         * 
         * @method OutputStringToConsole
         * @param {string} outputString
         * @param {bool} hasNewLine
         * @return {string} outputString
         */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {

            // Refactored using the ternary operator
            string suffixString = hasNewLine ? "\n" : ""; // ternary operator

            Console.Write(outputString + suffixString);

            return outputString;
        }

        #endregion
    }
}
