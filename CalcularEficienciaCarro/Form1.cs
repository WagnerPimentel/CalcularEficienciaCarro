﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularEficienciaCarro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int V = Convert.ToInt32(txtV.Text);
            int T = Convert.ToInt32(txtT.Text);
            int E = Convert.ToInt32(txtE.Text);

            double D = (V * T) / E;
            lblE.Text = "Eficiência por Km é: " + D.ToString();
        }
    }
}
