using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Entities.Layouts;

namespace vellsPos.Forms.Layouts
{
    public partial class frmPointOfSale : Form
    {
        private FormMovable formMove;

        public frmPointOfSale()
        {
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPointOfSale_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
