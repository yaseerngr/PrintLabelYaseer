using Neodynamic.SDK.Printing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;

namespace D2ZParcelPrint
{
    public class CreateEParcelcs 
    {
        public HttpResponseMessage createEarcel_2D_new_PDF()
        {
            ThermalLabel tLabel = new ThermalLabel(Neodynamic.SDK.Printing.UnitType.Inch, 4, 6);
            ThermalLabel tLabel2 = new ThermalLabel(Neodynamic.SDK.Printing.UnitType.Inch, 4, 6);

            //ThermalLabel.LicenseOwner = "D2Z Pty Ltd-Ultimate Edition-Developer License";
            //ThermalLabel.LicenseKey = "EZJ6Y5A877F82CA6MXBYBWU3S3S54QVVL4MW39RN24LZLCP6GE2A";

            //ImageItem nbdaLogo = new ImageItem(0.03, 0.01);
            //nbdaLogo.SourceFile = "dfdf";
            //nbdaLogo.Width = 4;
            //nbdaLogo.LockAspectRatio = LockAspectRatio.WidthBased;
            //nbdaLogo.MonochromeSettings.DitherMethod = DitherMethod.Threshold;
            //nbdaLogo.MonochromeSettings.Threshold = 50;
            //nbdaLogo.MonochromeSettings.ReverseEffect = false;

            BarcodeItem qritem = new BarcodeItem(3, 1.15, 0.7, 0.7, BarcodeSymbology.DataMatrix, "0123456789ABCDEF");
            qritem.DisplayCode = false;
            qritem.DataField = "QRCodes";
            qritem.DataMatrixModuleSize = 0.027;
            qritem.Width = 0.87;
            qritem.Height = 0.87;
            qritem.Symbology = BarcodeSymbology.DataMatrix;
            qritem.DataMatrixProcessTilde = true;


            #region MyRegion

            
            TextItem postpaid = new TextItem(3.1, 0.75, 2, 0.5, "");
            postpaid.Font.Name = "Times new Roman";
            postpaid.DataField = "postpaid";
            postpaid.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            postpaid.Font.Size = 8;

            TextItem txt1  = new TextItem(1, 0.75, 2, 0.5, "");
            txt1.Font.Name = "Times new Roman";
            txt1.DataField = "l1";
            txt1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt1.Font.Size = 17;
            txt1.Font.Bold = true;

            TextItem txt1_1 = new TextItem(0.2, 0.85, 2, 0.5, "");
            txt1_1.Font.Name = "Times new Roman";
            txt1_1.DataField = "to1";
            txt1_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt1_1.Font.Size = 12;
            txt1_1.Font.Bold = true;

            LineShapeItem txt1_2 = new LineShapeItem(0.025, 1.16, 2.8, 0.01);
            txt1_2.Orientation = LineOrientation.Horizontal;
            txt1_2.StrokeThickness = 0.015;

            TextItem txt2 = new TextItem(0.2, 1.2, 3.5, 0.25, "");
            txt2.DataField = "Delname";
            txt2.Font.Name = "Times new Roman";
            txt2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt2.Font.Size = 12;
            txt1.TextAlignment = TextAlignment.Left;

            TextItem txt3 = new TextItem(0.2, 1.4, 3.5, 0.25, "");
            txt3.DataField = "Deladdr1";
            txt3.Font.Name = "Times new Roman";
            txt3.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt3.Font.Size = 12;
            txt3.TextAlignment = TextAlignment.Left;

            TextItem txt4 = new TextItem(0.2, 1.6, 3.5, 0.25, "");
            txt4.DataField = "Deladdr2";
            txt4.Font.Name = "Times new Roman";
            txt4.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt4.Font.Size = 12;
            txt4.TextAlignment = TextAlignment.Left;

            LineShapeItem txt8 = new LineShapeItem(0.025, 2, 2.8, 0.01);
            txt8.Orientation = LineOrientation.Horizontal;
            txt8.StrokeThickness = 0.015;

            TextItem txt5 = new TextItem(0.2, 1.9, 2.5, 0.25, "");
            txt5.DataField = "delpost";
            txt5.Font.Name = "Times new Roman";
            txt5.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt5.Font.Size = 12;

            LineShapeItem txt10 = new LineShapeItem(0.025, 2.15, 2.8, 0.01);
            txt10.Orientation = LineOrientation.Horizontal;
            txt10.StrokeThickness = 0.015;


            TextItem txt10_1 = new TextItem(0.1, 2.2, 2, 0.5, "");
            txt10_1.DataField = "dphone";
            txt10_1.Font.Name = "Times new Roman";
            txt10_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt10_1.Font.Size = 7;

            LineShapeItem txt10_2 = new LineShapeItem(0.025, 2.32, 2.8, 0.01);
            txt10_2.Orientation = LineOrientation.Horizontal;
            txt10_2.StrokeThickness = 0.015;

            TextItem txt9 = new TextItem(0.1, 2.45, 2, 0.5, "");
            txt9.DataField = "l2";
            txt9.Font.Name = "Times new Roman";
            txt9.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9.Font.Size = 9;

            TextItem txt11 = new TextItem(0.1, 2.65, 2, 0.5, "");
            txt11.DataField = "l3";
            txt11.Font.Name = "Times new Roman";
            txt11.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt11.Font.Size = 9;

            TextItem txt11_1 = new TextItem(0.5, 2.65, 2, 0.5, "");
            txt11_1.DataField = "l4";
            txt11_1.Font.Name = "Times new Roman";
            txt11_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt11_1.Font.Size = 9;



        TextItem txt9_1 = new TextItem(1.25, 2.45, 2, 0.5, "");
        txt9_1.DataField = "delf1";
        txt9_1.Font.Name = "Times new Roman";
        txt9_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_1.Font.Size = 9;

        TextItem txt9_2 = new TextItem(1.25, 2.65, 2, 0.5, "");
        txt9_2.DataField = "delf2";
        txt9_2.Font.Name = "Times new Roman";
        txt9_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_2.Font.Size = 6;


        TextItem txt9_3 = new TextItem(1.25, 2.75, 2, 0.5, "");
        txt9_3.DataField = "delf3";
        txt9_3.Font.Name = "Times new Roman";
        txt9_3.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_3.Font.Size = 6;

        LineShapeItem txt16 = new LineShapeItem(0.025, 2.85, 2.8, 0.01);
        txt16.Orientation = LineOrientation.Horizontal;
        txt16.StrokeThickness = 0.015;


        TextItem txt9_4 = new TextItem(0.1, 2.87, 2, 0.5, "");
        txt9_4.DataField = "connote1";
        txt9_4.Font.Name = "Times new Roman";
        txt9_4.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_4.Font.Size = 9;

        TextItem txt9_5 = new TextItem(1.25, 2.87, 2, 0.5, "");
        txt9_5.DataField = "connote2";
        txt9_5.Font.Name = "Times new Roman";
        txt9_5.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_5.Font.Size = 9;


        TextItem txt9_6 = new TextItem(0.1, 3.08, 2, 0.5, "");
        txt9_6.DataField = "connote3";
        txt9_6.Font.Name = "Times new Roman";
        txt9_6.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_6.Font.Size = 9;


        TextItem txt9_7 = new TextItem(1.25, 3.08, 2, 0.5, "");
        txt9_7.DataField = "connote4";
        txt9_7.Font.Name = "Times new Roman";
        txt9_7.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_7.Font.Size = 9;

        LineShapeItem txt9_8 = new LineShapeItem(0.025, 3.3, 2.8, 0.01);
        txt9_8.Orientation = LineOrientation.Horizontal;
        txt9_8.StrokeThickness = 0.015;


        TextItem txt9_0 = new TextItem(0.25, 3.4, 1, 0.5, "FROM");
        txt9_0.Font.Name = "Times new Roman";
        txt9_0.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt9_0.Font.Size = 10;

        TextItem txt17 = new TextItem(2.5, 2.55, 1, 0.5, "");
        txt17.DataField = "l6";
        txt17.Font.Name = "Times new Roman";
        txt17.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt17.Font.Size = 9;
        txt17.RotationAngle = 90;

        TextItem txt17_1 = new TextItem(2.75, 3.55, 2.5, 0.25, "");
        txt17_1.DataField = "articleid";
        txt17_1.Font.Name = "Times new Roman";
        txt17_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt17_1.Font.Size = 9;
        txt17_1.TextAlignment = TextAlignment.Left;
        txt17_1.RotationAngle = 90;

        

        BarcodeItem bc2 = new BarcodeItem(3.5, 2.2, 6, 0.7, BarcodeSymbology.Code128, "ABC123");
        bc2.DataField = "BarcodeLabelNumber";
        bc2.BarHeight = 1.2;
        bc2.BarWidth = 0.0105;
        //bc2.BarWidth = 0.0105;
        bc2.QuietZone = new FrameThickness(0);
        bc2.BarcodeAlignment = BarcodeAlignment.TopLeft;
        bc2.RotationAngle = 90;
        bc2.DisplayCode = false;
        bc2.Symbology = BarcodeSymbology.GS1128;



        LineShapeItem txt17_4 = new LineShapeItem(0.025, 4.45, 2.8, 0.01);
        txt17_4.Orientation = LineOrientation.Horizontal;
        txt17_4.StrokeThickness = 0.015;

        TextItem txt18_0 = new TextItem(0.25, 4.5, 1, 0.5, "Declaration:");
        txt18_0.Font.Name = "Times new Roman";
        txt18_0.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt18_0.Font.Size = 8;

        TextItem txt118 = new TextItem(0.25, 4.6, 2.3, 0.1, "");
        txt118.Font.Name = "Times new Roman";
        txt118.DataField = "l8";
        txt118.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt118.Font.Size = 5;

        TextItem txt119 = new TextItem(0.25, 4.7, 2.3, 0.1, "");
        txt119.DataField = "l9";
        txt119.Font.Name = "Times new Roman";
        txt119.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt119.Font.Size = 5;

        TextItem txt120 = new TextItem(0.25, 4.8, 2.3, 0.1, "");
        txt120.DataField = "l10";
        txt120.Font.Name = "Times new Roman";
        txt120.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt120.Font.Size = 5;

        TextItem txt121 = new TextItem(0.25, 4.9, 2.3, 0.1, "");
        txt121.DataField = "l11";
        txt121.Font.Name = "Times new Roman";
        txt121.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt121.Font.Size = 5;

        TextItem txt122 = new TextItem(0.25, 5, 2.3, 0.1, "");
        txt122.DataField = "l12";
        txt122.Font.Name = "Times new Roman";
        txt122.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt122.Font.Size = 5;
        ;
        TextItem txt123 = new TextItem(0.25, 5.1, 2.3, 0.1, "");
        txt123.DataField = "l13";
        txt123.Font.Name = "Times new Roman";
        txt123.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt123.Font.Size = 5;

        TextItem txt118_1 = new TextItem(0.25, 3.5, 2.5, 0.25, "");
        txt118_1.Font.Name = "Times new Roman";
        txt118_1.DataField = "Sender";
        txt118_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt118_1.Font.Size = 8;

        TextItem txt18 = new TextItem(0.25, 3.65, 2.5, 0.25, "");
        txt18.DataField = "ShipperName1";
        txt18.Font.Name = "Times new Roman";
        txt18.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt18.Font.Size = 8;
        txt18.TextAlignment = TextAlignment.Left;

        TextItem txt19 = new TextItem(0.25, 3.8, 2.5, 0.25, "");
        txt19.DataField = "ShipperAddr1";
        txt19.Font.Name = "Times new Roman";
        txt19.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt19.Font.Size = 8;
        txt19.TextAlignment = TextAlignment.Left;

        TextItem txt20 = new TextItem(0.25, 3.95, 2.5, 0.25, "");
        txt20.DataField = "ShipperAddr2";
        txt20.Font.Name = "Times new Roman";
        txt20.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt20.Font.Size = 8;
        txt20.TextAlignment = TextAlignment.Left;

        TextItem txt21 = new TextItem(0.25, 3.95, 2.5, 0.25, "");
        txt21.DataField = "ShipperAddr3";
        txt21.Font.Name = "Times new Roman";
        txt21.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt21.Font.Size = 8;
        txt21.TextAlignment = TextAlignment.Left;

        TextItem txt23 = new TextItem(1.25, 3.95, 2.5, 0.25, "");
        txt23.DataField = "ShipperPostcode";
        txt23.Font.Name = "Times new Roman";
        txt23.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt23.Font.Size = 8;
        txt23.TextAlignment = TextAlignment.Left;

        LineShapeItem txt23_11 = new LineShapeItem(0.025, 5.2, 2.8, 0.01);
        txt23_11.Orientation = LineOrientation.Horizontal;
        txt23_11.StrokeThickness = 0.015;

        TextItem txt20_1 = new TextItem(0.15, 5.3, 1, 0.5, "");
        txt20_1.DataField = "dpt1";
        txt20_1.Font.Name = "Times new Roman";
        txt20_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt20_1.Font.Size = 5;

        TextItem txt20_2 = new TextItem(1.15, 5.3, 1, 0.5, "");
        txt20_2.DataField = "dpt2";
        txt20_2.Font.Name = "Times new Roman";
        txt20_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt20_2.Font.Size = 5;

        TextItem txt19_1 = new TextItem(0.15, 5.4, 1, 0.5, "");
        txt19_1.DataField = "l14";
        txt19_1.Font.Name = "Times new Roman";
        txt19_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
        txt19_1.Font.Size = 8;

         TextItem txt119_2 = new TextItem(1.2, 5.4, 1, 0.5, "");
         txt119_2.DataField = "Invoice_number";
         txt119_2.Font.Name = "Times new Roman";
         txt119_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
         txt119_2.Font.Size = 8;

        TextItem txt19_12 = new TextItem(0.15, 5.58, 1, 0.5, "");
            txt19_12.DataField = "l15";
            txt19_12.Font.Name = "Times new Roman";
            txt19_12.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt19_12.Font.Size = 8;

            TextItem txt119_22 = new TextItem(0.5, 5.58, 2, 0.5, "");
            txt119_22.DataField = "Ordernumber";
            txt119_22.Font.Name = "Times new Roman";
            txt119_22.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt119_22.Font.Size = 8;

            LineShapeItem txt23_1 = new LineShapeItem(0.025, 5.7, 2.8, 0.01);
            txt23_1.Orientation = LineOrientation.Horizontal;
            txt23_1.StrokeThickness = 0.015;

            TextItem txt25 = new TextItem(0.25, 5.72, 5, 0.25, "");
            txt25.Font.Name = "Times new Roman";
            txt25.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt25.Font.Size = 7;

            TextItem txt26 = new TextItem(1.65, 5.72, 5, 0.25, "");
            txt26.Font.Name = "Times new Roman";
            txt26.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt26.Font.Size = 7;

            TextItem txt27 = new TextItem(2.95, 5.72, 5, 0.25, "");
            txt27.Font.Name = "Times new Roman";
            txt27.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt27.Font.Size = 7;

            LineShapeItem txt13_21 = new LineShapeItem(2.81, 1.172, 0.601, 4.53);
            txt13_21.Orientation = LineOrientation.Vertical;
            txt13_21.StrokeThickness = 0.015;


            LineShapeItem txt13_212 = new LineShapeItem(0.025, 1.172, 0.601, 4.53);
            txt13_212.Orientation = LineOrientation.Vertical;
            txt13_212.StrokeThickness = 0.015;
         
            // tLabel.Items.Add(nbdaLogo);
            tLabel.Items.Add(postpaid);
            tLabel.Items.Add(qritem);
            tLabel.Items.Add(txt1);
            tLabel.Items.Add(txt1_1);
            tLabel.Items.Add(txt1_2);
            tLabel.Items.Add(txt2);
            tLabel.Items.Add(txt3);
            tLabel.Items.Add(txt4);
            tLabel.Items.Add(txt5);
            //'tLabel.Items.Add(txt6);
            //'tLabel.Items.Add(txt7);
            //'tLabel.Items.Add(txt8);
            tLabel.Items.Add(txt9);
            tLabel.Items.Add(txt9_1);
            tLabel.Items.Add(txt9_2);
            tLabel.Items.Add(txt9_3);
            tLabel.Items.Add(txt9_4);
            tLabel.Items.Add(txt9_5);
            tLabel.Items.Add(txt9_6);
            tLabel.Items.Add(txt9_7);
            tLabel.Items.Add(txt9_8);
            tLabel.Items.Add(txt9_0);
            tLabel.Items.Add(txt10);
            tLabel.Items.Add(txt10_1);
            tLabel.Items.Add(txt10_2);
            tLabel.Items.Add(txt11);
            tLabel.Items.Add(txt11_1);
            tLabel.Items.Add(txt16);
            tLabel.Items.Add(txt17);
            tLabel.Items.Add(txt17_1);
            tLabel.Items.Add(txt17_4);
            tLabel.Items.Add(txt18_0);
            tLabel.Items.Add(txt18);
            tLabel.Items.Add(txt19);
            tLabel.Items.Add(txt19_1);
            tLabel.Items.Add(txt119_2);
            //'tLabel.Items.Add(txt20);
            tLabel.Items.Add(txt20_1);
            tLabel.Items.Add(txt20_2);
            tLabel.Items.Add(txt21);
            tLabel.Items.Add(txt23);
            tLabel.Items.Add(txt118);
            tLabel.Items.Add(txt119);
            tLabel.Items.Add(txt19_1);
            tLabel.Items.Add(txt120);
            tLabel.Items.Add(txt121);
            tLabel.Items.Add(txt122);
            tLabel.Items.Add(txt123);
            tLabel.Items.Add(txt23_11);
            tLabel.Items.Add(txt23_1);
            tLabel.Items.Add(txt25);
            tLabel.Items.Add(txt26);
            tLabel.Items.Add(txt27);
            tLabel.Items.Add(bc2);
            tLabel.Items.Add(txt13_21);
            tLabel.Items.Add(txt13_212);
            tLabel.Items.Add(txt19_12);
            tLabel.Items.Add(txt119_22);

            //DataTable sou = new DataTable();
            //sou.

            Dictionary<string, string> source = new Dictionary<string, string>() ;

            source.Add("dphone", "Phone");
            source.Add("delf1","Delivery features");
            source.Add("delf2", "Sign on");
            source.Add("delf3", "Delivery");
            source.Add("dpt1", "");
            source.Add("dpt2", "");
            source.Add("postpaid", "POSTAGE PAID");
            source.Add("ordernumber", "");//from sql ordernumber column
            source.Add("Sender", "");//coalesce(sendername1,'') as Sender,
            source.Add("to1", "TO");
            source.Add("l1", "");
            source.Add("l2", "DeadWeight");
            source.Add("l3", "");//from sql 'weight' column
            source.Add("l4", "Kg");
            source.Add("16", "AP ARTILCE ID_");
            source.Add("17", "AP ARTILCE ID");
            source.Add("18", "Aviation Security and Dangerous Goods Declaration:");
            source.Add("19", "The sender acknowldeges that this areticle may be carried by air and will be subject to aviation");
            source.Add("110", "security and clearing procedures and the sender declares that the article");
            source.Add("111", "does not contain any dangerous or prohibited goods,explosive or incendiary devices.");
            source.Add("l12", "");
            source.Add("113", "A false declaration is a criminal offense.");
            source.Add("114", "Ref ");
            source.Add("115", "Order ");
            source.Add("Invoice_number", "");//Invoice_number, from sql
            source.Add("Delname", "");//Delname, from sql
            source.Add("Deladdr1", "");//Deladdr1, from sql
            source.Add("Deladdr2", "");//   case when coalesce(Deladdr2,'')= '' then Deladdr3+' '+Deladdr4 +' '+Postcode end as Deladdr2 ,
            source.Add("Deladdr3", "");//Deladdr3, from sql
            source.Add("Deladdr4", "");//Deladdr4, from sql
            source.Add("Postcode", "");//Postcode from sql
            source.Add("delpost", "");//case when coalesce(deladdr2,'')<>'' then  Deladdr3+' '+Deladdr4 +' '+Postcode else '' end  as delpost,
            source.Add("ShipperName1", "");// case when ShipperName1='JANKO EXPRESS LTD' then 'JANKO EXPRESS LTD' else 'DWA' END as ShipperName1,
            source.Add("ShipperName2", "");
            source.Add("ShipperAddr1", "PO Box 433");
            source.Add("ShipperAddr2", "");
            source.Add("ShipperAddr3", "Dingley Village");
            source.Add("ShipperCity", "");//from sql
            source.Add("ShipperState", "VIC");
            source.Add("ShipperPostcode", "3172");
            source.Add("ShipperCountry", "Australia");
            source.Add("LabelColor", "");//Label_Master.LabelColor from sql
            source.Add("articleid", "");//right(BarcodeLabelNumber,21) from sql
            source.Add("connote1", "CON NO");
            source.Add("connote2", "");//left(right(BarcodeLabelNumber,21),10)  from sql
            source.Add("connote3", "PARCEL");
            source.Add("connote4", "1 OF 1");
            source.Add("BarcodeLabelNumber", "");//BarcodeLabelNumber from sql
            source.Add("LabelSequence", "");//LabelSequence, from sql
            source.Add("RFCode", "");//RFCode from sql
            source.Add("QRCodes", "");
            source.Add("BarcodeLabelNumberd ", "");// BarcodeLabelNumber +'D' from sql
            source.Add("todaysdate", "");//ONVERT(varchar(12), GETDATE(), 103) 

            #endregion
            //  tLabel.DataSource


            //    source = GetEparcel2DnewPDF()
            //If(source.Rows.Count > 0) Then
           //    tLabel.DataSource = source;
            //End If

            //Return tLabel

            tLabel2.Items.Add(qritem);

            string timestamp = DateTime.Now.ToString("HHmmss-fff");
            string PDFFileName = "Eparcel_Label_2D" + "_" + timestamp + ".pdf";
            // Dim PDFFileName As String = "Testlabel" + ".pdf"
            //Session("Filename") = PDFFileName;

            string FolderPath = "C:\\Yaseer\\Technology\\dot net\\D2Z project files";
            string DestinationPath = FolderPath + PDFFileName;
            //Session("DesFolder") = DestinationPath
            //'If Not Directory.Exists(DestinationPath) Then
            //'    Directory.CreateDirectory(DestinationPath)
            //'End If



            //PrintJob pj = new PrintJob();
            //pj.ExportToPdf(tLabel, DestinationPath, 300);
            string PDFFilePath = @"C:\Yaseer\Technology\dot net\D2Z project files\myLabel.pdf";
            //Create a PrintJob object
            using (PrintJob pj = new PrintJob())
            {
                //Save output to PDF...
                pj.ExportToPdf(tLabel2, PDFFilePath, 300);
            }

            string filePath = PDFFilePath;
            string DLPDFfilename = Path.GetFileName(filePath);

            //converting Pdf file into bytes array  
            var dataBytes = File.ReadAllBytes(filePath);
            //adding bytes to memory stream   
            var dataStream = new MemoryStream(dataBytes);
                     

            var response = new HttpResponseMessage();

            response.StatusCode = HttpStatusCode.OK;

            //Write the memory stream to HttpResponseMessage content
            response.Content = new StreamContent(dataStream);
            string contentDisposition = string.Concat("attachment; filename=", DLPDFfilename);
            response.Content.Headers.ContentDisposition =
                          ContentDispositionHeaderValue.Parse(contentDisposition);
            return response;


        }
        public HttpResponseMessage testPDF() 
        {
            ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 4, 6);
            

