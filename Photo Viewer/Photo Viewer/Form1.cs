using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Viewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void NewPictureButton_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Load(OpenFileDialog.FileName);
            }
        }

        void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }

        void ChangeBackgroundButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
                PictureBox.BackColor = ColorDialog.Color;
        }

        void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void StrecthButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StrecthButton.Checked == true)
                
                PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                PictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        void ZoomButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ZoomButton.Checked == true)
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            else
                PictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        void AutosizeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AutosizeButton.Checked == true)
                PictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            else
                PictureBox.SizeMode = PictureBoxSizeMode.Normal;
            
        }

        void CenterImageButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CenterImageButton.Checked == true)
                PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            else
                PictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
