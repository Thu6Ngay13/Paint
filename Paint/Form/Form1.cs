using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Shape;

namespace Paint
{
    public partial class Form1 : Form
    {
        private List<ObjectShape> Shapes;
        private List<ObjectShape> SelectedShapes;
        private bool isDragging = false;
        private bool takedFirstPoint = false;
        private Point nextPoint;
        private int typeDraw = 0;
        private string path = "";

        public Form1()
        {
            InitializeComponent();

            Shapes = new List<ObjectShape>();
            SelectedShapes = new List<ObjectShape>();
            rdbSelectShape.Focus();
            rdbSelectShape.Checked = true;
            takedFirstPoint = false;
            typeDraw = 0;
        }

        private void takeFirstPoint(Point firstPoint)
        {
            takedFirstPoint = true;
            switch (typeDraw)
            {
                case 1:
                    Shapes.Add(new LineShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem, 
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
                case 2:
                    Shapes.Add(new RectangleShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem, 
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
                case 3:
                    Shapes.Add(new EllipseShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem, 
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
                case 4: 
                    Shapes.Add(new PentagonShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem,
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
                case 5:
                    Shapes.Add(new PolygonShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem,
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
                case 6:
                    Shapes.Add(new ArcShape(firstPoint, firstPoint,
                        this.cbbColorFill.SelectedItem,
                        (Color)this.cbbColorOutline.SelectedItem,
                        (float)this.nmrSizeOutline.Value));
                    break;
            }
            return;
        }
        private void drawSelectedTypeOfShape(Point endPoint)
        {
            switch (typeDraw)
            {
                case 1:
                    LineShape line = Shapes[Shapes.Count - 1] as LineShape;
                    line.end = endPoint;
                    line.outline = (Color)this.cbbColorOutline.SelectedItem;
                    line.sizeoutline = (float)this.nmrSizeOutline.Value;
                    line.Draw(this.pnlPaper.CreateGraphics());
                    break;
                case 2:
                    RectangleShape rectangle = Shapes[Shapes.Count - 1] as RectangleShape;
                    rectangle.fill = this.cbbColorFill.SelectedItem;
                    rectangle.outline = (Color)this.cbbColorOutline.SelectedItem;
                    rectangle.end = endPoint;
                    rectangle.sizeoutline = (float)this.nmrSizeOutline.Value;
                    rectangle.Draw(this.pnlPaper.CreateGraphics());
                    break;
                case 3:
                    EllipseShape ellipse = Shapes[Shapes.Count - 1] as EllipseShape;
                    ellipse.fill = this.cbbColorFill.SelectedItem;
                    ellipse.outline = (Color)this.cbbColorOutline.SelectedItem;
                    ellipse.sizeoutline = (float)this.nmrSizeOutline.Value;
                    ellipse.end = endPoint;
                    ellipse.Draw(this.pnlPaper.CreateGraphics());
                    break;
                case 4:
                    PentagonShape pentagon = Shapes[Shapes.Count - 1] as PentagonShape;
                    pentagon.fill = this.cbbColorFill.SelectedItem;
                    pentagon.outline = (Color)this.cbbColorOutline.SelectedItem;
                    pentagon.sizeoutline = (float)this.nmrSizeOutline.Value;
                    pentagon.end = endPoint;
                    pentagon.Draw(this.pnlPaper.CreateGraphics());
                    break;
                case 5:
                    PolygonShape polygon = Shapes[Shapes.Count - 1] as PolygonShape;
                    polygon.fill = this.cbbColorFill.SelectedItem;
                    polygon.outline = (Color)this.cbbColorOutline.SelectedItem;
                    polygon.sizeoutline = (float)this.nmrSizeOutline.Value;
                    polygon.addPoint(endPoint);
                    polygon.Draw(this.pnlPaper.CreateGraphics());
                    this.pnlPaper.Refresh();
                    return;
                case 6:
                    ArcShape arc = Shapes[Shapes.Count - 1] as ArcShape;
                    arc.fill = this.cbbColorFill.SelectedItem;
                    arc.outline = (Color)this.cbbColorOutline.SelectedItem;
                    arc.sizeoutline = (float)this.nmrSizeOutline.Value;
                    arc.end = endPoint;
                    arc.Draw(this.pnlPaper.CreateGraphics());
                    break;
            }
            takedFirstPoint = false;
        }
        private void selectShapeAtLocation(Point location, bool isMultiSelection)
        {
            if (!isMultiSelection)
            {
                foreach (ObjectShape ob in SelectedShapes)
                    ob.Unselected();
                SelectedShapes.Clear();
            }

            int idx = -1;
            for (idx = Shapes.Count - 1; idx >= 0; --idx)
                if (Shapes[idx].InRegion(location))
                    break;

            if (idx == -1) return;
            SelectedShapes.Add(Shapes[idx]);
            Shapes[idx].Select(this.pnlPaper);
        }
        private void dragShapeToLocation(Point delta)
        {
            foreach (ObjectShape ob in SelectedShapes) 
                ob.Relocate(pnlPaper, delta);
        }

        private void rdbSelectShape_CheckedChanged(object sender, EventArgs e)
        {
            takedFirstPoint = false;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            typeDraw = 1;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            typeDraw = 2;
        }
        private void btnElipse_Click(object sender, EventArgs e)
        {
            typeDraw = 3;
        }
        private void btnPentagon_Click(object sender, EventArgs e)
        {
            typeDraw = 4;
        }
        private void btnPolygon_Click(object sender, EventArgs e)
        {
            typeDraw = 5;
        }
        private void btnArc_Click(object sender, EventArgs e)
        {
            typeDraw = 6;
        }

        private void pnlPaper_Paint(object sender, PaintEventArgs e)
        {
            foreach (ObjectShape shape in Shapes)
                shape.Draw(e.Graphics);
        }
        private void pnlPaper_MouseDown(object sender, MouseEventArgs e)
        {
            if (rdbSelectShape.Checked)
            {
                nextPoint = e.Location;
                isDragging = true;
                return;
            }
            if (typeDraw == 0) return;

            if (!takedFirstPoint)
            {
                takeFirstPoint(e.Location);
                return;
            }

            if (typeDraw == 5 && e.Button == MouseButtons.Right)
                takedFirstPoint = false;

            drawSelectedTypeOfShape(e.Location);
        }
        private void pnlPaper_MouseUp(object sender, MouseEventArgs e)
        {
            if (rdbSelectShape.Checked)
            {
                isDragging = false;
                return;
            }
            if (rdbSelectPoint.Checked) return;

            if(typeDraw == 5) return;
            takedFirstPoint = false;
        }
        private void pnlPaper_MouseMove(object sender, MouseEventArgs e)
        {
            if (rdbSelectShape.Checked)
            {
                Point delta = new Point(e.Location.X - nextPoint.X, e.Location.Y - nextPoint.Y);
                if (isDragging) dragShapeToLocation(delta);
                nextPoint = e.Location;
                return;
            }

            if (rdbSelectPoint.Checked) return;
            if (!takedFirstPoint) return;
            
            Shapes[Shapes.Count - 1].UpdateNextPoint(e.Location);
            this.pnlPaper.Refresh();
        }
        private void pnlPaper_MouseClick(object sender, MouseEventArgs e)
        {
            if (!rdbSelectShape.Checked) return;

            bool isMultiSelection = (ModifierKeys == Keys.Control);
            selectShapeAtLocation(e.Location, isMultiSelection);
        }

        private void nmrSizeOutline_ValueChanged(object sender, EventArgs e)
        {
            if (!rdbSelectShape.Checked) return;

            foreach (ObjectShape ob in SelectedShapes)
                ob.change_SizeOfOutline((float)this.nmrSizeOutline.Value);
            pnlPaper.Refresh();
        }
        private void cbbColorOutline_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rdbSelectShape.Checked) return;

            foreach (ObjectShape ob in SelectedShapes)
                ob.change_ColorOfOutline((Color)this.cbbColorOutline.SelectedItem);
            pnlPaper.Refresh();
        }
        private void cbbColorFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!rdbSelectShape.Checked) return;

            foreach (ObjectShape ob in SelectedShapes)
                ob.change_ColorOfFill(this.cbbColorFill.SelectedItem);
            pnlPaper.Refresh();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            Shapes.Add(new ComplexShape(SelectedShapes, 
                new Point(this.pnlPaper.Width, this.pnlPaper.Height), 
                new Point(0, 0), 
                this.cbbColorFill.SelectedItem, 
                (Color)this.cbbColorOutline.SelectedItem,
                (float)this.nmrSizeOutline.Value));
            Shapes[Shapes.Count - 1].Select(this.pnlPaper);

            foreach (ObjectShape ob in SelectedShapes)
                ob.Unselected(); 

            SelectedShapes.Clear();
            SelectedShapes.Add(Shapes[Shapes.Count-1]);
            this.pnlPaper.Refresh();
        }
        private void btnUnGroup_Click(object sender, EventArgs e)
        {
            List<ObjectShape> tmp = new List<ObjectShape>();
            for (int idx = 0; idx < SelectedShapes.Count; ++idx)
            {
                if (SelectedShapes[idx] is ComplexShape)
                {
                    List<ObjectShape> shapes = (SelectedShapes[idx] as ComplexShape).Shapes;
                    for (int i = 0; i < shapes.Count; ++i)
                    {
                        shapes[i].Select(this.pnlPaper);
                        tmp.Add(shapes[i]);
                    }
                    SelectedShapes[idx].Unselected();
                    Shapes.Remove(SelectedShapes[idx]);
                }
                else tmp.Add(SelectedShapes[idx]);
            }

            SelectedShapes.Clear();
            SelectedShapes = tmp;
            this.pnlPaper.Refresh();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(ObjectShape ob in SelectedShapes)
            {
                ob.Unselected();
                Shapes.Remove(ob);
            }
            SelectedShapes.Clear();
            this.pnlPaper.Refresh();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(null, null);
            Shapes.Clear();
            SelectedShapes.Clear();
            this.pnlPaper.BackgroundImage = null;

            this.pnlPaper.Refresh();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.bmp;*.jpg;*.jpeg;*.gif;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;    
                Bitmap bitmap = new Bitmap(ofd.FileName);
                this.pnlPaper.BackgroundImage = new Bitmap(bitmap, this.pnlPaper.Width, this.pnlPaper.Height);
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.pnlPaper.Width, this.pnlPaper.Height);
            Rectangle rect = new Rectangle(0, 0, this.pnlPaper.Width, this.pnlPaper.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillRectangle(new SolidBrush(this.pnlPaper.BackColor), rect);
                if(this.pnlPaper.BackgroundImage != null) 
                    graphics.DrawImage(this.pnlPaper.BackgroundImage, rect);
                foreach (ObjectShape ob in Shapes)
                    ob.Draw(graphics);
            }

            if (!string.IsNullOrEmpty(path))
                bitmap.Save(path);
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg|GIF Image|*.gif";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                    bitmap.Save(sfd.FileName);
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.pnlPaper.Width, this.pnlPaper.Height);
            Rectangle rect = new Rectangle(0, 0, this.pnlPaper.Width, this.pnlPaper.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.FillRectangle(new SolidBrush(this.pnlPaper.BackColor), rect);
                if(this.pnlPaper.BackgroundImage != null)
                    graphics.DrawImage(this.pnlPaper.BackgroundImage, rect);
                foreach (ObjectShape ob in Shapes)
                    ob.Draw(graphics);
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg|GIF Image|*.gif";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                path = sfd.FileName;
                bitmap.Save(sfd.FileName);
            }
        }
    }
}
