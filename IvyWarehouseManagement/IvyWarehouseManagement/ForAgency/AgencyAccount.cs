﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvyWarehouseManagement.ForAgency
{
    public partial class AgencyAccount : Form
    {
        MainInterfaceCus main;
        public AgencyAccount(MainInterfaceCus main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login next = new Login();
            main.Hide();
            next.ShowDialog();
            main.Close();
        }
    }
}
