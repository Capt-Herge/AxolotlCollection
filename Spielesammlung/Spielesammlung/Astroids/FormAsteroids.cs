﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Astroids
{
    public partial class FormAsteroids : Form
    {

        public FormAsteroids()
        {
            Bitmap bitmap1 = (Bitmap)Bitmap.FromFile(@"C:\Users\lp_ontour\Dropbox\Softwareprojekt\Axolotl Collection\Dokumente\Lukas\Astroids\Character Design\Asteroiden.bmp");

            InitializeComponent();
        }

        public void Picturbox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


        }
    }
}
