using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace OMG_ADDS
{
    public class Export_document
    {
        public void Exportpdf()
        {
            // Must have write permissions to the path folder
            PdfWriter writer = new PdfWriter("C:\\OMG_Cuentadecobro.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("OMG IMPORTS")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(26);

            Paragraph subheader = new Paragraph("Cuenta de cobro")
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);

            LineSeparator ls = new LineSeparator(new SolidLine());

            Paragraph Text1 = new Paragraph(
            "\nFecha: " + Menu.Date +"\nCuenta de cobro N°: " +Menu.Bill_Number +"\n\n")
               .SetTextAlignment(TextAlignment.LEFT)
               .SetFontSize(14);

            Paragraph Text2 = new Paragraph(
            Menu.Client_Name)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetBold()
               .SetFontSize(20);

            Paragraph Text3 = new Paragraph(
                Menu.Client_ID)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(14);

            Paragraph Text4 = new Paragraph(
            "\nDebe a:" )
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(14);

            Paragraph Text5 = new Paragraph(
            "JOSE GABRIEL AHUMADA SOTO")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBold()
            .SetFontSize(16);

            Paragraph Text6 = new Paragraph(
            "NIT 98715623-4 (Régimen simplificado)" +
            "\nCra 57 # 27-25, Bello Antioquia" +
            "\n3127694461\n\n")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(14);

            Paragraph Text7 = new Paragraph(
            "\nLa suma de $" + Menu.Product_Value + " por concepto de " + Menu.Product_Description + ".\n")
            .SetTextAlignment(TextAlignment.JUSTIFIED)
            .SetFontSize(12);

            Paragraph Text8 = new Paragraph(
            "\nPara efectos de retención en la fuente declaro que pertenezco a la categoría de empleado. El 80% de mis ingresos o más, provienen de ejercer mi actividad como empleado y como indemente y soy declarante de impuesto de renta. \n\n\n\n")
            .SetTextAlignment(TextAlignment.JUSTIFIED)
            .SetFontSize(12);

            Paragraph Text9 = new Paragraph(
            "Favor pagar a nombre de ")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(12);

            Paragraph Text10 = new Paragraph(
            "JOSE GABRIEL AHUMADA SOTO ")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBold()
            .SetFontSize(14);

            Paragraph Text11 = new Paragraph(
            "por el medio de pago más conveniente.")
            .SetTextAlignment(TextAlignment.CENTER)
            .SetFontSize(12);

            //Final form: Text structure
            document.Add(header);
            document.Add(subheader);
            document.Add(ls);
            document.Add(Text1);
            document.Add(Text2);
            document.Add(Text3);
            document.Add(Text4);
            document.Add(Text5);
            document.Add(Text6);
            document.Add(Text7);
            document.Add(Text8);
            document.Add(Text9);
            document.Add(Text10);
            document.Add(Text11);

            document.Close();
        }

    }
}
