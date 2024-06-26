﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Test
{
    public partial class Family : Form
    {
        public Family()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies M = new Movies();
            M.ShowDialog();
            
        }

        private void pictureBoxF1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketBooking sn = new TicketBooking();
            sn.ShowDialog();
            
        }

        private void pictureBoxF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketBooking sn = new TicketBooking();
            sn.ShowDialog();
            
        }

        private void pictureBoxF3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketBooking sn = new TicketBooking();
            sn.ShowDialog();
            
        }

        private void pictureBoxF4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TicketBooking sn = new TicketBooking();
            sn.ShowDialog();
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Do You Want to Close Program.", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
