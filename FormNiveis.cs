﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyblade
{
    public partial class FormNiveis : Form
    {
        private NewDataSet _loginData;
        public FormNiveis()
        {
            InitializeComponent();
        }

        private void FormNiveis_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;            //Colocar A janela em FullScreen
            MenuStrip.BackColor = Color.Transparent;
        }

        private void LB_NIVEL_01_Click(object sender, EventArgs e)
        {
            float massa = 10;
            float aceleracao = 10;
            float atrito = 10;
            float velocidade = 10;

            FormNiveis formNiveis = new FormNiveis();
            formNiveis.Show();
            this.Hide();
        }
    }
}
