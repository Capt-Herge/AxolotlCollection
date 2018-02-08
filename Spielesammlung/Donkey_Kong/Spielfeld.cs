using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung.Donkey_Kong
{
    public partial class Spielfeld : Form
    {
        public int levle { get; set; } = 1;

        public Spielfeld()
        {
            InitializeComponent();
        }

        private void Spielfeld_Load(object sender, EventArgs e)
        {

        }
    }
}
