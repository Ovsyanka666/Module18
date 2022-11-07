using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    
    /// <summary>
    /// Entry class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry method
        /// </summary>
        /// <param name="args"> Entre parameter </param>
        static void Main(string[] args)
        {
            string link = "https://www.youtube.com/watch?v=ex9tML6udCU";
            UserAnswerHandler.GetUserAnswer(link);
            Console.ReadLine();
        }
    }
    
}
