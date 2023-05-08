using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Shape
{
    public class LineShape : ObjectShape
    {
        private Button btnHead;
        private Button btnTail;

        public LineShape(Point start, Point end, object fill, Color outline, float sizeoutline)
            : base(start, end, fill, outline, sizeoutline)
        {
        }

        private Point getDeltaPoint(Point mouseLocation)
        {
            return new Point(mouseLocation.X - base.lastLocation.X, mouseLocation.Y - base.lastLocation.Y);
        }
        private void relocateButtonOfResize()
        {
            btnHead.Location = new Point(start.X - 3, start.Y - 3);
            btnTail.Location = new Point(end.X - 3, end.Y - 3);
        }
        private void resizeShape_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            base.lastLocation = e.Location;
        }
        private void resizeShape_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isResizing) return;

            Point delta = getDeltaPoint(e.Location);
            Button button = sender as Button;
            button.Left += delta.X;
            button.Top += delta.Y;

            if (button == btnHead) start = button.Location;
            else end = button.Location;

            button.Parent.Refresh();
        }
        private void resizeShape_MouseUp(object sender, MouseEventArgs e)
        {
            Point delta = getDeltaPoint(e.Location);
            Button button = sender as Button;
            button.Left += delta.X;
            button.Top += delta.Y;

            if (button == btnHead) start = button.Location;
            else end = button.Location;

            isResizing = false;
        }

        public override bool InRegion(Point point)
        {
            int dx = start.X - end.X;
            int dy = start.Y - end.Y;
            double d = Math.Abs(1.0 * point.Y * dy - point.X * dx + start.X * dx - start.Y * dy) / Math.Sqrt(dy * dy + dx * dx);
            return d < 10;
        }
        public override void UpdateNextPoint(Point point)
        {
            base.end = point;   
        }
        public override void Relocate(Panel panel, Point delta)
        {
            if (!isSelected) return;

            start.X += delta.X;
            start.Y += delta.Y;

            end.X += delta.X;
            end.Y += delta.Y;

            relocateButtonOfResize();
            panel.Refresh();
        }
        public override void Select(Panel panel)
        {
            if (isSelected) return;

            isSelected = true;
            isResizing = false;
            base.lastLocation = new Point(0, 0);

            btnTail = new Button();
            btnHead = new Button();

            btnHead.AutoSize = true;
            btnTail.AutoSize = true;

            btnHead.AllowDrop = true;
            btnTail.AllowDrop = true;

            btnHead.Size = new Size(10, 10);
            btnTail.Size = new Size(10, 10);

            btnHead.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnHead.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnHead.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnTail.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnTail.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnTail.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnHead.Location = new Point(start.X - 3, start.Y - 3);
            btnTail.Location = new Point(end.X - 3, end.Y - 3);

            panel.Controls.Add(btnHead);
            panel.Controls.Add(btnTail);
        }
        public override void Unselected()
        {
            isSelected = false;

            btnHead.Dispose();
            btnTail.Dispose();
        }
        public override void Draw(Graphics graphic)
        {
            Outline(graphic);
        }
        public override void Outline(Graphics graphic)
        {
            using (Pen pen = new Pen(base.outline, base.sizeoutline))
            {
                graphic.DrawLine(pen, start.X, start.Y, end.X, end.Y);
            }
        }
        public override void Fill(Graphics graphic)
        {
            return;
        }
    }
}
