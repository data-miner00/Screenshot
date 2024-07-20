namespace Screenshot.Core.Specialized;

public class GDIObject : IDrawable
{
    public virtual int X { get; set; } = 0;

    public virtual int Y { get; set; } = 0;

    public virtual int Width { get; set; } = 100;

    public virtual int Height { get; set; } = 100;

    public virtual Color FillColor { get; set; } = Color.White;

    public virtual Color OutlineColor { get; set; } = Color.Black;

    public virtual void Draw(Graphics g)
    {
        g.DrawRectangle(new Pen(this.OutlineColor), new Rectangle(this.X, this.Y, this.Width, this.Height));
        g.FillRectangle(new SolidBrush(this.FillColor), new Rectangle(this.X + 1, this.Y + 1, this.Width - 1, this.Height - 1));
    }
}
