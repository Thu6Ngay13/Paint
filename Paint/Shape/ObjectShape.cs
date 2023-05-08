using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shape
{
    public abstract class ObjectShape
    {
        public bool isSelected = false;
        public bool isResizing = false;
        public Point lastLocation;

        public Point start;
        public Point end;
        public object fill;
        public Color outline;
        public float sizeoutline;

        public ObjectShape() { }
        public ObjectShape(Point start, Point end, object fill, Color outline, float sizeoutline)
        {
            this.start = start;
            this.end = end;
            this.fill = fill;
            this.outline = outline;
            this.sizeoutline = sizeoutline;
        }

        public virtual void change_SizeOfOutline(float sizeoutline)
        {
            this.sizeoutline = sizeoutline;
        }
        public virtual void change_ColorOfFill(object fill)
        {
            this.fill = fill;
        }
        public virtual void change_ColorOfOutline(Color outline)
        {
            this.outline = outline;
        }

        public abstract bool InRegion(Point point);
        public abstract void UpdateNextPoint(Point point);
        public abstract void Relocate(Panel panel, Point delta);
        public abstract void Select(Panel panel);
        public abstract void Unselected();
        public abstract void Draw(Graphics graphic);
        public abstract void Outline(Graphics graphic);
        public abstract void Fill(Graphics graphic);
    }
}
