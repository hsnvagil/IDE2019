using System.Drawing;
using System.Windows.Forms;

namespace IDE2019.View {
    public partial class StartForm : Form {
        private bool _isPanelDragged;
        private Point _offset;

        public StartForm() {
            InitializeComponent();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                _isPanelDragged = true;
                var pointStartPosition = PointToScreen(new Point(e.X, e.Y));
                _offset = new Point {X = Location.X - pointStartPosition.X, Y = Location.Y - pointStartPosition.Y};
            } else {
                _isPanelDragged = false;
            }

            if (e.Clicks == 2) _isPanelDragged = false;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e) {
            if (!_isPanelDragged) return;
            if (WindowState == FormWindowState.Maximized) WindowState = FormWindowState.Normal;
            var newPoint = label1.PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(_offset);
            Location = newPoint;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e) {
            _isPanelDragged = false;
        }
    }
}