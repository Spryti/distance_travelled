﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Travelled_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int speed;
            decimal timeTravelled;
            decimal distance;

            speed = Convert.ToInt32(speedTextBox.Text);
            timeTravelled = Convert.ToDecimal(timeTextBox.Text);
            distance = speed * timeTravelled;

            productTextBox.Text = distance.ToString();
        }
    }
}
