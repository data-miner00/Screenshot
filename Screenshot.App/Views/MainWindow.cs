namespace Screenshot.App.Views;

using Screenshot.App.Properties;
using Screenshot.Core;
using System.Diagnostics;
using System.Runtime.InteropServices;

/// <summary>
/// The main form.
/// </summary>
public sealed partial class MainWindow : Form
{
    private const int HotKeyId = 1;

    private readonly Settings settings = Settings.Default;
    private readonly string screenshotsFolder = Settings.Default.OutputFolderPath;
    private readonly IFileInfoRepository fileInfoRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainWindow"/> class.
    /// </summary>
    /// <param name="fileInfoRepository">The file info repository.</param>
    public MainWindow(IFileInfoRepository fileInfoRepository)
    {
        this.InitializeComponent();
        this.fileInfoRepository = fileInfoRepository;

        User32.RegisterHotKey(this.Handle, HotKeyId, User32.CTRL, (int)Keys.PrintScreen);
    }

    protected override void WndProc(ref Message m)
    {
        if (m.Msg == 0x0312 && m.WParam.ToInt32() == HotKeyId)
        {
            MessageBox.Show("Clicked!");
        }

        base.WndProc(ref m);
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
        var GithubLink = this.settings.GitHubUrl;

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
        var fileInfo = this.fileInfoRepository.GetFileInfo(this.screenshotsFolder);
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

    private void lstvwScreenshotsHistory_DoubleClick(object sender, EventArgs e)
    {
        var selectedScreenshot = this.lstvwScreenshotsHistory.SelectedItems[0].SubItems[1].Text;

        var filePath = $"{this.screenshotsFolder}/{selectedScreenshot}";

        var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        var image = Image.FromStream(fileStream);

        new PreviewForm(image).Show();
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        new TemporaryWindow().Show();
    }
}
