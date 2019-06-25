using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DialogTest2
{
    class Program
    {
        public DialogEngine my_dialog = new DialogEngine();

        static void Main(string[] args)
        {
            my_dialog.PlayScene("tavern");
        }
    }
}
