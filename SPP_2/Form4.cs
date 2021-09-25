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
    public partial class ResizeForm : Form
    {
        public ResizeForm()
        {
            InitializeComponent();
        }

        public ResizeForm(int width, int height)
        {
            InitializeComponent();
            NewSize = (width, height);
            widthBox.Text = $"{width}";
            heightBox.Text = $"{height}";
        }
        public (int width, int height) NewSize { get; private set; }
        private void ResizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            NewSize = (System.Convert.ToInt32(widthBox.Text), System.Convert.ToInt32(heightBox.Text));
            this.Close();
        }

        private void CancelBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
