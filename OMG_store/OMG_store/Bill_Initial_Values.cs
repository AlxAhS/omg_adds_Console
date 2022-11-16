using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG_store
{
    public class Bill_Initial_Values
    {
       
        public static string Date { get; set; }
        public static int Bill_Number { get; set; }

        public void Generate_values()
        {
            Random random = new Random();
            Menu menu = new Menu();
            Date = DateTime.Now.ToString();
            Bill_Number = random.Next(202200000, 202299999);
        }
    }
}
