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

    private readonly IOutputNamingStrategy outputNamingStrategy;

    public FullScreenCapture()
    {
        InitializeComponent();
        this.tbxDelay.Text = DelayInSeconds.ToString();
        var extension = Settings.Default.DefaultImageFormat;
        var namingStrategySetting = Settings.Default.NamingStrategy;
        this.outputNamingStrategy = new OutputNamingStrategyFactory(extension)
            .Create(namingStrategySetting);
    }

    private void FullScreenCapture_Load(object sender, EventArgs e)
    {
        var screens = Screen.AllScreens.Select(x => x.DeviceName).ToArray();
        this.cbxSelectScreen.Items.AddRange(screens);
    }

    private async void btnCapture_Click(object sender, EventArgs e)
    {
        var settingFolderPath = Settings.Default.OutputFolderPath;
        Directory.CreateDirectory(settingFolderPath);

        var filePath = $"{settingFolderPath}/{this.outputNamingStrategy.Construct()}";

        this.Hide();
        await Task.Delay(TimeSpan.FromSeconds(DelayInSeconds));
        ScreenshotHelper.ScreenshotFull(filePath);
        await Task.Delay(1000);
        this.Show();
    }
}
