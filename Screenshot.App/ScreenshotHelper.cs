namespace Screenshot.App;

using Screenshot.Core;
using System.Diagnostics;

/// <summary>
/// Some generic screenshot helper methods.
/// </summary>
internal static class ScreenshotHelper
{
    public static Image? GetBitmapScreenshot(string processName)
    {
        Image? img = null;

        // Reference: https://ourcodeworld.com/articles/read/890/how-to-solve-csharp-exception-current-thread-must-be-set-to-single-thread-apartment-sta-mode-before-ole-calls-can-be-made-ensure-that-your-main-function-has-stathreadattribute-marked-on-it
        Thread t = new(() =>
        {
            IntPtr handle = GetWindowHandle(processName);

            // Check if window is minimized and show it if needed
            if (User32.IsIconic(handle))
            {
                User32.ShowWindowAsync(handle, User32.SHOWNORMAL);
            }

            User32.SetForegroundWindow(handle);

            // ALT + PRINT SCREEN gets screenshot of focused window
            // See this article for key list
            // https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys?view=windowsdesktop-6.0#remarks
            SendKeys.SendWait("%({PRTSC})");
            Thread.Sleep(500);

            // The GetImage function in WPF gets a bitmapsource image
            // This could be replaced with the Winforms getimage since that returns an image
            img = Clipboard.GetImage();

            // Uses the user32.dll to make sure the clipboard is empty and closed 
            // Without this you might get errors that the clipboard is already open
            IntPtr clipWindow = User32.GetOpenClipboardWindow();
            User32.OpenClipboard(clipWindow);
            User32.EmptyClipboard();
            User32.CloseClipboard();
            Thread.Sleep(100);
        });

        // Run your code from a thread that joins the STA Thread
        // If this is not done, clipboard functions won't work
        t.SetApartmentState(ApartmentState.STA);
        t.Start();
        t.Join();

        return img;
    }

    // Reference: https://codingvision.net/c-get-desktop-screenshot
    public static Image? ScreenshotFull()
    {
        if (Screen.PrimaryScreen is null)
        {
            return null;
        }

        var bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        using var graphics = Graphics.FromImage(bmp);
        graphics.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);

        return bmp;
    }

    private static IntPtr GetWindowHandle(string name)
    {
        var process = Process.GetProcessesByName(name).FirstOrDefault();
        if (process != null && process.MainWindowHandle != IntPtr.Zero)
        {
            return process.MainWindowHandle;
        }

        return IntPtr.Zero;
    }
}
