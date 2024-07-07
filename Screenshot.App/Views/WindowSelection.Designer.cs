namespace Screenshot.App.Views;

partial class WindowSelection
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new Label();
        this.cbxWindowSelector = new ComboBox();
        this.btnRefresh = new Button();
        this.btnScreenshot = new Button();
        this.btnCancel = new Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(157, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Select window to screenshot";
        // 
        // cbxWindowSelector
        // 
        this.cbxWindowSelector.FormattingEnabled = true;
        this.cbxWindowSelector.Location = new Point(12, 27);
        this.cbxWindowSelector.Name = "cbxWindowSelector";
        this.cbxWindowSelector.Size = new Size(195, 23);
        this.cbxWindowSelector.TabIndex = 1;
        this.cbxWindowSelector.SelectedIndexChanged += this.cbxWindowSelector_SelectedIndexChanged;
        // 
        // btnRefresh
        // 
        this.btnRefresh.Location = new Point(213, 26);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new Size(71, 24);
        this.btnRefresh.TabIndex = 6;
        this.btnRefresh.Text = "Refresh";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += this.btnRefresh_Click;
        // 
        // btnScreenshot
        // 
        this.btnScreenshot.Location = new Point(12, 56);
        this.btnScreenshot.Name = "btnScreenshot";
        this.btnScreenshot.Size = new Size(272, 27);
        this.btnScreenshot.TabIndex = 7;
        this.btnScreenshot.Text = "Screenshot";
        this.btnScreenshot.UseVisualStyleBackColor = true;
        this.btnScreenshot.Click += this.btnScreenshot_Click;
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new Point(12, 88);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(272, 27);
        this.btnCancel.TabIndex = 8;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += this.btnCancel_Click;
        // 
        // WindowSelection
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(297, 122);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnScreenshot);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.cbxWindowSelector);
        this.Controls.Add(this.label1);
        this.Name = "WindowSelection";
        this.Text = "WindowSelection";
        Load += this.WindowSelection_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox cbxWindowSelector;
    private Button btnRefresh;
    private Button btnScreenshot;
    private Button btnCancel;
}
