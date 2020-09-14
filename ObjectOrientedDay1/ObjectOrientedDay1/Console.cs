using System;
using System.Collections.Generic;
using System.Text;

//working with namespaces
namespace Util
{
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }
    }
}
