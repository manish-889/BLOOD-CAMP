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
    public partial class DeleteDonor : Form
    {   
        Function fn = new Function();
        String query;
        public DeleteDonor()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtDonorID.Text != "")
            {
                query = "select * from newDonar where did = " + txtDonorID.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFather.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMother.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDob.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtBloodGroup.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();
                }

                else
                {
                    MessageBox.Show("Please Enter Valid Record!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorID.Clear();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                query = "delete from newDonar where did = " + txtDonorID.Text + "";
                fn.setDate(query);
            }
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorID.Text == "")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMother.Clear();
                txtDob.Clear(); 
                txtMobile.Clear();
                txtGender.Clear();
                txtEmail.Clear();
                txtBloodGroup.Clear();
                txtCity.Clear();
                txtAddress.Clear();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorID.Clear();
        }

        private void DeleteDonor_Load(object sender, EventArgs e)
        {

        }
    }
}
