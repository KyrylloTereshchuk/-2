using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Program 
    {      
        static void Main()
        {

            IQueries querys = new Queries();

            ICommands commands = new Commands(querys);

            MenuDictionary dictionary = new MenuDictionary(commands);

            ExecutionProcess executionProcess = new ExecutionProcess(dictionary);

            executionProcess.Process();

        }

    }

}