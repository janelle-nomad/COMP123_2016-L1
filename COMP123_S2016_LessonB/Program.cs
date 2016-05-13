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
        Version: 0.2 - Added GetUsername
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

            Console.WriteLine("Enter Username:  ");
            UserName = Console.ReadLine();

            Console.WriteLine("/n=========================");
            Console.WriteLine("You entered: " + UserName);
            return UserName;
        }
        #endregion
    }
}
