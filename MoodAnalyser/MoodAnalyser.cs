using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserproject
{
    public class MoodAnalyser
    {
        public string message;  // I am in Happy mood
        public MoodAnalyser (string message)
        {
            this.message = message;
        }
        public string AnalyserMood()
        {
            if (message.ToLower().Contains("happy"))
                return "happy";
            else
                return "sad";
        }
    }
}
