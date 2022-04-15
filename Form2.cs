using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaWars
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
            btnBack.Enabled = false;
            btnBack.Visible = false;
            txtabout.Enabled = false;
            txtabout.Visible = false;

            txtFAQ.Enabled = false;
            txtFAQ.Visible = false;
            txtabout.BackColor = Color.Cyan;
            txtFAQ.BackColor = Color.Cyan;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmMain newForm = new FrmMain();
            newForm.Show();
            this.Hide();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            btnStart.Enabled = false;
            btnStart.Visible = false;


            btnAbout.Enabled = false;
            btnAbout.Visible = false;


            btnFAQ.Enabled = false;
            btnFAQ.Visible = false;


            btnBack.Enabled = true;
            btnBack.Visible = true;


            lbltitle.Enabled = false;
            lbltitle.Visible = false;


            txtabout.Enabled = true;
            txtabout.Visible = true;
     
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStart.Visible = true;


            btnAbout.Enabled = true;
            btnAbout.Visible = true;


            btnFAQ.Enabled = true;
            btnFAQ.Visible = true;


            btnBack.Enabled = false;
            btnBack.Visible = false;


            lbltitle.Enabled = true;
            lbltitle.Visible = true;


            txtabout.Enabled = false;
            txtabout.Visible = false;

            txtFAQ.Enabled = false;
            txtFAQ.Visible = false;

        }

        private void btnFAQ_Click(object sender, EventArgs e)
        {

            btnStart.Enabled = false;
            btnStart.Visible = false;


            btnAbout.Enabled = false;
            btnAbout.Visible = false;


            btnFAQ.Enabled = false;
            btnFAQ.Visible = false;


            btnBack.Enabled = true;
            btnBack.Visible = true;


            lbltitle.Enabled = false;
            lbltitle.Visible = false;


            txtFAQ.Enabled = true;
            txtFAQ.Visible = true;
        }
    }
    }

  
