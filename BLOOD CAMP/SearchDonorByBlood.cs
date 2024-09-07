﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLOOD_CAMP
{
    public partial class SearchDonorByBlood : Form
    {
        Function fn = new Function();
        String query;
        public SearchDonorByBlood()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchDonorByBlood_Load(object sender, EventArgs e)
        {
          query = "select * from newDonar";
          DataSet ds =  fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchBlood_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchBlood.Text != "")
            {
                query = "select * from newDonar where bloodgroup like '" + txtSearchBlood.Text + "%'  ";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else 
            {
                query = "select * from newDonar";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource= ds.Tables[0];
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
