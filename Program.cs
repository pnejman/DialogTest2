using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DialogTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument dialogFile = XDocument.Load("didi.xml"); //open XML file

            DialogEngine myDialogEngine = new DialogEngine( new XMLProcessor(dialogFile), new DialogProcessor()); //new instance of DialogEngine class with custom Constructor
            myDialogEngine.PlayScene("tavern1"); //play given scene
        }
    }
}
