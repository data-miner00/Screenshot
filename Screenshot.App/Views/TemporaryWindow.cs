namespace Screenshot.App.Views;

using Screenshot.Core.Specialized;
using System.Windows.Forms;

/// <summary>
/// The temporary window for testing.
/// </summary>
public partial class TemporaryWindow : Form
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TemporaryWindow"/> class.
    /// </summary>
    public TemporaryWindow()
    {
        this.InitializeComponent();

        this.canvas1.CreateDrawable(new GDIObject());
    }
}
