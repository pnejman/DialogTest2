using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            DialogEngine myDialogEngine = new DialogEngine("didi.xml"); //new instance of DialogEngine class with custom Constructor
            myDialogEngine.PlayScene("tavern1"); //play given scene
        }
    }
}
