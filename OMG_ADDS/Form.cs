using OMG_ADDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OMG_ADDS
{
    public class Form
    {
        public string Date { get; set; }
        public int Bill_Number { get; set; }

        public void Generate_values()
        {
            Random random = new Random();
            Menu menu = new Menu();
            Date = DateTime.Now.ToString();
            Bill_Number=random.Next(202200000, 202299999);
        }
    }
}
