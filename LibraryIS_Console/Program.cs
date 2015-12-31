using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryIS_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandReceiver receiver = new CommandReceiver();
            receiver.Start();
        }
    }
}
