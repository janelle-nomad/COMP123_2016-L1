using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP123_S2016_LessonB.Program;


namespace Lesson1_TestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange

            string outputString = "Enter UserName: ";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter UserName: ";

            //Act
            actualResult = OutputStringToConsole(outputString, hasNewLine) ;
            
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