            //ThermalLabel.LicenseOwner = "D2Z Pty Ltd-Ultimate Edition-Developer License";
            //ThermalLabel.LicenseKey = "EZJ6Y5A877F82CA6MXBYBWU3S3S54QVVL4MW39RN24LZLCP6GE2A";

           

            BarcodeItem qritem = new BarcodeItem(3, 1.15, 0.7, 0.7, BarcodeSymbology.DataMatrix, "0123456789ABCDEF");
            qritem.DisplayCode = false;
            //qritem.DataField = "QRCodes";
            qritem.DataMatrixModuleSize = 0.027;
            qritem.Width = 0.87;
            qritem.Height = 0.87;
            qritem.Symbology = BarcodeSymbology.DataMatrix;
            qritem.DataMatrixProcessTilde = true;

            //Define a ThermalLabel object and set unit to inch and label size
            //ThermalLabel tLabel = new ThermalLabel(UnitType.Inch, 4, 3);
           // tLabel.GapLength = 0.2;

            //Define a BarcodeItem object for encoding PDF417 symbology
            //BarcodeItem bc1 = new BarcodeItem(0.2, 0.2, 2, 1, BarcodeSymbology.Pdf417, "PRODUCT CODE 98765");
            //bc1.BarWidth = 0.01;
            //bc1.BarRatio = 3; //For PDF417, bar ratio should be >= 3

