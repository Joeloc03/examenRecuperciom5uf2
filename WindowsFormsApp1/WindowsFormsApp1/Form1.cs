﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btViatje_Click(object sender, EventArgs e)
        {
            FormViatge Viatge = new FormViatge();
            Viatge.Show();

        }

        private void btMenjar_Click(object sender, EventArgs e)
        {
            FormMenjar Menjar = new FormMenjar();
            Menjar.Show();
        }

        private void btAnimal_Click(object sender, EventArgs e)
        {
            FormAnimals Animals = new FormAnimals();
            Animals.Show();
        }
    }
}
