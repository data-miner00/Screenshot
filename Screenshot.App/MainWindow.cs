namespace Screenshot.App;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You've accidentally clicked on the label.");
    }

    private void btnWindow_Click(object sender, EventArgs e)
    {
        var windowSelection = new WindowSelection();
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
        selectArea.Show();
    }

    private void btnFullScreen_Click(object sender, EventArgs e)
    {
        var fullScreen = new FullScreenCapture();
        fullScreen.Show();
    }
}
