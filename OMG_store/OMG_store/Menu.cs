﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMG_store
{
    public class Menu
    {
        
        Generate_PDF_file export = new Generate_PDF_file();

        public void Home_menu()
        {
                string option = "";
                byte select = 0;

                Console.Clear();
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n\t\t OMG Imports Bill-Generator");
                Console.WriteLine("\t\t\t\t\t\t by: Alx.AhS");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("\n\t\t*** BILL GENERATOR MENU ***");
             

                Console.Write("\n1. CLIENT NAME: ");
                Client_info.Client_Name = Console.ReadLine();
                Console.Write("2. CLIENT ID: ");
                Client_info.Client_ID = Console.ReadLine();
                Console.Write("3.PRODUCT DESCRIPTION: ");
                Product_info.Product_Description = Console.ReadLine();
                Console.Write("4.PRODUCT VALUE (COP): $ ");
                Product_info.Product_Value = Console.ReadLine();

                Console.Write("CONTINUE? (Y/N): ");
                option = Console.ReadLine();

                while ((option != "Y") && (option != "y"))
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("\t\t--SELECT THE OPTION FOR REPLACE--\n");
                    Console.WriteLine("\t1. CLIENT NAME: {0}", Client_info.Client_Name);
                    Console.WriteLine("\t2. CLIENT ID (NIT / CC): {0}", Client_info.Client_ID);
                    Console.WriteLine("\t3. PRODUCT DESCRIPTION: {0}", Product_info.Product_Description);
                    Console.WriteLine("\t4. PRODUCT VALUE: $ {0} COP", Product_info.Product_Value);
                    Console.WriteLine("\t5. CREATE PDF FILE ");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.Write("\nOPTION: ");
                    select = Convert.ToByte(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            Console.Write("1. CLIENT NAME: ");
                            Client_info.Client_Name = Console.ReadLine();
                            Menu_Updated();
                    break;
                        case 2:
                            Console.Write("2. CLIENT ID: ");
                            Client_info.Client_ID = Console.ReadLine();
                            Menu_Updated();
                    break;
                        case 3:
                            Console.Write("3. PRODUCT DESCRIPTION: ");
                            Product_info.Product_Description = Console.ReadLine();
                            Menu_Updated();
                    break;
                        case 4:
                            Console.Write("4. PRODUCT VALUE: $ ");
                            Product_info.Product_Value = Console.ReadLine();
                            Menu_Updated();
                            break;
                    }
                    Console.Write("\nCONTINUE? (Y/N): ");
                    option = Console.ReadLine();
                }
                    Console.WriteLine("\n\n************************************************************\nYour bill was generated successfully in the folder OMG_bills \n\t      (folder created in your desktop) \n************************************************************\n\n");
                    Generate_PDF_file export = new Generate_PDF_file();
                    export.Exportpdf();
        }

        public void Menu_Updated() 
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t\t--SELECT THE OPTION FOR REPLACE--\n");
            Console.WriteLine("\t1. CLIENT NAME: {0}", Client_info.Client_Name);
            Console.WriteLine("\t2. CLIENT ID (NIT / CC): {0}", Client_info.Client_ID);
            Console.WriteLine("\t3. PRODUCT DESCRIPTION: {0}", Product_info.Product_Description);
            Console.WriteLine("\t4. PRODUCT VALUE: $ {0} COP", Product_info.Product_Value);
            Console.WriteLine("\t5. CREATE PDF FILE ");
            Console.WriteLine("------------------------------------------------------------");
        }



    }
}
