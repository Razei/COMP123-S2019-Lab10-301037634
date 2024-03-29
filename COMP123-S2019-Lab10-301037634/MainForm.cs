﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_301037634
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackButton_Click(sender, e);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.END_FORM].Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
