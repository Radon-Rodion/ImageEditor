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
    public partial class ScaleForm : Form
    {
        public ScaleForm()
        {
            InitializeComponent();
        }

        public float WidthScale { get; private set; }
        public float HeightScale { get; private set; }

        private void CancelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            WidthScale = 1;
            HeightScale = 1;
            this.Close();
        }

        private void ResizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            WidthScale = (float)System.Convert.ToDouble(widthScaleBox.Text);
            HeightScale = (float)System.Convert.ToDouble(heightScaleBox.Text);
            this.Close();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c!=',' && c != 8)
            {
                e.Handled = true;
            }
        }
    }
}
