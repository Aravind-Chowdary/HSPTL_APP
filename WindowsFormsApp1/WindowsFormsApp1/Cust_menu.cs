﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cust_menu : Form
    {
        public Cust_menu()
        {
            InitializeComponent();
        }

        private void bookapointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cust_appointment ca1 = new cust_appointment();
            ca1.ShowDialog();
        }
    }
}
