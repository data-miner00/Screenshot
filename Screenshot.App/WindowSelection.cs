using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot.App
{
    public partial class WindowSelection : Form
    {
        public WindowSelection()
        {
            InitializeComponent();
        }

        private void WindowSelection_Load(object sender, EventArgs e)
        {
            this.cbxWindowSelector.DataSource = GetAllWindowHandleNames();
        }

        private static List<string> GetAllWindowHandleNames()
        {
            List<string> windowHandleNames = new();
            foreach (Process window in Process.GetProcesses())
            {
                window.Refresh();
                if (window.MainWindowHandle != IntPtr.Zero && !string.IsNullOrEmpty(window.MainWindowTitle))
                    windowHandleNames.Add(window.ProcessName);
            }
            return windowHandleNames;
        }

        private void cbxWindowSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxWindowSelector.SelectedItem is not null)
            {
                this.btnScreenshot.Enabled = true;
            }
            else
            {
                this.btnScreenshot.Enabled = false;
            }
        }

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            if (this.cbxWindowSelector.SelectedItem is not string selection)
            {
                MessageBox.Show("Selected window is null");
                return;
            }

            var img = ScreenshotHelper.GetBitmapScreenshot(selection);
            if (img == null)
            {
                MessageBox.Show("Image is null");
                return;
            }
            this.lblSelectedWindow.Text = $"Selected window: {this.cbxWindowSelector.SelectedItem}";

            this.pbxScreenshotPreview.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbxScreenshotPreview.Image = img;
        }
    }
}
