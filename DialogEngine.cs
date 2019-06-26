using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DialogTest2
{
    public class DialogEngine
    {
        private string dialogPath; //my private class-level fields
        private XDocument dialogFile;

        public DialogEngine(string dialogPath) //custom public Contructor for this class, requiring one string with file path
        {
            XDocument dialogFile = XDocument.Load(dialogPath); //open XML file
            this.dialogPath = dialogPath; //save these values to class fields
            this.dialogFile = dialogFile;
        }

        public void PlayScene(string scene)
        {
            XMLProcessor xmlProcessor = new XMLProcessor(this.dialogFile, scene); //new instance of XMLProcessor class with custom Constructor 
            DialogProcessor dialogProcessor = new DialogProcessor(xmlProcessor.processedSceneLines); //new instance of DialogProcessor class with custom Constructor
        }
    }
}
