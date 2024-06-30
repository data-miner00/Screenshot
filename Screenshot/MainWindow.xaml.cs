using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinForm = System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;
using Screen = System.Windows.Forms.Screen;

namespace Screenshot;

// Resources: https://www.c-sharpcorner.com/UploadFile/2d2d83/how-to-capture-a-screen-using-C-Sharp/
// Read: https://nishanc.medium.com/c-screenshot-utility-to-capture-a-portion-of-the-screen-489ddceeee49

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        this.PrintScreen();
    }

    private void PrintScreen()
    {
        try
        {
            Bitmap captureBitmap = new(1024, 768, PixelFormat.Format32bppArgb);
            Rectangle capturedRect = Screen.PrimaryScreen.Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(capturedRect.Left, capturedRect.Top, 0, 0, capturedRect.Size);
            captureBitmap.Save(@"D:\Uploads\prtsrc.jpg", ImageFormat.Jpeg);
            System.Windows.MessageBox.Show("Screen Captured");
        }
        catch (Exception ex)
        {
            System.Windows.MessageBox.Show(ex.Message);
        }
    }
}