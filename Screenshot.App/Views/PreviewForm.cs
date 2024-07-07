namespace Screenshot.App.Views;

using Screenshot.App.Properties;
using Screenshot.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class PreviewForm : Form
{
    private const string DefaultNamingStrategy = "timestamp";
    private const string DefaultImageFileExtension = "bmp";
    private static readonly IEnumerable<string> AllowedNamingStrategy = new List<string>
    {
        "timestamp",
        "guid",
    };

    private readonly IOutputNamingStrategy outputNamingStrategy;
    private readonly Image image;

    public PreviewForm(Image image)
    {
        InitializeComponent();
        var strategySetting = Settings.Default.NamingStrategy;

        if (!AllowedNamingStrategy.Contains(strategySetting))
        {
            strategySetting = DefaultNamingStrategy;
        }

        var namingStrategyFactory = new OutputNamingStrategyFactory(DefaultImageFileExtension);

        this.outputNamingStrategy = namingStrategyFactory.Create(strategySetting);


        this.image = Guard.ThrowIfNull(image);
        this.SaveScreenshot();

        this.pbxPreview.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbxPreview.Image = image;
    }

    private void SaveScreenshot()
    {
        var settingFolderPath = Settings.Default.OutputFolderPath;
        Directory.CreateDirectory(settingFolderPath);

        var outputFilePath = $"{settingFolderPath}/{this.outputNamingStrategy.Construct()}";

        this.image.Save(outputFilePath, ImageFormat.Bmp);
    }

    private void btnSaveAs_Click(object sender, EventArgs e)
    {
        SaveFileDialog sfd = new()
        {
            CheckPathExists = true,
            FileName = "Capture",
            Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp"
        };

        if (sfd.ShowDialog() == DialogResult.OK)
        {
            this.pbxPreview.Image.Save(sfd.FileName);
        }
    }
}
