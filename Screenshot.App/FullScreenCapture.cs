namespace Screenshot.App;

using Screenshot.App.Properties;
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

public partial class FullScreenCapture : Form
{
    private const int DelayInSeconds = 1;

    public FullScreenCapture()
    {
        InitializeComponent();
        this.tbxDelay.Text = DelayInSeconds.ToString();
    }

    private void FullScreenCapture_Load(object sender, EventArgs e)
    {
        var screens = Screen.AllScreens.Select(x => x.DeviceName).ToArray();
        this.cbxSelectScreen.Items.AddRange(screens);
    }

    private async void btnCapture_Click(object sender, EventArgs e)
    {
        this.Hide();
        await Task.Delay(TimeSpan.FromSeconds(DelayInSeconds));
        var screenshot = ScreenshotHelper.ScreenshotFull();

        if (screenshot is null)
        {
            return;
        }

        var preview = new PreviewForm(screenshot);
        await Task.Delay(1000);
        this.Show();
        preview.Show();
    }
}
