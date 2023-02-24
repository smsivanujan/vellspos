using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using vellsPos.Entities.Layouts;
using vellsPos.Services;

namespace vellsPos.Forms.Layouts
{
    public partial class frmView : Form
    {
        private int currentLowerLimit = 0;
        private int selectionLimit = Constants.DATA_ROW_PAGE_LIMIT;
        private int totalData = 0;
        private DataTable dummytable = new DataTable();
        private DataViewParam dvParam = new DataViewParam();
        private TextBox idBox;
        private TextBox labelBox;
        private bool isThisForSelection = false;

        private FormMovable formMove ;

        public frmView(DataViewParam dvParam)
        {
            this.dvParam = dvParam;
            InitializeComponent();

            formMove = new FormMovable(this);
            formMove.SetMovable(pnl_head, lbl_title);
            //DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public frmView(DataViewParam dvParam, TextBox idBox, TextBox labelBox)
        {
            this.idBox = idBox;
            this.labelBox = labelBox;
            this.dvParam = dvParam;
            isThisForSelection = true;
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            if (dvParam.AddForm == null)
            {
                btn_add.Visible = false;
            }

            if (dvParam.Hidebox == "hide")
            {
                pb_search.Visible = false;
                txt_search.Visible = false;
            }

            if (dvParam.ShowImage == "show")
            {
                //pbImage.Visible = true;
            }
            else
            {
                //pbImage.Hide();
            }

            this.lbl_title.Text = dvParam.Title;
            this.Text = dvParam.Title;
            GridViewStyler.makeBasicStylesForGridView(dataGridView);
            populateGrid();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;//new 
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (currentLowerLimit < 0)
            {
                btn_next.Hide();
            }
            else
            {
                currentLowerLimit = currentLowerLimit + selectionLimit;
                try
                {
                    if (currentLowerLimit >= totalData)
                    {
                        btn_next.Visible = false;
                    }
                    else
                    {
                        btn_next.Visible = true;
                        populateGrid();
                    }

                    btn_previous.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if ((currentLowerLimit + 1) == 1)// currentLowerLimit + 1
            {
                btn_previous.Hide();
            }
            else
            {
                currentLowerLimit = currentLowerLimit - selectionLimit;
                try
                {
                    if (currentLowerLimit < 0)//<0
                    {
                        btn_previous.Visible = false;
                    }
                    else
                    {
                        btn_previous.Visible = true;
                        populateGrid();
                    }

                    btn_next.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void populateGrid()
        {
            //try
            //{
                BindingSource bsource = new BindingSource();


                string sql = dvParam.SelectSql + dvParam.FromSql + dvParam.GroupSql;

            Console.WriteLine(sql);

                List<QueryParameter> qpList = new List<QueryParameter>();
                for (int x = 0; x < dvParam.SearchParamCount; x++)
                {
                    qpList.Add(new QueryParameter("s" + (x + 1), MySqlDbType.String, "%" + txt_search.Text + "%"));
                }

                QueryCommand qCommand = new QueryCommand(sql, qpList);

                bsource.DataSource = DBTransactionService.getDataAsDataTable(currentLowerLimit, Constants.DATA_ROW_PAGE_LIMIT, qCommand);
                dataGridView.DataSource = bsource;

                GridViewStyler.makeColumnInvisible(dataGridView, new List<int>() { 0 }); //invisible columns
                GridViewStyler.changeHeaderText(dataGridView, dvParam.TitleList); //column header texts
                GridViewStyler.changeHeaderWidth(dataGridView, dvParam.FixedColumnNumber); //column sizes ( 2nd parameter is the column number of the column to autosize )
                GridViewStyler.UpdateFont(dataGridView); //update font

                foreach (int colIndex in dvParam.NumericColumnList)
                {
                    GridViewStyler.changeToTwoDecimalFormat(dataGridView.Columns[colIndex]);
                }

                //updating texts on paging box
                int ul = 0;
                string countSql = "SELECT COUNT(*) as tc " + dvParam.FromSql;
            Console.WriteLine(countSql);
                QueryCommand totalQCommand = new QueryCommand(countSql, qpList);
                string cs = DBTransactionService.getScalerData(totalQCommand);
                totalData = int.Parse(cs);

                if ((currentLowerLimit + Constants.DATA_ROW_PAGE_LIMIT) >= totalData)
                    ul = totalData;
                else
                    ul = (currentLowerLimit + Constants.DATA_ROW_PAGE_LIMIT);

                lbl_sortStatus.Text = " Showing " + (currentLowerLimit + 1) + " to " + ul + " of " + totalData;
                if (!String.IsNullOrEmpty(txt_search.Text)) lbl_sortStatus.Text = "Total Results : " + totalData;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //public void cellClick(int id)
        //{
        //    String dbsql = "select count(db) from employee where id= '" + id + "' ";
        //    Int32 Countdb = Int32.Parse(DBTransactionService.getScalerData(dbsql));

        //    if (Countdb == 0)
        //    {
        //        pb_img.Hide();
        //    }
        //    else if (Countdb != 0)
        //    {
        //        pb_img.Show();
        //        MySqlConnection conn = new MySqlConnection(ConnectionManager.getConnectionString());
        //        MySqlDataReader dr;
        //        string sql1 = "select db from employee where id=@id";
        //        conn.Open();
        //        using (MySqlCommand cmd = new MySqlCommand(sql1, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);
        //            cmd.ExecuteNonQuery();
        //            dr = cmd.ExecuteReader();
        //        }
        //        while (dr.Read())
        //        {
        //            byte[] img = (byte[])dr["db"];
        //            MemoryStream ms = new MemoryStream(img);
        //            pb_img.Image = System.Drawing.Image.FromStream(ms);
        //        }
        //        dr.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvParam.ShowImage == "show")
            {
                if (e.RowIndex >= 0 && isThisForSelection)
                {
                    idBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //cellClick(Int32.Parse(idBox.Text));
                }
            }
            else
            {
                if (dvParam.ViewForm == null)
                {
                    //test
                }
                else
                {
                    if (e.RowIndex >= 0 && isThisForSelection)
                    {
                        idBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        labelBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Type thisType = dvParam.ViewForm.GetType();//
                        Form instance = (Form)Activator.CreateInstance(thisType);//
                        this.Close();
                    }
                    else if (isThisForSelection)
                    {
                        MessageBox.Show("Please click on a data row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DoubleCellClick
            if (dvParam.ViewForm == null)
            {
                //
            }
            else
            {
                if (e.RowIndex >= 0 && !isThisForSelection)
                {
                    String uid = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dvParam.ViewForm.Tag = uid;
                    Type thisType = dvParam.ViewForm.GetType();
                    Form instance = (Form)Activator.CreateInstance(thisType);
                    instance.Tag = uid;
                    instance.Show();
                }
                else if (!isThisForSelection)
                {
                    MessageBox.Show("No Data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //SingleCellClick
            if (dvParam.ShowImage == "show")
            {
                if (dvParam.ViewForm == null)
                {
                    //test
                }
                else
                {
                    if (e.RowIndex >= 0 && isThisForSelection)
                    {
                        idBox.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        labelBox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        Type thisType = dvParam.ViewForm.GetType();//
                        Form instance = (Form)Activator.CreateInstance(thisType);//
                        this.Close();
                    }
                    else if (isThisForSelection)
                    {
                        MessageBox.Show("Please click on a data row", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //
            }
        }

        private void frmView_Activated(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Type thisType = dvParam.AddForm.GetType();
            Form instance = (Form)Activator.CreateInstance(thisType);
            instance.Show();
        }
    }
}
