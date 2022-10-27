using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;



namespace OMG_ADDS
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Menu menu = new Menu(); 
            menu.Home_menu();

        }
    }
}
