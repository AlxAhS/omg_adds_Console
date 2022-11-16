using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Install iText7 in NuGet packages 

namespace OMG_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill_Initial_Values form = new Bill_Initial_Values();
            Menu menu = new Menu();
            
            form.Generate_values();
            menu.Home_menu();
        }
    }
}
