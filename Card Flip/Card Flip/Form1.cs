using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Flip
{
    public partial class cardFlip : Form
    {
        public cardFlip()
        {
            InitializeComponent();
        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardFrontPictureBox.Visible = false;
            cardBackPictureBox.Visible = true;
        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardFrontPictureBox.Visible = true;
            cardBackPictureBox.Visible = false;
        }
    }
}
