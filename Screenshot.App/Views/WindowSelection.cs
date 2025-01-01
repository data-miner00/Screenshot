namespace Screenshot.App.Views;

using Screenshot.App;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

/// <summary>
/// The selection for window to screenshot.
/// </summary>
public sealed partial class WindowSelection : Form
{
    private const string ScreenshotType = "window";

    /// <summary>
    /// The event that raises when screenshot was fired.
    /// </summary>
    public EventHandler<string>? ScreenshotEvent;

    /// <summary>
    /// Initializes a new instance of the <see cref="WindowSelection"/> class.
    /// </summary>
    public WindowSelection()
    {
        this.InitializeComponent();
    }

    private void WindowSelection_Load(object sender, EventArgs e)
    {
        this.cbxWindowSelector.DataSource = GetAllWindowHandleNames();
    }

    private static List<string> GetAllWindowHandleNames()
    {
        List<string> windowHandleNames = new();
        foreach (Process window in Process.GetProcesses())
        {
            window.Refresh();
            if (window.MainWindowHandle != IntPtr.Zero && !string.IsNullOrEmpty(window.MainWindowTitle))
            {
                windowHandleNames.Add(window.ProcessName);
            }
        }

        return windowHandleNames;
    }

    private void cbxWindowSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (this.cbxWindowSelector.SelectedItem is not null)
        {
            this.btnScreenshot.Enabled = true;
        }
        else
        {
            this.btnScreenshot.Enabled = false;
        }
    }

    private void btnScreenshot_Click(object sender, EventArgs e)
    {
        if (this.cbxWindowSelector.SelectedItem is not string selection)
        {
            MessageBox.Show("Selected window is null");
            return;
        }

        var img = ScreenshotHelper.GetBitmapScreenshot(selection);
        if (img == null)
        {
            MessageBox.Show("Image is null");
            return;
        }

        var preview = new PreviewForm(img);
        this.RaiseScreenshotEvent();
        preview.Show();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        this.cbxWindowSelector.DataSource = GetAllWindowHandleNames();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void RaiseScreenshotEvent()
    {
        this.ScreenshotEvent?.Invoke(this, ScreenshotType);
    }
}