            //Define a BarcodeItem object for encoding DataMatrix symbology
            BarcodeItem bc2 = new BarcodeItem(3, 0.2, 2.5, 1.5, BarcodeSymbology.DataMatrix, "0123456789ABCDEF");
            bc2.DataMatrixModuleSize = 0.04;

            ////Define a BarcodeItem object for encoding ITF-14 symbology with Bearer Bars
            //BarcodeItem bc3 = new BarcodeItem(0.2, 1.5, 2, 1, BarcodeSymbology.Itf14, "1540014128876");
            //bc3.BarWidth = 0.01;
            //bc3.BarHeight = 0.7;
            //bc3.BearerBarStyle = BearerBarStyle.HorizontalRules;
            //bc3.BearerBarThickness = 0.05;
            //bc3.UseQuietZoneForText = true;
            //bc3.Font.Size = 5;

            //Add items to ThermalLabel object...
            //tLabel.Items.Add(bc1);
            tLabel.Items.Add(bc2);
            //tLabel.Items.Add(bc3);





            //    source = GetEparcel2DnewPDF()
            //If(source.Rows.Count > 0) Then
            //    tLabel.DataSource = source;
            //End If

            //Return tLabel

            tLabel.Items.Add(qritem);

            string timestamp = DateTime.Now.ToString("HHmmss-fff");
            string PDFFileName = "Eparcel_Label_2D" + "_" + timestamp + ".pdf";
            // Dim PDFFileName As String = "Testlabel" + ".pdf"
            //Session("Filename") = PDFFileName;

