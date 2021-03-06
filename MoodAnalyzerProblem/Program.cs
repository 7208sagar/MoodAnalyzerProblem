using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        private string message;
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MoodAnalyzer()
        {

        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="message">The message for intialization of message</param>
        public MoodAnalyzer(String message)
        {
            this.message = message;
        }
        /// <summary>
        /// Analyses the mood for happy or sad mood
        /// </summary>
        /// <returns>sad or happy when condtion is matched</returns>
        public string analyseMood()
        {
            try
            {
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }
    }
}