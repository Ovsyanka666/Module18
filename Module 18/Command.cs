using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    /// <summary>
    /// Class describes general functionality of commands
    /// </summary>
    internal abstract class Command
    {
        public abstract void Run(string link);
    }
}
