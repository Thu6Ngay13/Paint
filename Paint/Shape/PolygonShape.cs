using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Shape
{
    public class PolygonShape : ObjectShape
    {
        private int idx;
        private List<Point> points;
        private Button[] btnList;

        public PolygonShape(Point start, Point end, object fill, Color outline, float sizeoutline)
            : base(start, end, fill, outline, sizeoutline)
        {
            points = new List<Point>() { start };
            idx = 1;
        }

        private void updateStartEndPoint(Point point)
        {
            if (point.X < base.start.X)
                base.start.X = point.X;
            if (point.Y < base.start.Y)
                base.start.Y = point.Y;
            if (point.X > base.end.X)
                base.end.X = point.X;
            if (point.Y > base.end.Y)
                base.end.Y = point.Y;
        }
        public bool addPoint(Point point)
        {
            updateStartEndPoint(point);
            points.Add(point);
            idx++;
            return true;
        }
        private Point getDeltaPoint(Point mouseLocation)
        {
            return new Point(mouseLocation.X - base.lastLocation.X, mouseLocation.Y - base.lastLocation.Y);
        }
        private void relocateButtonOfResize()
        {
            for (int i = 0; i < btnList.Length; ++i)
                btnList[i].Location = new Point(points[i].X - 3, points[i].Y - 3);
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

            for (int i = 0; i < btnList.Length; ++i)
                points[i] = btnList[i].Location;

            updateStartEndPoint(button.Location);
            button.Parent.Refresh();
        }
        private void resizeShape_MouseUp(object sender, MouseEventArgs e)
        {
            Point delta = getDeltaPoint(e.Location);
            Button button = sender as Button;
            button.Left += delta.X;
            button.Top += delta.Y;

            for (int i = 0; i < btnList.Length; ++i)
                points[i] = btnList[i].Location;

            updateStartEndPoint(button.Location);
            isResizing = false;
        }

        public override bool InRegion(Point point)
        {
            return Math.Min(base.start.X, end.X) <= point.X && Math.Min(base.start.Y, end.Y) <= point.Y &&
                   Math.Max(base.start.X, end.X) >= point.X && Math.Max(base.start.Y, end.Y) >= point.Y;
        }
        public override void UpdateNextPoint(Point point)
        {
            if(idx == 1) addPoint(point);
            updateStartEndPoint(point);
            points[idx-1] = point;
        }
        public override void Relocate(Panel panel, Point delta)
        {
            if (!isSelected) return;

            for (int idx = 0; idx < btnList.Length; ++idx)
                points[idx] = new Point(points[idx].X + delta.X, points[idx].Y + delta.Y);

            relocateButtonOfResize();
            panel.Refresh();
        }
        public override void Select(Panel panel)
        {
            if (isSelected) return;

            isSelected = true;
            isResizing = false;
            base.lastLocation = new Point(0, 0);

            btnList = new Button[points.Count];
            for (int i = 0; i < btnList.Length; i++)
            {
                btnList[i] = new Button();
                btnList[i].BackColor = Color.White;
                btnList[i].AutoSize = true;
                btnList[i].AllowDrop = true;
                btnList[i].Size = new Size(10, 10);
                btnList[i].MouseDown += new MouseEventHandler(resizeShape_MouseDown);
                btnList[i].MouseMove += new MouseEventHandler(resizeShape_MouseMove);
                btnList[i].MouseUp += new MouseEventHandler(resizeShape_MouseUp);
                btnList[i].Location = new Point(points[i].X - 3, points[i].Y - 3);
                panel.Controls.Add(btnList[i]);
            }
        }
        public override void Unselected()
        {
            isSelected = false;

            for (int i = 0; i < btnList.Length; i++)
                btnList[i].Dispose();
        }
        public override void Draw(Graphics graphic)
        {
            Fill(graphic);
            Outline(graphic);
        }
        public override void Outline(Graphics graphic)
        {
            using (Pen pen = new Pen(base.outline, base.sizeoutline))
            {
                Point[] arraypoint = points.ToArray();
                if (idx < 5)
                {
                    Array.Resize(ref arraypoint, 5);
                    for (int i = idx; i < 5; ++i)
                        arraypoint[i] = points[idx - 1];
                }

                graphic.DrawPolygon(pen, arraypoint);
            }
        }
        public override void Fill(Graphics graphic)
        {
            if (base.fill is string) return;
            using (SolidBrush brush = new SolidBrush((Color)base.fill))
            {
                Point[] arraypoint = points.ToArray();
                if (idx < 5)
                {
                    Array.Resize(ref arraypoint, 5);
                    for (int i = idx; i < 5; ++i)
                        arraypoint[i] = points[idx - 1];
                }

                graphic.FillPolygon(brush, arraypoint);
            }
        }
    }
}
