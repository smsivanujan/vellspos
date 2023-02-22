namespace vellsPos.Forms.Layouts
{
    public partial class frmTestBarcode : Form
    {
        public frmTestBarcode()
        {
            InitializeComponent();
        }

        private void btn_encode_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pb_barcode.Image = barcode.Draw(txt_encode.Text,50);
        }

        private void txt_encode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
