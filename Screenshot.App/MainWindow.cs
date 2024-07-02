namespace Screenshot.App;

using Screenshot.Core;

public partial class MainWindow : Form
{
    private readonly IOutputNamingStrategy outputNamingStrategy;

    public MainWindow()
    {
        InitializeComponent();
        var extension = "bmp";
        this.outputNamingStrategy = new OutputNamingStrategyFactory(extension).Create("timestamp");
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
        this.Hide();
        ScreenshotHelper.ScreenshotFull(this.outputNamingStrategy.Construct());
        this.Show();
    }
}
