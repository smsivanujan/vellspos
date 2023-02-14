using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Services
{
    internal class GridViewStyler
    {
        public static void makeBasicStylesForGridView(DataGridView grid)
        {
            grid.RowHeadersVisible = false;
            grid.CellFormatting += Grid_CellFormatting;
        }

        private static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            GridViewStyler.changeRowColor((DataGridView)sender);
        }

        //Change cell font
        public static void UpdateFont(DataGridView grid)
        {
            foreach (DataGridViewColumn c in grid.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Verdana", 12, GraphicsUnit.Pixel);
                c.HeaderCell.Style.Font = new Font("Verdana", 12, GraphicsUnit.Pixel);
                c.HeaderCell.Style.BackColor = Color.LightGray;
            }
        }

        //Change column width
        public static void changeHeaderWidth(DataGridView grid, int fullCol)
        {
            int x = 0;
            foreach (DataGridViewColumn c in grid.Columns)
            {
                if (c.Visible)
                {
                    if (x == fullCol)
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                x++;
            }
        }

        //change header text
        public static void changeHeaderText(DataGridView grid, List<string> names)
        {
            try
            {
                int x = 0;
                foreach (DataGridViewColumn c in grid.Columns)
                {
                    c.HeaderText = names[x];
                    x++;
                }

                names.Clear();
            }
            catch (Exception)
            {

            }
        }

        //Make column invisible
        public static void makeColumnInvisible(DataGridView grid, List<int> colNum)
        {
            int y = 0;

            foreach (DataGridViewColumn c in grid.Columns)
            {
                foreach (int x in colNum)
                {
                    if (x == y)
                        c.Visible = false;
                }
                y++;
            }
        }

        //row color
        public static void changeRowColor(DataGridView grid)
        {
            int x = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (x % 2 == 0)
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                else
                    row.DefaultCellStyle.BackColor = Color.White;

                row.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                row.DefaultCellStyle.SelectionForeColor = Color.Black;
                x++;
            }
        }

        //change column values format to two decimal place --> 2.36
        public static void changeToTwoDecimalFormat(DataGridViewColumn column)
        {
            column.DefaultCellStyle.Format = "N2";
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
