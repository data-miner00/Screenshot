namespace Screenshot.App;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Screenshot.Core.Specialized;

public partial class Canvas : UserControl
{
    private readonly IList<IDrawable> drawables = new List<IDrawable>();
    private Point previousMouseLocation;
    private IDrawable? previousSelectedObject;
    private bool isMouseDown;

    public object? selectedObject;

    public Canvas()
    {
        InitializeComponent();

        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        this.SetStyle(ControlStyles.DoubleBuffer, true);
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    public void CreateDrawable(IDrawable drawable)
    {
        this.drawables.Add(drawable);
        this.Invalidate();
    }

    private void Canvas_Paint(object sender, PaintEventArgs e)
    {
        foreach (var drawable in drawables)
        {
            drawable.Draw(e.Graphics);
        }
    }

    private GDIObject? GetObjectAtPoint(Point point)
    {
        foreach (var drawable in drawables)
        {
            if (drawable is GDIObject obj)
            {
                var isWithinXAxis = point.X > obj.X && point.X < obj.X + obj.Width;
                var isWithinYAxis = point.X > obj.X && point.X < obj.X + obj.Width;

                if (isWithinXAxis && isWithinYAxis)
                {
                    return obj;
                }
            }
        }

        return null;
    }

    private void Canvas_MouseClick(object sender, MouseEventArgs e)
    {
        var obj = this.GetObjectAtPoint(e.Location);
        if (obj != null)
        {
            this.selectedObject = obj;
            this.previousSelectedObject = obj;
        }
        else
        {
            this.selectedObject = null;
        }

        this.Invalidate();
    }

    private void Canvas_MouseMove(object sender, MouseEventArgs e)
    {
        var obj = this.GetObjectAtPoint((Point)e.Location);
        if (obj is not null)
        {
            this.Cursor = Cursors.SizeAll;

            if (this.isMouseDown && this.selectedObject is GDIObject valid)
            {
                valid.X = e.X - this.previousMouseLocation.X;
                valid.Y = e.Y - this.previousMouseLocation.Y;

                this.Invalidate();
            }
        }
        else
        {
            this.Cursor = Cursors.Default;
        }
    }

    private void Canvas_MouseDown(object sender, MouseEventArgs e)
    {
        if (this.previousSelectedObject != (GDIObject?)this.selectedObject)
        {
            if (this.selectedObject is GDIObject obj)
            {
                this.previousMouseLocation = new Point(e.X - obj.X, e.Y - obj.Y);
            }
        }
        else
        {
            if (this.previousMouseLocation == Point.Empty)
            {
                this.previousMouseLocation = e.Location;
            }
        }

        this.isMouseDown = true;
    }

    private void Canvas_MouseUp(object sender, MouseEventArgs e)
    {
        this.previousSelectedObject = null;
        this.previousMouseLocation = Point.Empty;
        this.isMouseDown = false;
    }
}
