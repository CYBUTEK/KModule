using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace KModule
{
    class TitleBar : Label
    {
        private Point _mouseOffset;

        public TitleBar()
        {
            this.MouseMove += TitleBar_MouseMove;
        }

        void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.FindForm().Location = new Point(MousePosition.X - _mouseOffset.X, MousePosition.Y - _mouseOffset.Y);
            }
            else
            {
                _mouseOffset = e.Location;
            }
        }
    }
}
