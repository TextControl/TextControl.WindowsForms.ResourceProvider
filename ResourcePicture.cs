using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tx_resource
{
    public class ResourcePicture : PictureBox
    {
        private Color m_HoverColor = Color.FromArgb(30, 0, 255, 0);
        private Color m_BackColor = Color.White;

        public ResourcePicture()
        {
            this.Padding = new Padding(10);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            this.Cursor = Cursors.Hand;
            this.Margin = new Padding(5);

            this.MouseEnter += ResourcePicture_MouseEnter;
            this.MouseLeave += ResourcePicture_MouseLeave;
        }

        public Color HoverColor { get => m_HoverColor; set => m_HoverColor = value; }
        public Color HoverDefaultColor { get => m_BackColor; set => m_BackColor = value; }

        private void ResourcePicture_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = m_BackColor;
        }

        private void ResourcePicture_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = m_HoverColor;
        }
    }
}
