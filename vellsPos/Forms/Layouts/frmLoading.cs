﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vellsPos.Forms.Masters.user;

namespace vellsPos.Forms.Layouts
{
    public partial class frmLoading : Form
    {
        //private FormMovable formMove;

        public frmLoading()
        {
            InitializeComponent();

            //formMove = new FormMovable(this);
            //formMove.SetMovable(pnl_head, lbl_title);

            timer1.Interval = 10000; //10 seconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            frmLogin fh = new frmLogin();
            fh.ShowDialog();
            this.Hide();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }
    }
}
