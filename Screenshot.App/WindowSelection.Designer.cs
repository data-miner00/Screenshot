namespace Screenshot.App;

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
        label1 = new Label();
        cbxWindowSelector = new ComboBox();
        btnScreenshot = new Button();
        lblSelectedWindow = new Label();
        pbxScreenshotPreview = new PictureBox();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)pbxScreenshotPreview).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 9);
        label1.Name = "label1";
        label1.Size = new Size(157, 15);
        label1.TabIndex = 0;
        label1.Text = "Select window to screenshot";
        // 
        // cbxWindowSelector
        // 
        cbxWindowSelector.FormattingEnabled = true;
        cbxWindowSelector.Location = new Point(28, 39);
        cbxWindowSelector.Name = "cbxWindowSelector";
        cbxWindowSelector.Size = new Size(195, 23);
        cbxWindowSelector.TabIndex = 1;
        cbxWindowSelector.SelectedIndexChanged += cbxWindowSelector_SelectedIndexChanged;
        // 
        // btnScreenshot
        // 
        btnScreenshot.Enabled = false;
        btnScreenshot.Location = new Point(28, 159);
        btnScreenshot.Name = "btnScreenshot";
        btnScreenshot.Size = new Size(125, 47);
        btnScreenshot.TabIndex = 2;
        btnScreenshot.Text = "Screenshot";
        btnScreenshot.UseVisualStyleBackColor = true;
        btnScreenshot.Click += btnScreenshot_Click;
        // 
        // lblSelectedWindow
        // 
        lblSelectedWindow.AutoSize = true;
        lblSelectedWindow.Location = new Point(28, 129);
        lblSelectedWindow.Name = "lblSelectedWindow";
        lblSelectedWindow.Size = new Size(99, 15);
        lblSelectedWindow.TabIndex = 3;
        lblSelectedWindow.Text = "Selected window:";
        // 
        // pbxScreenshotPreview
        // 
        pbxScreenshotPreview.Location = new Point(209, 113);
        pbxScreenshotPreview.Name = "pbxScreenshotPreview";
        pbxScreenshotPreview.Size = new Size(663, 414);
        pbxScreenshotPreview.TabIndex = 4;
        pbxScreenshotPreview.TabStop = false;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(209, 86);
        label2.Name = "label2";
        label2.Size = new Size(109, 15);
        label2.TabIndex = 5;
        label2.Text = "Screenshot Preview";
        // 
        // WindowSelection
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(921, 554);
        Controls.Add(label2);
        Controls.Add(pbxScreenshotPreview);
        Controls.Add(lblSelectedWindow);
        Controls.Add(btnScreenshot);
        Controls.Add(cbxWindowSelector);
        Controls.Add(label1);
        Name = "WindowSelection";
        Text = "WindowSelection";
        Load += WindowSelection_Load;
        ((System.ComponentModel.ISupportInitialize)pbxScreenshotPreview).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private ComboBox cbxWindowSelector;
    private Button btnScreenshot;
    private Label lblSelectedWindow;
    private PictureBox pbxScreenshotPreview;
    private Label label2;
}
