using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vellsPos.Forms.Layouts;

namespace vellsPos.Entities.Layouts
{
    internal class Invoice
    {
        PrintDocument pdoc = null;
        private Int32 ticketNo;
        private String ticketDate;
        private String source;
        private String destination;
        private String drawnBy;
        private Decimal amount;

        public Invoice()
        {

        }

        public Invoice(int ticketNo, string ticketDate, string source, string destination, string drawnBy, decimal amount)
        {
            this.TicketNo = ticketNo;
            TicketDate = ticketDate;
            Source = source;
            Destination = destination;
            DrawnBy = drawnBy;
            Amount = amount;
        }

        public int TicketNo { get => ticketNo; set => ticketNo = value; }
        public string TicketDate { get => ticketDate; set => ticketDate = value; }
        public string Source { get => source; set => source = value; }
        public string Destination { get => destination; set => destination = value; }
        public string DrawnBy { get => drawnBy; set => drawnBy = value; }
        public decimal Amount { get => amount; set => amount = value; }

        public void print()
        {
            //comboBox1.Items.Clear();
            //foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            //{
            //    //comboBox1.Items.Add(printer);
            //}

            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);

            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 820;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }
            }
        }

        SizeF Size_MyColums;
        Rectangle MyBox_Rectangle;
        Rectangle MyTest_Rectangle;
        string Auther = "By:Ibrahim Sherwani (RIOSOFT)";
        int niopp = 0;
        int numm = 0;
        string cashier = "ناوی كاشێر:";
        string bill = "ژ.پسووله‌:";
        string datee = "به‌روار:";
        DateTime dat = new DateTime();

        private int[] MyCoulums_Width = { 48, 48, 31, 151 };
        private StringAlignment[] Vertical_Ali = { StringAlignment.Center, StringAlignment.Center, StringAlignment.Center, StringAlignment.Center };
        private StringAlignment[] Horezontal_Ali = { StringAlignment.Center, StringAlignment.Center, StringAlignment.Center, StringAlignment.Far };

        public void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Graphics MyGraphics = e.Graphics;
            //Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            //String MyLine = "____________________________________";
            //int Horezontal_X = 0;
            //int vertical_Y = 0;
            //int My_newline = 0;
            //My_newline += 0;
            //My_newline = My_newline + 20;
            //var g = e.Graphics;
            //var srcRect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
            //var desRect = new Rectangle(40, 40, 195, 80);
            //using (var MYPic = new Bitmap(srcRect.Width, srcRect.Height))
            //{
            //    pictureBox1.DrawToBitmap(MYPic, srcRect);
            //    g.DrawImage(MYPic, desRect, srcRect, GraphicsUnit.Pixel);

            //}
            //My_newline = My_newline + 60;
            //StringFormat MyStringFormat2 = new StringFormat();
            //StringFormat MyStringFormat3 = new StringFormat();
            //SolidBrush My_Color = new SolidBrush(Color.Black);
            //MyStringFormat3 = new StringFormat(StringFormatFlags.DirectionVertical);
            //MyStringFormat2 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            //MyGraphics.DrawString(label1.Text.ToUpper(), new Font("Arial", 23, FontStyle.Bold), My_Color, 15, vertical_Y + 12);
            //My_newline = My_newline + 60;
            //MyGraphics.DrawString(cashier + textBox1.Text, MyFont0, My_Color, 205, vertical_Y + My_newline, MyStringFormat2);
            //My_newline = My_newline + 25;
            //MyGraphics.DrawString(bill + textBox2.Text, MyFont0, My_Color, 85, vertical_Y + My_newline);
            //My_newline = My_newline + 25;
            //g.DrawString(datee + DateTime.Now.ToShortDateString(), MyFont0, My_Color, 75, vertical_Y + My_newline);
            //My_newline = My_newline + 10;
            //MyGraphics.DrawString(MyLine, new Font("Arial", 10, FontStyle.Bold), My_Color, 0, vertical_Y + My_newline);
            //My_newline = My_newline + 25;
            //MyGraphics.DrawString("ناوی بابه‌ت", new Font("Rudaw", 10, FontStyle.Bold), My_Color, 280, vertical_Y + My_newline, MyStringFormat2);
            //MyGraphics.DrawString("ژماره‌", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 90, vertical_Y + My_newline);
            //MyGraphics.DrawString("نرخ", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 58, vertical_Y + My_newline);
            //MyGraphics.DrawString("گشتی", new Font("Rudaw", 8, FontStyle.Bold), My_Color, Horezontal_X + 2, vertical_Y + My_newline);
            //My_newline = My_newline + 20;


            ////----------------------------------------------myDataGrid------------------------------------
            //StringFormat MyStringFormat = new StringFormat();
            //Font MyFont1 = new Font("Rudaw", 7);
            //const int Side_margin = 4;
            //int y = My_newline;
            //for (int j = numm; j < dataGridView1.Rows.Count; j++)
            //{
            //    int MyMax_height = 0;
            //    niopp++;

            //    if (niopp <= 26)
            //    {
            //        numm++;
            //        if (numm <= dataGridView1.Rows.Count)
            //        {

            //            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //            {
            //                Size_MyColums = e.Graphics.MeasureString(Convert.ToString(dataGridView1.Rows[j].Cells[i].Value), MyFont1, MyCoulums_Width[i] - 1 * Side_margin);
            //                int MyNew_height = (int)Math.Ceiling(Size_MyColums.Height);
            //                if (MyMax_height < MyNew_height)
            //                {
            //                    MyMax_height = MyNew_height;
            //                }
            //            }
            //            MyMax_height += 2 * Side_margin;

            //            frmPOS frmPOS = new frmPOS();


            //            int x = Side_margin;
            //            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //            {
            //                MyBox_Rectangle = new Rectangle(x, y, MyCoulums_Width[i], MyMax_height);
            //                MyTest_Rectangle = MyBox_Rectangle;
            //                MyTest_Rectangle.Inflate(-Side_margin, -Side_margin);
            //                MyStringFormat.Alignment = Horezontal_Ali[i];
            //                MyStringFormat.LineAlignment = Vertical_Ali[i];
            //                e.Graphics.DrawString(Convert.ToString(dataGridView1.Rows[j].Cells[i].Value), MyFont1, My_Color, MyTest_Rectangle, MyStringFormat);
            //                e.Graphics.DrawRectangle(Pens.Black, MyBox_Rectangle);
            //                x += MyCoulums_Width[i];
            //            }
            //        }
            //        else
            //        {
            //            e.HasMorePages = false;
            //        }
            //    }
            //    else
            //    {
            //        niopp = 0;
            //        e.HasMorePages = true;
            //        return;
            //    }
            //    y += MyMax_height;
            //}
            ////----------------------------------------------myDataGrid------------------------------------
            //My_newline = y + 10;
            //textBox5.Text = String.Format("{0:n0}", double.Parse(textBox5.Text));
            //textBox6.Text = String.Format("{0:n0}", double.Parse(textBox6.Text));
            //MyGraphics.DrawString(textBox5.Text, MyFont0, My_Color, 0, vertical_Y + My_newline);
            //MyGraphics.DrawString("كۆی گشتی:", MyFont0, My_Color, 280, vertical_Y + My_newline, MyStringFormat2);
            //My_newline = My_newline + 18;
            //MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, vertical_Y + My_newline);
            //My_newline = My_newline + 20;
            //MyGraphics.DrawString(textBox6.Text, MyFont0, My_Color, 2, vertical_Y + My_newline);
            //MyGraphics.DrawString("داشكاندن:", MyFont0, My_Color, 280, vertical_Y + My_newline, MyStringFormat2);
            //My_newline = My_newline + 18;
            //MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, vertical_Y + My_newline);
            //My_newline = My_newline + 30;
            //MyGraphics.DrawString("*" + textBox2.Text + "*", new Font("C39P24DlTt", 25), My_Color, 35, vertical_Y + My_newline);
            //My_newline = My_newline + 35;
            //MyGraphics.DrawString(textBox2.Text, new Font("Arial", 8), My_Color, 115, vertical_Y + My_newline);
            //My_newline = My_newline + 40;
            //MyGraphics.DrawString(textBox4.Text, MyFont0, My_Color, 40, vertical_Y + My_newline);
            //My_newline = My_newline + 20;
            //MyGraphics.DrawString(Auther, MyFont0, My_Color, 10, vertical_Y + My_newline);

            //niopp = 0;
            //numm = 0;

            //-----------------------------------------------------------------------------------------------------------------------------

            //Graphics graphics = e.Graphics;
            //Font font = new Font("Courier New", 10);
            //float fontHeight = font.GetHeight();
            //int startX = 50;
            //int startY = 55;
            //int Offset = 40;
            //graphics.DrawString("Welcome to MSST", new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;
            //graphics.DrawString("Ticket No:" + this.TicketNo, new Font("Courier New", 14), new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;
            //graphics.DrawString("Ticket Date :" + this.ticketDate, new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;
            //String underLine = "------------------------------------------";
            //graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);

            //Offset = Offset + 20;
            //String Source = this.source;
            //graphics.DrawString("From " + Source + " To " + Destination, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);

            //Offset = Offset + 20;
            //String Grosstotal = "Total Amount to Pay = " + this.amount;

            //Offset = Offset + 20;
            //underLine = "------------------------------------------";
            //graphics.DrawString(underLine, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;

            //graphics.DrawString(Grosstotal, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);
            //Offset = Offset + 20;
            //String DrawnBy = this.drawnBy;
            //graphics.DrawString("Conductor - " + DrawnBy, new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + Offset);

            //------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
