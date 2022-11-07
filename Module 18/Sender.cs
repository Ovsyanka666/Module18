using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    /// <summary>
    /// Class describes command's way
    /// </summary>
    class Sender
    {

        Command command;

        public void SetCommand(Command _command)
        {
            command = _command;
        }

        public void Run(string link)
        {
            command.Run(link);
        }

    }
}
