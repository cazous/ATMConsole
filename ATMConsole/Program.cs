using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal class Program
    {
        static Menu menu = new Menu();
        static void Main(string[] args)
        {
            while (true)
            {
                menu.menu();
            }
        }
    }
}
