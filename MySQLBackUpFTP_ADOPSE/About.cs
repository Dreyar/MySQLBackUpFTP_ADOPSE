﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isAboutOpen = false;
        }
    }
}
