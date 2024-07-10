namespace Screenshot.App.Views;

using Screenshot.App.Properties;
using Screenshot.Core;
using System.Diagnostics;
using System.Runtime.InteropServices;

public partial class MainWindow : Form
{
    private readonly string ScreenshotsFolder = Settings.Default.OutputFolderPath;
    private readonly IFileInfoRepository fileInfoRepository;

    public MainWindow(IFileInfoRepository fileInfoRepository)
    {
        InitializeComponent();
        this.fileInfoRepository = fileInfoRepository;
    }

    private void btnWindow_Click(object sender, EventArgs e)
    {
        var windowSelection = new WindowSelection();
        windowSelection.ScreenshotEvent += this.MainWindow_RefreshScreenshotInfoList;
        windowSelection.Show();
    }

    private void btnSettings_Click(object sender, EventArgs e)
    {
        var settings = new SettingsForm();
        settings.Show();
    }

    private void btnArea_Click(object sender, EventArgs e)
    {
        var selectArea = new SelectArea();
        selectArea.ScreenshotEvent += this.MainWindow_RefreshScreenshotInfoList;
        selectArea.Show();
    }

    private void btnFullScreen_Click(object sender, EventArgs e)
    {
        var fullScreen = new FullScreenCapture();
        fullScreen.ScreenshotEvent += this.MainWindow_RefreshScreenshotInfoList;
        fullScreen.Show();
    }

    private void MainWindow_Resize(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            this.Hide();
            this.trayIcon.Visible = true;
        }
    }

    private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        this.Show();
        this.WindowState = FormWindowState.Normal;
        this.trayIcon.Visible = false;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnGithub_Click(object sender, EventArgs e)
    {
        const string GithubLink = "https://github.com/data-miner/Screenshot";

        this.OpenUrl(GithubLink);
    }

    private void OpenUrl(string url)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            url = url.Replace("&", "^&");
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            Process.Start("xdg-open", url);
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            Process.Start("open", url);
        }
        else
        {
            MessageBox.Show("Operating system not supported");
        }
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        this.LoadScreenshotInfoList();
    }

    private void LoadScreenshotInfoList()
    {
        var fileInfo = this.fileInfoRepository.GetFileInfo(this.ScreenshotsFolder);
        ListViewItemConverter converter = new ListViewItemConverter();

        var orderedFileInfo = from info in fileInfo
                              orderby info.CreationTime descending
                              select info;

        this.lstvwScreenshotsHistory.Items.AddRange(orderedFileInfo.Select(this.ConvertFileInfoToListViewItem).ToArray());
        this.lblScreenshotCounts.Text = $"Taken {fileInfo.Length} screenshots";
    }

    private void MainWindow_RefreshScreenshotInfoList(object? sender, string e)
    {
        this.lstvwScreenshotsHistory.Items.Clear();
        this.LoadScreenshotInfoList();
    }

    private ListViewItem ConvertFileInfoToListViewItem(FileInfo fileInfo, int index)
    {
        string[] row = [(index + 1).ToString(), fileInfo.Name, fileInfo.CreationTime.ToString("yyyy MMM d h:mm tt")];
        return new ListViewItem(row);
    }
}
