﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace уют_
{
    public partial class AutorizationForm: Form
    {
        public AutorizationForm()
        {
            InitializeComponent();

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
