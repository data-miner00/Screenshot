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

using AppImageFormat = Screenshot.Core.Models.ImageFormat;
using NamingStrategies = Screenshot.Core.Models.NamingStrategies;

public partial class PreviewForm : Form
{
    private readonly NamingStrategies DefaultNamingStrategy = NamingStrategies.Timestamp;
    private readonly AppImageFormat DefaultImageFileExtension = AppImageFormat.Bmp;

    private readonly Settings settings = Settings.Default;
    private readonly IOutputNamingStrategy outputNamingStrategy;
    private readonly Image image;

    public PreviewForm(Image image)
    {
        InitializeComponent();
        var strategySetting = this.settings.NamingStrategy;

        if (!Enum.TryParse<NamingStrategies>(strategySetting, out var parsedStrategy))
        {
            parsedStrategy = NamingStrategies.Timestamp;
        }

        var namingStrategyFactory = new OutputNamingStrategyFactory(DefaultImageFileExtension);

        this.outputNamingStrategy = namingStrategyFactory.Create(parsedStrategy);

        this.image = Guard.ThrowIfNull(image);
        this.SaveScreenshot();

        this.pbxPreview.SizeMode = PictureBoxSizeMode.Zoom;
        this.pbxPreview.Image = image;
    }

    private void SaveScreenshot()
    {
        var settingFolderPath = this.settings.OutputFolderPath;
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