            string FolderPath = "C:\\Yaseer\\Technology\\dot net\\D2Z project files";
            string DestinationPath = FolderPath + PDFFileName;
            //Session("DesFolder") = DestinationPath
            //'If Not Directory.Exists(DestinationPath) Then
            //'    Directory.CreateDirectory(DestinationPath)
            //'End If



            //PrintJob pj = new PrintJob();
            //pj.ExportToPdf(tLabel, DestinationPath, 300);
            string PDFFilePath = @"C:\Yaseer\Technology\dot net\D2Z project files\myLabel.pdf";
            //Create a PrintJob object
            using (PrintJob pj = new PrintJob())
            {
                //Save output to PDF...
                pj.ExportToPdf(tLabel, PDFFilePath, 300);
            }

            string filePath = PDFFilePath;
            string DLPDFfilename = Path.GetFileName(filePath);

            //converting Pdf file into bytes array  
            var dataBytes = File.ReadAllBytes(filePath);
            //adding bytes to memory stream   
            var dataStream = new MemoryStream(dataBytes);


            var response = new HttpResponseMessage();

            response.StatusCode = HttpStatusCode.OK;

            //Write the memory stream to HttpResponseMessage content
            response.Content = new StreamContent(dataStream);
            string contentDisposition = string.Concat("attachment; filename=", DLPDFfilename);
            response.Content.Headers.ContentDisposition =
                          ContentDispositionHeaderValue.Parse(contentDisposition);
            return response;


        }

