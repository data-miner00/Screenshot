namespace Screenshot.App.Views;

using Screenshot.Core;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

/// <summary>
/// The form to select an area for screenshot.
/// </summary>
public sealed partial class SelectArea : Form
{
    private const string ScreenshotType = "area";
    private const char EscapeKeyChar = (char)27;
    private const char EnterKeyChar = '\r';

    /// <summary>
    /// The event that raises when screenshot was fired.
    /// </summary>
    public EventHandler<string>? ScreenshotEvent;

    /// <summary>
    /// Initializes a new instance of the <see cref="SelectArea"/> class.
    /// </summary>
    public SelectArea()
    {
        this.InitializeComponent();

        this.FormBorderStyle = FormBorderStyle.None; // no borders
        this.Opacity = .5D; // make trasparent
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
    }

    private void SelectArea_Load(object sender, EventArgs e)
    {

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.FillRectangle(Brushes.Red, Top);
        e.Graphics.FillRectangle(Brushes.Red, Left);
        e.Graphics.FillRectangle(Brushes.Red, Right);
        e.Graphics.FillRectangle(Brushes.Red, Bottom);
    }

    private const int
        HTLEFT = 10,
        HTRIGHT = 11,
        HTTOP = 12,
        HTTOPLEFT = 13,
        HTTOPRIGHT = 14,
        HTBOTTOM = 15,
        HTBOTTOMLEFT = 16,
        HTBOTTOMRIGHT = 17;

    private const int Thickness = 5;

    private Rectangle Top => new Rectangle(0, 0, this.ClientSize.Width, Thickness);

    private Rectangle Left => new Rectangle(0, 0, Thickness, this.ClientSize.Height);

    private Rectangle Bottom => new Rectangle(0, this.ClientSize.Height - Thickness, this.ClientSize.Width, Thickness);

    private Rectangle Right => new Rectangle(this.ClientSize.Width - Thickness, 0, Thickness, this.ClientSize.Height);

    private Rectangle TopLeft => new Rectangle(0, 0, Thickness, Thickness);

    private Rectangle TopRight => new Rectangle(this.ClientSize.Width - Thickness, 0, Thickness, Thickness);

    private Rectangle BottomLeft => new Rectangle(0, this.ClientSize.Height - Thickness, Thickness, Thickness);

    private Rectangle BottomRight => new Rectangle(this.ClientSize.Width - Thickness, this.ClientSize.Height - Thickness, Thickness, Thickness);

    protected override void WndProc(ref Message message)
    {
        base.WndProc(ref message);

        if (message.Msg == 0x84) // WM_NCHITTEST
        {
            var cursor = this.PointToClient(Cursor.Position);

            if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
            else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
            else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
            else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

            else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
            else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
            else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
            else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
        }
    }

    private void panelDrag_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            User32.ReleaseCapture();
            _ = User32.SendMessage(Handle, User32.WM_NCLBUTTONDOWN, User32.HTCAPTION, 0);
        }
    }

    private void SelectArea_KeyPress(object sender, KeyPressEventArgs e)
    {
        switch (e.KeyChar)
        {
            case EscapeKeyChar:
                this.Close();
                break;
            case EnterKeyChar:
                this.Close();

                var bmp = GetBitmapSection(this.Location.X, this.Location.Y, this.Width, this.Height, this.Size);

                var preview = new PreviewForm(bmp);
                this.RaiseScreenshotEvent();
                preview.Show();
                break;
        }
    }

    private void RaiseScreenshotEvent()
    {
        this.ScreenshotEvent?.Invoke(this, ScreenshotType);
    }

    private static Bitmap GetBitmapSection(Int32 x, Int32 y, Int32 w, Int32 h, Size s)
    {
        var rect = new Rectangle(x, y, w, h);
        var bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
        var graphics = Graphics.FromImage(bmp);
        graphics.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);

        return bmp;
    }
}
