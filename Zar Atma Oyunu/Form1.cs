﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zar_Atma_Oyunu
{
    public partial class Form1 : Form
    {
        #region Tanımlamalar

        Random r = new Random();

        int x1, x2;

        int i = 0;
        
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            i = 0;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            if (i < 10)
            {
                x1 = r.Next(1, 7);
                x2 = r.Next(1, 7);

                pictureBox1.Image = ımageList1.Images[x1 - 1];
                pictureBox2.Image = ımageList1.Images[x2 - 1];
            }

            else
            {

                x1 = r.Next(1, 7);
                x2 = r.Next(1, 7);

                pictureBox1.Image = ımageList1.Images[x1 - 1];
                pictureBox2.Image = ımageList1.Images[x2 - 1];
                timer1.Stop();
            }
            
        }
    }
}