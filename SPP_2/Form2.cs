using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP_2
{
    public partial class RotationForm : Form
    {
        public RotationForm()
        {
            InitializeComponent();
        }

        public float Rotation { get; private set; }

        private void enterButton_Click(object sender, EventArgs e)
        {
            Rotation = (float)System.Convert.ToDouble(angleBox.Text);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Rotation = 0;
            this.Close();
        }

        private void angleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != ',' && !(c=='-' && angleBox.Text=="") && c!=8)
            {
                e.Handled = true;
            }
        }
    }
}
