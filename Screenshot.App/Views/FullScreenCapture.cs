namespace Screenshot.App.Views;

using Screenshot.App;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The form for full screen capture.
/// </summary>
public sealed partial class FullScreenCapture : Form
{
    private const string ScreenshotType = "fullscreen";
    private const int DelayInSeconds = 1;

    /// <summary>
    /// The event that raises when screenshot was fired.
    /// </summary>
    public EventHandler<string>? ScreenshotEvent;

    /// <summary>
    /// Initializes a new instance of the <see cref="FullScreenCapture"/> class.
    /// </summary>
    public FullScreenCapture()
    {
        this.InitializeComponent();
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
        this.RaiseScreenshotEvent();

        await Task.Delay(1000);
        this.Show();
        preview.Show();
    }

    private void RaiseScreenshotEvent()
    {
        this.ScreenshotEvent?.Invoke(this, ScreenshotType);
    }
}
