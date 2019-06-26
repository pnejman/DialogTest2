using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogTest2
{
    public class DialogLine
    {
        public string speakerName; //class level fields
        public string speakerMood;
        public string spokenLine;

        public DialogLine(string speakerName, string speakerMood, string spokenLine) //constructor allowing to add values
        {
            this.speakerName = speakerName;
            this.speakerMood = speakerMood;
            this.spokenLine = spokenLine;
        }
    }
}
