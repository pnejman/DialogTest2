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
        public XMLProcessor xmlProcessor = new XMLProcessor();
        public XDocument dialogFile = XDocument.Load("didi.xml");

        public void PlayScene(string sceneSelector)
        {
            xmlProcessor.LoadSceneFromXML(sceneSelector);
        }
    }
}
