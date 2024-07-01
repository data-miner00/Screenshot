namespace Screenshot.App;

using Screenshot.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class SelectArea : Form
{
    private const char EscapeKeyChar = (char)27;

    public SelectArea()
    {
        InitializeComponent();

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

    Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, Thickness); } }
    Rectangle Left { get { return new Rectangle(0, 0, Thickness, this.ClientSize.Height); } }
    Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - Thickness, this.ClientSize.Width, Thickness); } }
    Rectangle Right { get { return new Rectangle(this.ClientSize.Width - Thickness, 0, Thickness, this.ClientSize.Height); } }
    Rectangle TopLeft { get { return new Rectangle(0, 0, Thickness, Thickness); } }
    Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - Thickness, 0, Thickness, Thickness); } }
    Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - Thickness, Thickness, Thickness); } }
    Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - Thickness, this.ClientSize.Height - Thickness, Thickness, Thickness); } }


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
        if (e.KeyChar == EscapeKeyChar)
        {
            this.Close();
        }
    }
}
