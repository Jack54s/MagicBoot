﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicBoot
{
    public partial class commandView : Form
    {
        public commandView()
        {
            InitializeComponent();
            InitializeCommandList();
        }

        private void InitializeCommandList()
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            addCommand ac = new addCommand();
            ac.Show();
        }
    }
}
