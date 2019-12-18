using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE2019.Views
{
    public partial class StartForm : Form
    {
        bool isPanelDragged = false;
        Point offset;

        public StartForm()
        {
            InitializeComponent();
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isPanelDragged = false;
            }
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPanelDragged)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                Point newPoint = label1.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            isPanelDragged = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
