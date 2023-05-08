using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Paint.Shape
{
    public class PentagonShape : ObjectShape
    {
        private Button btnTopLeft;
        private Button btnTopCenter;
        private Button btnTopRight;

        private Button btnCenLeft;
        private Button btnCenRight;

        private Button btnBotLeft;
        private Button btnBotCenter;
        private Button btnBotRight;

        public PentagonShape(Point start, Point end, object fill, Color outline, float sizeoutline)
            : base(start, end, fill, outline, sizeoutline)
        {
        }

        private Point getDeltaPoint(Point mouseLocation)
        {
            return new Point(mouseLocation.X - base.lastLocation.X, mouseLocation.Y - base.lastLocation.Y);
        }
        private void relocateButtonOfResize()
        {
            btnTopLeft.Location = new Point(start.X - 3, start.Y - 3);
            btnTopCenter.Location = new Point((start.X + end.X) / 2 - 3, start.Y - 3);
            btnTopRight.Location = new Point(end.X - 3, start.Y - 3);
            btnCenLeft.Location = new Point(start.X - 3, (start.Y + end.Y) / 2 - 3);
            btnCenRight.Location = new Point(end.X - 3, (start.Y + end.Y) / 2 - 3);
            btnBotLeft.Location = new Point(start.X - 3, end.Y - 3);
            btnBotCenter.Location = new Point((start.X + end.X) / 2 - 3, end.Y - 3);
            btnBotRight.Location = new Point(end.X - 3, end.Y - 3);
        }
        private void corner(Button btnIsUsing, Point mouseLocation)
        {
            Point delta = getDeltaPoint(mouseLocation);

            if (btnIsUsing == btnTopLeft)
                resize_btnTopLeft(delta);
            else if (btnIsUsing == btnTopRight)
                resize_btnTopRight(delta);
            else if (btnIsUsing == btnBotLeft)
                resize_btnBotLeft(delta);
            else if (btnIsUsing == btnBotRight)
                resize_btnBotRight(delta);

            relocateButtonOfResize();
        }
        private void center(Button btnIsUsing, Point mouseLocation)
        {
            Point delta = getDeltaPoint(mouseLocation);

            if (btnIsUsing == btnTopCenter)
                start.Y += delta.Y;
            else if (btnIsUsing == btnBotCenter)
                end.Y += delta.Y;
            else if (btnIsUsing == btnCenLeft)
                start.X += delta.X;
            else if (btnIsUsing == btnCenRight)
                end.X += delta.X;

            relocateButtonOfResize();
        }
        private void resize_btnTopLeft(Point delta)
        {
            start.X += delta.X;
            start.Y += delta.Y;
        }
        private void resize_btnTopRight(Point delta)
        {
            start.Y += delta.Y;
            end.X += delta.X;
        }
        private void resize_btnBotLeft(Point delta)
        {
            start.X += delta.X;
            end.Y += delta.Y;
        }
        private void resize_btnBotRight(Point delta)
        {
            end.X += delta.X;
            end.Y += delta.Y;
        }
        private void resizeShape_MouseDown(object sender, MouseEventArgs e)
        {
            isResizing = true;
            base.lastLocation = e.Location;
        }
        private void resizeShape_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isResizing) return;

            Button button = sender as Button;
            if (button == btnTopLeft || button == btnTopRight ||
                button == btnBotLeft || button == btnBotRight)
                corner(button, e.Location);
            else
                center(button, e.Location);

            button.Parent.Refresh();
        }
        private void resizeShape_MouseUp(object sender, MouseEventArgs e)
        {
            isResizing = false;
        }

        public override bool InRegion(Point point)
        {
            return start.X <= point.X && start.Y <= point.Y &&
                    end.X >= point.X && end.Y >= point.Y;
        }
        public override void UpdateNextPoint(Point point)
        {
            base.end = point;
        }
        public override void Relocate(Panel panel, Point delta)
        {
            Debug.WriteLine(isSelected.ToString());
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

            btnTopLeft = new Button();
            btnTopCenter = new Button();
            btnTopRight = new Button();
            btnCenLeft = new Button();
            btnCenRight = new Button();
            btnBotLeft = new Button();
            btnBotCenter = new Button();
            btnBotRight = new Button();

            btnTopLeft.BackColor = Color.White;
            btnTopCenter.BackColor = Color.White;
            btnTopRight.BackColor = Color.White;
            btnCenLeft.BackColor = Color.White;
            btnCenRight.BackColor = Color.White;
            btnBotLeft.BackColor = Color.White;
            btnBotCenter.BackColor = Color.White;
            btnBotRight.BackColor = Color.White;

            btnTopLeft.AutoSize = true;
            btnTopCenter.AutoSize = true;
            btnTopRight.AutoSize = true;
            btnCenLeft.AutoSize = true;
            btnCenRight.AutoSize = true;
            btnBotLeft.AutoSize = true;
            btnBotCenter.AutoSize = true;
            btnBotRight.AutoSize = true;

            btnTopLeft.AllowDrop = true;
            btnTopCenter.AllowDrop = true;
            btnTopRight.AllowDrop = true;
            btnCenLeft.AllowDrop = true;
            btnCenRight.AllowDrop = true;
            btnBotLeft.AllowDrop = true;
            btnBotCenter.AllowDrop = true;
            btnBotRight.AllowDrop = true;

            btnTopLeft.Size = new Size(10, 10);
            btnTopCenter.Size = new Size(10, 10);
            btnTopRight.Size = new Size(10, 10);
            btnCenLeft.Size = new Size(10, 10);
            btnCenRight.Size = new Size(10, 10);
            btnBotLeft.Size = new Size(10, 10);
            btnBotCenter.Size = new Size(10, 10);
            btnBotRight.Size = new Size(10, 10);

            btnTopLeft.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnTopLeft.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnTopLeft.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnTopCenter.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnTopCenter.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnTopCenter.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnTopRight.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnTopRight.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnTopRight.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnCenLeft.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnCenLeft.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnCenLeft.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnCenRight.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnCenRight.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnCenRight.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnBotLeft.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnBotLeft.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnBotLeft.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnBotCenter.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnBotCenter.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnBotCenter.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnBotRight.MouseDown += new MouseEventHandler(resizeShape_MouseDown);
            btnBotRight.MouseMove += new MouseEventHandler(resizeShape_MouseMove);
            btnBotRight.MouseUp += new MouseEventHandler(resizeShape_MouseUp);

            btnTopLeft.Location = new Point(start.X - 3, start.Y - 3);
            btnTopCenter.Location = new Point((start.X + end.X) / 2 - 3, start.Y - 3);
            btnTopRight.Location = new Point(end.X - 3, start.Y - 3);
            btnCenLeft.Location = new Point(start.X - 3, (start.Y + end.Y) / 2 - 3);
            btnCenRight.Location = new Point(end.X - 3, (start.Y + end.Y) / 2 - 3);
            btnBotLeft.Location = new Point(start.X - 3, end.Y - 3);
            btnBotCenter.Location = new Point((start.X + end.X) / 2 - 3, end.Y - 3);
            btnBotRight.Location = new Point(end.X - 3, end.Y - 3);

            panel.Controls.Add(btnTopLeft);
            panel.Controls.Add(btnTopCenter);
            panel.Controls.Add(btnTopRight);
            panel.Controls.Add(btnCenLeft);
            panel.Controls.Add(btnCenRight);
            panel.Controls.Add(btnBotLeft);
            panel.Controls.Add(btnBotCenter);
            panel.Controls.Add(btnBotRight);
        }
        public override void Unselected()
        {
            isSelected = false;

            btnTopLeft.Dispose();
            btnTopCenter.Dispose();
            btnTopRight.Dispose();
            btnCenLeft.Dispose();
            btnCenRight.Dispose();
            btnBotLeft.Dispose();
            btnBotCenter.Dispose();
            btnBotRight.Dispose();
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
                Point s = base.start;
                Point e = base.end;
                int tmp = (s.X - e.X) / 5;

                Point p1 = new Point((s.X + e.X) / 2, s.Y);
                Point p2 = new Point(e.X, (s.Y + e.Y) / 2);
                Point p3 = new Point(e.X + tmp, e.Y);
                Point p4 = new Point(s.X - tmp, e.Y);
                Point p5 = new Point(s.X, (s.Y + e.Y) / 2);
                Point[] x = new Point[5] { p1, p2, p3, p4, p5 };

                graphic.DrawPolygon(pen, x);
            }
        }
        public override void Fill(Graphics graphic)
        {
            if (base.fill is string) return;
            using (SolidBrush brush = new SolidBrush((Color)base.fill))
            {
                Point s = base.start;
                Point e = base.end;
                int tmp = (s.X - e.X) / 5;

                Point p1 = new Point((s.X + e.X) / 2, s.Y);
                Point p2 = new Point(e.X, (s.Y + e.Y) / 2);
                Point p3 = new Point(e.X + tmp, e.Y);
                Point p4 = new Point(s.X - tmp, e.Y);
                Point p5 = new Point(s.X, (s.Y + e.Y) / 2);
                Point[] x = new Point[5] { p1, p2, p3, p4, p5 };

                graphic.FillPolygon(brush, x);
            }
        }
    }
}
