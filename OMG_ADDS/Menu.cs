using OMG_ADDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

    public class Menu
    {
    public static string Date { get; set; }
    public static int Bill_Number { get; set; }
    public static string Client_Name { get; set; }
    public static string Client_ID { get; set; }
    public static string Product_Description { get; set; }
    public static string Product_Value { get; set; }

    Form form = new Form();
    Export_document export = new Export_document();

        public void Home_menu()
        {
            byte option = 0;
            string i = "";

             do
             {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("\n\t\t OMG Imports Bill-Generator");
                Console.WriteLine("\t\t\t\t\t\t   by: Alx.AhS");
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine("\n\t\t*** BILL GENERATOR MENU ***");
                Console.WriteLine("\t\t--------- Options ---------");
                Console.WriteLine("\t1. CLIENT NAME: {0}", Client_Name);
                Console.WriteLine("\t2. CLIENT ID (NIT / CC): {0}", Client_ID);
                Console.WriteLine("\t3. PRODUCT DESCRIPTION: {0}", Product_Description);
                Console.WriteLine("\t4. PRODUCT VALUE: $ {0} COP", Product_Value);
                Console.WriteLine("\t5. GENERATE PDF {0}", i);
                Console.WriteLine("\t6. EXIT ");
                Console.Write("\nINSERT OPTION: ");
                option = Convert.ToByte(Console.ReadLine());
       
                 switch(option)
                 {
                    case 1:
                        if (Client_Name == null) 
                        {form.Generate_values();
                        Date = form.Date;
                        Bill_Number = form.Bill_Number;
                        }
                        Console.Write("1. CLIENT NAME: ");
                        Client_Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("2. CLIENT ID: ");
                       Client_ID = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("3. PRODUCT DESCRIPTION: ");
                        Product_Description= Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("4. PRODUCT VALUE: $ ");
                        Product_Value = Console.ReadLine();
                        break;
                    case 5:
                    if (option == 5)
                    {
                        i = " ... (file created successfully in the directory C:\\) ";
                    }
                    Export_document export = new Export_document();
                    export.Exportpdf();
                    break;
                 }
             } while (option != 6);
        }
    }