        public HttpResponseMessage PdfWithhardcodedValue()
        {
            ThermalLabel tLabel = new ThermalLabel(Neodynamic.SDK.Printing.UnitType.Inch, 4, 6);
            //ThermalLabel tLabel2 = new ThermalLabel(Neodynamic.SDK.Printing.UnitType.Inch, 4, 6);

            //ThermalLabel.LicenseOwner = "D2Z Pty Ltd-Ultimate Edition-Developer License";
            //ThermalLabel.LicenseKey = "EZJ6Y5A877F82CA6MXBYBWU3S3S54QVVL4MW39RN24LZLCP6GE2A";

            //ImageItem nbdaLogo = new ImageItem(0.03, 0.01);
            //nbdaLogo.SourceFile = "dfdf";
            //nbdaLogo.Width = 4;
            //nbdaLogo.LockAspectRatio = LockAspectRatio.WidthBased;
            //nbdaLogo.MonochromeSettings.DitherMethod = DitherMethod.Threshold;
            //nbdaLogo.MonochromeSettings.Threshold = 50;
            //nbdaLogo.MonochromeSettings.ReverseEffect = false;

            BarcodeItem qritem = new BarcodeItem(3, 1.15, 0.7, 0.7, BarcodeSymbology.DataMatrix, "0123456789ABCDEF");
            qritem.DisplayCode = false;
            //qritem.DataField = "QRCodes";
            qritem.DataMatrixModuleSize = 0.027;
            qritem.Width = 0.87;
            qritem.Height = 0.87;
            qritem.Symbology = BarcodeSymbology.DataMatrix;
            qritem.DataMatrixProcessTilde = true;


            #region MyRegion


            TextItem postpaid = new TextItem(3.1, 0.75, 2, 0.5, "POSTAGE PAID");
            postpaid.Font.Name = "Times new Roman";
            //postpaid.DataField = "postpaid";
            postpaid.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            postpaid.Font.Size = 8;

            TextItem txt1 = new TextItem(1, 0.75, 2, 0.5, "");
            txt1.Font.Name = "Times new Roman";
           // txt1.DataField = "l1";
            txt1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt1.Font.Size = 17;
            txt1.Font.Bold = true;

            TextItem txt1_1 = new TextItem(0.2, 0.85, 2, 0.5, "TO");
            txt1_1.Font.Name = "Times new Roman";
           // txt1_1.DataField = "to1";
            txt1_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt1_1.Font.Size = 12;
            txt1_1.Font.Bold = true;

            LineShapeItem txt1_2 = new LineShapeItem(0.025, 1.16, 2.8, 0.01);
            txt1_2.Orientation = LineOrientation.Horizontal;
            txt1_2.StrokeThickness = 0.015;

            TextItem txt2 = new TextItem(0.2, 1.2, 3.5, 0.25, "Delname");
           // txt2.DataField = "Delname";
            txt2.Font.Name = "Times new Roman";
            txt2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt2.Font.Size = 12;
            txt1.TextAlignment = TextAlignment.Left;

            TextItem txt3 = new TextItem(0.2, 1.4, 3.5, 0.25, "Deladdr1");
           // txt3.DataField = "Deladdr1";
            txt3.Font.Name = "Times new Roman";
            txt3.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt3.Font.Size = 12;
            txt3.TextAlignment = TextAlignment.Left;

            TextItem txt4 = new TextItem(0.2, 1.6, 3.5, 0.25, "Deladdr2");
            //txt4.DataField = "Deladdr2";
            txt4.Font.Name = "Times new Roman";
            txt4.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt4.Font.Size = 12;
            txt4.TextAlignment = TextAlignment.Left;

            LineShapeItem txt8 = new LineShapeItem(0.025, 2, 2.8, 0.01);
            txt8.Orientation = LineOrientation.Horizontal;
            txt8.StrokeThickness = 0.015;

            TextItem txt5 = new TextItem(0.2, 1.9, 2.5, 0.25, "delpost");
           // txt5.DataField = "delpost";
            txt5.Font.Name = "Times new Roman";
            txt5.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt5.Font.Size = 12;

            LineShapeItem txt10 = new LineShapeItem(0.025, 2.15, 2.8, 0.01);
            txt10.Orientation = LineOrientation.Horizontal;
            txt10.StrokeThickness = 0.015;


            TextItem txt10_1 = new TextItem(0.1, 2.2, 2, 0.5, "dphone");
           // txt10_1.DataField = "dphone";
            txt10_1.Font.Name = "Times new Roman";
            txt10_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt10_1.Font.Size = 7;

            LineShapeItem txt10_2 = new LineShapeItem(0.025, 2.32, 2.8, 0.01);
            txt10_2.Orientation = LineOrientation.Horizontal;
            txt10_2.StrokeThickness = 0.015;

            TextItem txt9 = new TextItem(0.1, 2.45, 2, 0.5, "DeadWeight");
            //txt9.DataField = "l2";
            txt9.Font.Name = "Times new Roman";
            txt9.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9.Font.Size = 9;

            TextItem txt11 = new TextItem(0.1, 2.65, 2, 0.5, "Weight");
            //txt11.DataField = "l3";
            txt11.Font.Name = "Times new Roman";
            txt11.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt11.Font.Size = 9;

            TextItem txt11_1 = new TextItem(0.5, 2.65, 2, 0.5, "Kg");
            //txt11_1.DataField = "l4";
            txt11_1.Font.Name = "Times new Roman";
            txt11_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt11_1.Font.Size = 9;



            TextItem txt9_1 = new TextItem(1.25, 2.45, 2, 0.5, "Delivery features");
            //txt9_1.DataField = "delf1";
            txt9_1.Font.Name = "Times new Roman";
            txt9_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_1.Font.Size = 9;

            TextItem txt9_2 = new TextItem(1.25, 2.65, 2, 0.5, "Sign on");
            //txt9_2.DataField = "delf2";
            txt9_2.Font.Name = "Times new Roman";
            txt9_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_2.Font.Size = 6;


            TextItem txt9_3 = new TextItem(1.25, 2.75, 2, 0.5, "Delivery");
           // txt9_3.DataField = "delf3";
            txt9_3.Font.Name = "Times new Roman";
            txt9_3.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_3.Font.Size = 6;

            LineShapeItem txt16 = new LineShapeItem(0.025, 2.85, 2.8, 0.01);
            txt16.Orientation = LineOrientation.Horizontal;
            txt16.StrokeThickness = 0.015;


            TextItem txt9_4 = new TextItem(0.1, 2.87, 2, 0.5, "CON NO");
            //txt9_4.DataField = "connote1";
            txt9_4.Font.Name = "Times new Roman";
            txt9_4.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_4.Font.Size = 9;

            TextItem txt9_5 = new TextItem(1.25, 2.87, 2, 0.5, "connote2");
            //txt9_5.DataField = "connote2";
            txt9_5.Font.Name = "Times new Roman";
            txt9_5.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_5.Font.Size = 9;


            TextItem txt9_6 = new TextItem(0.1, 3.08, 2, 0.5, "PARCEL");
           // txt9_6.DataField = "connote3";
            txt9_6.Font.Name = "Times new Roman";
            txt9_6.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_6.Font.Size = 9;


            TextItem txt9_7 = new TextItem(1.25, 3.08, 2, 0.5, "1 OF 1");
           // txt9_7.DataField = "connote4";
            txt9_7.Font.Name = "Times new Roman";
            txt9_7.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_7.Font.Size = 9;

            LineShapeItem txt9_8 = new LineShapeItem(0.025, 3.3, 2.8, 0.01);
            txt9_8.Orientation = LineOrientation.Horizontal;
            txt9_8.StrokeThickness = 0.015;


            TextItem txt9_0 = new TextItem(0.25, 3.4, 1, 0.5, "FROM");
            txt9_0.Font.Name = "Times new Roman";
            txt9_0.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt9_0.Font.Size = 10;

            TextItem txt17 = new TextItem(2.5, 2.55, 1, 0.5, "AP ARTILCE ID:");
           // txt17.DataField = "l6";
            txt17.Font.Name = "Times new Roman";
            txt17.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt17.Font.Size = 9;
            txt17.RotationAngle = 90;

            TextItem txt17_1 = new TextItem(2.75, 3.55, 2.5, 0.25, "articleid");
            //txt17_1.DataField = "articleid";
            txt17_1.Font.Name = "Times new Roman";
            txt17_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt17_1.Font.Size = 9;
            txt17_1.TextAlignment = TextAlignment.Left;
            txt17_1.RotationAngle = 90;



            BarcodeItem bc2 = new BarcodeItem(3.5, 2.2, 6, 0.7, BarcodeSymbology.Code128, "ABC123");
           // bc2.DataField = "BarcodeLabelNumber";
            bc2.BarHeight = 1.2;
            bc2.BarWidth = 0.0105;
            //bc2.BarWidth = 0.0105;
            bc2.QuietZone = new FrameThickness(0);
            bc2.BarcodeAlignment = BarcodeAlignment.TopLeft;
            bc2.RotationAngle = 90;
            bc2.DisplayCode = false;
            bc2.Symbology = BarcodeSymbology.GS1128;



            LineShapeItem txt17_4 = new LineShapeItem(0.025, 4.45, 2.8, 0.01);
            txt17_4.Orientation = LineOrientation.Horizontal;
            txt17_4.StrokeThickness = 0.015;

            TextItem txt18_0 = new TextItem(0.25, 4.5, 1, 0.5, "Declaration:");
            txt18_0.Font.Name = "Times new Roman";
            txt18_0.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt18_0.Font.Size = 8;

            TextItem txt118 = new TextItem(0.25, 4.6, 2.3, 0.1, "Aviation Security and Dangerous Goods Declaration:");
            txt118.Font.Name = "Times new Roman";
           // txt118.DataField = "l8";
            txt118.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt118.Font.Size = 5;

            TextItem txt119 = new TextItem(0.25, 4.7, 2.3, 0.1, "The sender acknowldeges that this areticle may be carried by air and will be subject to aviation");
           // txt119.DataField = "l9";
            txt119.Font.Name = "Times new Roman";
            txt119.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt119.Font.Size = 5;

            TextItem txt120 = new TextItem(0.25, 4.8, 2.3, 0.1, " security and clearing procedures and the sender declares that the article");
           // txt120.DataField = "l10";
            txt120.Font.Name = "Times new Roman";
            txt120.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt120.Font.Size = 5;

            TextItem txt121 = new TextItem(0.25, 4.9, 2.3, 0.1, "does not contain any dangerous or prohibited goods,explosive or incendiary devices.");
            //txt121.DataField = "l11";
            txt121.Font.Name = "Times new Roman";
            txt121.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt121.Font.Size = 5;

            TextItem txt122 = new TextItem(0.25, 5, 2.3, 0.1, " ");
           // txt122.DataField = "l12";
            txt122.Font.Name = "Times new Roman";
            txt122.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt122.Font.Size = 5;
            ;
            TextItem txt123 = new TextItem(0.25, 5.1, 2.3, 0.1, "A false declaration is a criminal offense. ");
           // txt123.DataField = "l13";
            txt123.Font.Name = "Times new Roman";
            txt123.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt123.Font.Size = 5;

            TextItem txt118_1 = new TextItem(0.25, 3.5, 2.5, 0.25, "Sender");
            txt118_1.Font.Name = "Times new Roman";
            //txt118_1.DataField = "Sender";
            txt118_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt118_1.Font.Size = 8;

            TextItem txt18 = new TextItem(0.25, 3.65, 2.5, 0.25, "ShipperName1");
           // txt18.DataField = "ShipperName1";
            txt18.Font.Name = "Times new Roman";
            txt18.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt18.Font.Size = 8;
            txt18.TextAlignment = TextAlignment.Left;

            TextItem txt19 = new TextItem(0.25, 3.8, 2.5, 0.25, "ShipperAddr1");
           // txt19.DataField = "ShipperAddr1";
            txt19.Font.Name = "Times new Roman";
            txt19.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt19.Font.Size = 8;
            txt19.TextAlignment = TextAlignment.Left;

            TextItem txt20 = new TextItem(0.25, 3.95, 2.5, 0.25, "ShipperAddr2");
            //txt20.DataField = "ShipperAddr2";
            txt20.Font.Name = "Times new Roman";
            txt20.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt20.Font.Size = 8;
            txt20.TextAlignment = TextAlignment.Left;

            TextItem txt21 = new TextItem(0.25, 3.95, 2.5, 0.25, "ShipperAddr3");
            //txt21.DataField = "ShipperAddr3";
            txt21.Font.Name = "Times new Roman";
            txt21.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt21.Font.Size = 8;
            txt21.TextAlignment = TextAlignment.Left;

            TextItem txt23 = new TextItem(1.25, 3.95, 2.5, 0.25, "ShipperPostcode");
           // txt23.DataField = "ShipperPostcode";
            txt23.Font.Name = "Times new Roman";
            txt23.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt23.Font.Size = 8;
            txt23.TextAlignment = TextAlignment.Left;

            LineShapeItem txt23_11 = new LineShapeItem(0.025, 5.2, 2.8, 0.01);
            txt23_11.Orientation = LineOrientation.Horizontal;
            txt23_11.StrokeThickness = 0.015;

            TextItem txt20_1 = new TextItem(0.15, 5.3, 1, 0.5, " ");
            //txt20_1.DataField = "dpt1";
            txt20_1.Font.Name = "Times new Roman";
            txt20_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt20_1.Font.Size = 5;

            TextItem txt20_2 = new TextItem(1.15, 5.3, 1, 0.5, " ");
           // txt20_2.DataField = "dpt2";
            txt20_2.Font.Name = "Times new Roman";
            txt20_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt20_2.Font.Size = 5;

            TextItem txt19_1 = new TextItem(0.15, 5.4, 1, 0.5, "Ref ");
            //txt19_1.DataField = "l14";
            txt19_1.Font.Name = "Times new Roman";
            txt19_1.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt19_1.Font.Size = 8;

            TextItem txt119_2 = new TextItem(1.2, 5.4, 1, 0.5, "Invoice_number");
            //txt119_2.DataField = "Invoice_number";
            txt119_2.Font.Name = "Times new Roman";
            txt119_2.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt119_2.Font.Size = 8;

            TextItem txt19_12 = new TextItem(0.15, 5.58, 1, 0.5, "Order ");
           // txt19_12.DataField = "l15";
            txt19_12.Font.Name = "Times new Roman";
            txt19_12.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt19_12.Font.Size = 8;

            TextItem txt119_22 = new TextItem(0.5, 5.58, 2, 0.5, "Ordernumber");
           // txt119_22.DataField = "Ordernumber";
            txt119_22.Font.Name = "Times new Roman";
            txt119_22.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt119_22.Font.Size = 8;

            LineShapeItem txt23_1 = new LineShapeItem(0.025, 5.7, 2.8, 0.01);
            txt23_1.Orientation = LineOrientation.Horizontal;
            txt23_1.StrokeThickness = 0.015;

            TextItem txt25 = new TextItem(0.25, 5.72, 5, 0.25, "");
            txt25.Font.Name = "Times new Roman";
            txt25.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt25.Font.Size = 7;

            TextItem txt26 = new TextItem(1.65, 5.72, 5, 0.25, "");
            txt26.Font.Name = "Times new Roman";
            txt26.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt26.Font.Size = 7;

            TextItem txt27 = new TextItem(2.95, 5.72, 5, 0.25, "");
            txt27.Font.Name = "Times new Roman";
            txt27.Font.Unit = Neodynamic.SDK.Printing.FontUnit.Point;
            txt27.Font.Size = 7;

            LineShapeItem txt13_21 = new LineShapeItem(2.81, 1.172, 0.601, 4.53);
            txt13_21.Orientation = LineOrientation.Vertical;
            txt13_21.StrokeThickness = 0.015;


            LineShapeItem txt13_212 = new LineShapeItem(0.025, 1.172, 0.601, 4.53);
            txt13_212.Orientation = LineOrientation.Vertical;
            txt13_212.StrokeThickness = 0.015;

            // tLabel.Items.Add(nbdaLogo);
            tLabel.Items.Add(postpaid);
            tLabel.Items.Add(qritem);
            tLabel.Items.Add(txt1);
            tLabel.Items.Add(txt1_1);
            tLabel.Items.Add(txt1_2);
            tLabel.Items.Add(txt2);
            tLabel.Items.Add(txt3);
            tLabel.Items.Add(txt4);
            tLabel.Items.Add(txt5);
            //'tLabel.Items.Add(txt6);
            //'tLabel.Items.Add(txt7);
            //'tLabel.Items.Add(txt8);
            tLabel.Items.Add(txt9);
            tLabel.Items.Add(txt9_1);
            tLabel.Items.Add(txt9_2);
            tLabel.Items.Add(txt9_3);
            tLabel.Items.Add(txt9_4);
            tLabel.Items.Add(txt9_5);
            tLabel.Items.Add(txt9_6);
            tLabel.Items.Add(txt9_7);
            tLabel.Items.Add(txt9_8);
            tLabel.Items.Add(txt9_0);
            tLabel.Items.Add(txt10);
            tLabel.Items.Add(txt10_1);
            tLabel.Items.Add(txt10_2);
            tLabel.Items.Add(txt11);
            tLabel.Items.Add(txt11_1);
            tLabel.Items.Add(txt16);
            tLabel.Items.Add(txt17);
            tLabel.Items.Add(txt17_1);
            tLabel.Items.Add(txt17_4);
            tLabel.Items.Add(txt18_0);
            tLabel.Items.Add(txt18);
            tLabel.Items.Add(txt19);
            tLabel.Items.Add(txt19_1);
            tLabel.Items.Add(txt119_2);
            //'tLabel.Items.Add(txt20);
            tLabel.Items.Add(txt20_1);
            tLabel.Items.Add(txt20_2);
            tLabel.Items.Add(txt21);
            tLabel.Items.Add(txt23);
            tLabel.Items.Add(txt118);
            tLabel.Items.Add(txt119);
            tLabel.Items.Add(txt19_1);
            tLabel.Items.Add(txt120);
            tLabel.Items.Add(txt121);
            tLabel.Items.Add(txt122);
            tLabel.Items.Add(txt123);
            tLabel.Items.Add(txt23_11);
            tLabel.Items.Add(txt23_1);
            tLabel.Items.Add(txt25);
            tLabel.Items.Add(txt26);
            tLabel.Items.Add(txt27);
            tLabel.Items.Add(bc2);
            tLabel.Items.Add(txt13_21);
            tLabel.Items.Add(txt13_212);
            tLabel.Items.Add(txt19_12);
            tLabel.Items.Add(txt119_22);

            //DataTable sou = new DataTable();
            //sou.

            Dictionary<string, string> source = new Dictionary<string, string>();

            source.Add("dphone", "Phone");
            source.Add("delf1", "Delivery features");
            source.Add("delf2", "Sign on");
            source.Add("delf3", "Delivery");
            source.Add("dpt1", "");
            source.Add("dpt2", "");
            source.Add("postpaid", "POSTAGE PAID");
            source.Add("ordernumber", "");//from sql ordernumber column
            source.Add("Sender", "");//coalesce(sendername1,'') as Sender,
            source.Add("to1", "TO");
            source.Add("l1", "");
            source.Add("l2", "DeadWeight");
            source.Add("l3", "");//from sql 'weight' column
            source.Add("l4", "Kg");
            source.Add("16", "AP ARTILCE ID_");
            source.Add("17", "AP ARTILCE ID");
            source.Add("18", "Aviation Security and Dangerous Goods Declaration:");
            source.Add("19", "The sender acknowldeges that this areticle may be carried by air and will be subject to aviation");
            source.Add("110", "security and clearing procedures and the sender declares that the article");
            source.Add("111", "does not contain any dangerous or prohibited goods,explosive or incendiary devices.");
            source.Add("l12", "");
            source.Add("113", "A false declaration is a criminal offense.");
            source.Add("114", "Ref ");
            source.Add("115", "Order ");
            source.Add("Invoice_number", "");//Invoice_number, from sql
            source.Add("Delname", "");//Delname, from sql
            source.Add("Deladdr1", "");//Deladdr1, from sql
            source.Add("Deladdr2", "");//   case when coalesce(Deladdr2,'')= '' then Deladdr3+' '+Deladdr4 +' '+Postcode end as Deladdr2 ,
            source.Add("Deladdr3", "");//Deladdr3, from sql
            source.Add("Deladdr4", "");//Deladdr4, from sql
            source.Add("Postcode", "");//Postcode from sql
            source.Add("delpost", "");//case when coalesce(deladdr2,'')<>'' then  Deladdr3+' '+Deladdr4 +' '+Postcode else '' end  as delpost,
            source.Add("ShipperName1", "");// case when ShipperName1='JANKO EXPRESS LTD' then 'JANKO EXPRESS LTD' else 'DWA' END as ShipperName1,
            source.Add("ShipperName2", "");
            source.Add("ShipperAddr1", "PO Box 433");
            source.Add("ShipperAddr2", "");
            source.Add("ShipperAddr3", "Dingley Village");
            source.Add("ShipperCity", "");//from sql
            source.Add("ShipperState", "VIC");
            source.Add("ShipperPostcode", "3172");
            source.Add("ShipperCountry", "Australia");
            source.Add("LabelColor", "");//Label_Master.LabelColor from sql
            source.Add("articleid", "");//right(BarcodeLabelNumber,21) from sql
            source.Add("connote1", "CON NO");
            source.Add("connote2", "");//left(right(BarcodeLabelNumber,21),10)  from sql
            source.Add("connote3", "PARCEL");
            source.Add("connote4", "1 OF 1");
            source.Add("BarcodeLabelNumber", "");//BarcodeLabelNumber from sql
            source.Add("LabelSequence", "");//LabelSequence, from sql
            source.Add("RFCode", "");//RFCode from sql
            source.Add("QRCodes", "");
            source.Add("BarcodeLabelNumberd ", "");// BarcodeLabelNumber +'D' from sql
            source.Add("todaysdate", "");//ONVERT(varchar(12), GETDATE(), 103) 

            #endregion
            //  tLabel.DataSource


            //    source = GetEparcel2DnewPDF()
            //If(source.Rows.Count > 0) Then
            //    tLabel.DataSource = source;
            //End If

            //Return tLabel

            tLabel.Items.Add(qritem);

            string timestamp = DateTime.Now.ToString("HHmmss-fff");
            string PDFFileName = "Eparcel_Label_2D" + "_" + timestamp + ".pdf";
            // Dim PDFFileName As String = "Testlabel" + ".pdf"
            //Session("Filename") = PDFFileName;

            string FolderPath = "C:\\Yaseer\\Technology\\dot net\\D2Z project files";
            string DestinationPath = FolderPath + PDFFileName;
            //Session("DesFolder") = DestinationPath
            //'If Not Directory.Exists(DestinationPath) Then
            //'    Directory.CreateDirectory(DestinationPath)
            //'End If



            //PrintJob pj = new PrintJob();
            //pj.ExportToPdf(tLabel, DestinationPath, 300);
            string PDFFilePath = @"C:\Yaseer\Technology\dot net\D2Z project files\myLabel.pdf";
            //Create a PrintJob object
            using (PrintJob pj = new PrintJob())
            {
                //Save output to PDF...
                pj.ExportToPdf(tLabel, PDFFilePath, 300);
            }

            string filePath = PDFFilePath;
            string DLPDFfilename = Path.GetFileName(filePath);

            //converting Pdf file into bytes array  
            var dataBytes = File.ReadAllBytes(filePath);
            //adding bytes to memory stream   
            var dataStream = new MemoryStream(dataBytes);


            var response = new HttpResponseMessage();

            response.StatusCode = HttpStatusCode.OK;

            //Write the memory stream to HttpResponseMessage content
            response.Content = new StreamContent(dataStream);
            string contentDisposition = string.Concat("attachment; filename=", DLPDFfilename);
            response.Content.Headers.ContentDisposition =
                          ContentDispositionHeaderValue.Parse(contentDisposition);
            return response;


        }


    }

    public class testClass
    {
        public void createLabel()
        {
            Thread worker = new Thread(new ThreadStart(this.ThermalLabelWorker));
            worker.SetApartmentState(ApartmentState.STA);
            worker.Name = "ThermalLabelWorker";
            worker.Start();
            worker.Join();



        }

        private void ThermalLabelWorker()
        {
            //Create the thermal label object
            ThermalLabel tLabel = new ThermalLabel(Neodynamic.SDK.Printing.UnitType.Inch, 4, 4);

            TextItem txtItem = new TextItem(0.2, 0.2, 1, 0.5, "Thermal Label Test");

            BarcodeItem bcItem = new BarcodeItem(0.2, 1, 2, 1, BarcodeSymbology.Code128, "1234567890");
            //Set bars height to 1 inch 
            bcItem.BarHeight = 1;
            //Set bars width to 0.01 inch 
            bcItem.BarWidth = 0.01;

            //Add items to the label
            tLabel.Items.Add(txtItem);
            tLabel.Items.Add(bcItem);

            //Create a PrintJob object and export the label to PDF
            using (PrintJob pj = new PrintJob())
            {
                pj.ExportToPdf(tLabel, @"C:\Yaseer\Technology\dot net\D2Z project files\BarcodeLabel.pdf", 300);
            }
        }
    }
}