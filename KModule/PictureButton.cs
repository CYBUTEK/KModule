using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace KModule
{
    class PictureButton : PictureBox
    {
        private Rectangle _rectangle;
        private Image _imageOut;
        private Image _imageHover;
        private Image _imageDown;

        public event EventHandler LeftClick;

        [Description()]
        public Image ImageHover { get { return _imageHover; } set { _imageHover = value; } }

        [Description()]
        public Image ImageDown { get { return _imageDown; } set { _imageDown = value; } }

        [Description()]
        public Rectangle Rectangle { get { return _rectangle; } }

        public PictureButton()
        {
            _rectangle = new Rectangle(this.Location, this.Size);
            this.MouseEnter += PicButton_MouseEnter;
            this.MouseLeave += PicButton_MouseLeave;
            this.MouseDown += PicButton_MouseDown;
            this.MouseUp += PicButton_MouseUp;
        }

        void PicButton_MouseEnter(object sender, EventArgs e)
        {
            _imageOut = Image;
            Image = _imageHover;
        }

        void PicButton_MouseLeave(object sender, EventArgs e)
        {
            Image = _imageOut;
        }

        void PicButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Image = _imageDown;
            }
        }

        void PicButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (_rectangle.Contains(e.Location))
                {
                    Image = _imageHover;
                    if (LeftClick != null)
                    {
                        LeftClick(this, e);
                    }
                }
                else
                {
                    Image = _imageOut;
                }
            }
        }
    }
}
