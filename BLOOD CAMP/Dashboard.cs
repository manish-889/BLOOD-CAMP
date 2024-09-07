using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm=new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void updateDonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonarDetails udd = new UpdateDonarDetails();
            udd.Show();
        }

        private void allDonarDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodDonorAddress sba =new SearchBloodDonorAddress();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonorByBlood sd =new SearchDonorByBlood();    
            sd.Show();
        }

        private void increaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stockincrease si =new Stockincrease();
            si.Show();
        }

        private void deceraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd =new StockDecrease();   
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock sk =new Stock();
            sk.Show();
        }

        private void deleteDonarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDonor dd = new DeleteDonor();
            dd.Show();
        }
    }
}
