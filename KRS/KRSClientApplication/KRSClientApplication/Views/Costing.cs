﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRSClientApplication.Views
{
    public partial class Costing : Form
    {
        public Costing()
        {
            InitializeComponent();
        }

        private void CostingClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }
    }
}
