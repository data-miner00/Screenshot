namespace Screenshot.Core;

using System.Drawing;
using System.Runtime.InteropServices;

public static class User32
{
    private const string User32Dll = "user32.dll";

    public const int SHOWNORMAL = 1;
    public const int SHOWMINIMIZED = 2;
    public const int SHOWMAXIMIZED = 3;
    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HTCAPTION = 0x2;

    public const int ALT = 1;
    public const int CTRL = 2;
    public const int META = 3;
    public const int SHIFT = 4;
    public const int WIN = 8;

    [DllImport(User32Dll)]
    public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    [DllImport(User32Dll)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport(User32Dll)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsIconic(IntPtr hWnd);

    [DllImport(User32Dll, SetLastError = true)]
    public static extern bool CloseClipboard();

    [DllImport(User32Dll, SetLastError = true)]
    public static extern bool OpenClipboard(IntPtr hWndNewOwner);

    [DllImport(User32Dll)]
    public static extern bool EmptyClipboard();

    [DllImport(User32Dll)]
    public static extern IntPtr GetOpenClipboardWindow();

    [DllImport(User32Dll)]
    public static extern bool ReleaseCapture();

    [DllImport(User32Dll)]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport(User32Dll)] 
    public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

    [DllImport(User32Dll)]
    public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    [DllImport(User32Dll, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

    [DllImport(User32Dll)]
    public static extern bool GetWindowRect(IntPtr handle, ref Rectangle rect);

    [DllImport(User32Dll, SetLastError = true)]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
}
