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
        XMLProcessor xmlProcessor;
        DialogProcessor dialogProcessor;
        public DialogEngine(XMLProcessor xmlProcessor, DialogProcessor dialogProcessor) //custom public Contructor for this class, requiring one string with file path
        {
            this.xmlProcessor = xmlProcessor;
            this.dialogProcessor = dialogProcessor;
        }

        public void PlayScene(string scene)
        {
            xmlProcessor.PopulateList(scene);
            dialogProcessor.Work(xmlProcessor.processedSceneLines);
        }
    }
}
