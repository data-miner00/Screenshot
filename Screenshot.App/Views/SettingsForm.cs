namespace Screenshot.App.Views;

using Screenshot.App.Properties;
using Screenshot.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class SettingsForm : Form
{
    private readonly Settings settings = Settings.Default;

    public SettingsForm()
    {
        InitializeComponent();

        var validNamingStrategies = Enum.GetValues<NamingStrategies>()
            .Where(x => x is not NamingStrategies.None)
            .Select(x => x.ToString())
            .ToArray();

        this.cbxNamingStrategy.Items.AddRange(validNamingStrategies);
    }

    private void btnSaveSettings_Click(object sender, EventArgs e)
    {
        this.settings.Save();
        this.Close();
    }

    private void SettingsForm_Load(object sender, EventArgs e)
    {
        this.txtOutputFolder.Text = this.settings.OutputFolderPath;
        this.cbxAutosave.Checked = this.settings.IsAutosave;
        this.cbxOverwriteIfExist.Checked = this.settings.IsOverwriteIfExist;
        this.cbxNamingStrategy.SelectedIndex = this.cbxNamingStrategy.Items.IndexOf(this.settings.NamingStrategy);
    }

    private void txtOutputFolder_TextChanged(object sender, EventArgs e)
    {
        this.settings["OutputFolderPath"] = this.txtOutputFolder.Text;
    }

    private void cbxAutosave_CheckedChanged(object sender, EventArgs e)
    {
        this.settings["IsAutosave"] = this.cbxAutosave.Checked;
    }

    private void cbxSaveAs_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void cbxOverwriteIfExist_CheckedChanged(object sender, EventArgs e)
    {
        this.settings["IsOverwriteIfExist"] = this.cbxOverwriteIfExist.Checked;
    }

    private void cbxNamingStrategy_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.settings["NamingStrategy"] = this.cbxNamingStrategy.SelectedItem;
    }
}
