﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Numeros_Letras
{
    public partial class Form1 : Form
    {
        Conversion c = new Conversion();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtLetras.Text = c.enletras(txtNumero.Text).ToLower();

        }
    }
}
