using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DialogTest2
{
    public class XMLProcessor
    {
        public List<DialogLine> processedSceneLines = new List<DialogLine>(); //public list of dialog lines

        public XMLProcessor(XDocument dialogFile) //custom public Contructor for this class, requiring one XDocument and one scene
        {
            DialogFile = dialogFile;
        }

        public XDocument DialogFile { get; }

        public void PopulateList(string scene) //custom public Contructor for this class, requiring one XDocument and one scene
        {
            foreach (var sceneLine in this.DialogFile.Root.Elements(scene).Elements("line")) //some query language here. You should read it backward. Take each element "line" in element "scene(variable)" in Root in dialogFile, name it sceneLine and:
            {
                string speakerName = sceneLine.Attribute("name").Value.ToString(); //extract data from dialogFile
                string speakerMood = sceneLine.Attribute("mood").Value.ToString();
                string spokenLine = sceneLine.Value.ToString();

                processedSceneLines.Add(new DialogLine(speakerName, speakerMood, spokenLine)); //Add to list. DialogLine requires 3 strings in this custom constructor.
            }
        }

    }
}
