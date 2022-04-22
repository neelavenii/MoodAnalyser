using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyserproject;

namespace MoodAnalyseTestClass

{
    [TestClass]
    public class MoodAnalyseTestClass
    {
        [DataRow("I am in Happy mood","happy")]
        [DataRow("I am in sad mood", "sad")]
        [TestMethod]
        public void GivenMessageShouldReturnMood(string message,string expected)
        {
            ///AAA Methodology
            ///Arrange
            
           
            MoodAnalyser mood = new MoodAnalyser(message);

            ///Act
            string actual = mood.AnalyserMood();

            ///Assert
            Assert.AreEqual(expected, actual);


        }

    }
}
