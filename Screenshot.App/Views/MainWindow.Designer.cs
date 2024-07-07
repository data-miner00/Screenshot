namespace Screenshot.App.Views;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        this.btnArea = new Button();
        this.label1 = new Label();
        this.btnWindow = new Button();
        this.btnSettings = new Button();
        this.btnFullScreen = new Button();
        this.trayIcon = new NotifyIcon(this.components);
        this.btnExit = new Button();
        this.btnRecord = new Button();
        this.SuspendLayout();
        // 
        // btnArea
        // 
        this.btnArea.Location = new Point(22, 48);
        this.btnArea.Name = "btnArea";
        this.btnArea.Size = new Size(110, 50);
        this.btnArea.TabIndex = 0;
        this.btnArea.Text = "Specific Area";
        this.btnArea.UseVisualStyleBackColor = true;
        this.btnArea.Click += this.btnArea_Click;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(71, 18);
        this.label1.Name = "label1";
        this.label1.Size = new Size(130, 15);
        this.label1.TabIndex = 2;
        this.label1.Text = "Take useful screenshots";
        // 
        // btnWindow
        // 
        this.btnWindow.Location = new Point(22, 104);
        this.btnWindow.Name = "btnWindow";
        this.btnWindow.Size = new Size(110, 50);
        this.btnWindow.TabIndex = 3;
        this.btnWindow.Text = "Isolated Window";
        this.btnWindow.UseVisualStyleBackColor = true;
        this.btnWindow.Click += this.btnWindow_Click;
        // 
        // btnSettings
        // 
        this.btnSettings.Location = new Point(22, 160);
        this.btnSettings.Name = "btnSettings";
        this.btnSettings.Size = new Size(110, 50);
        this.btnSettings.TabIndex = 4;
        this.btnSettings.Text = "Settings";
        this.btnSettings.UseVisualStyleBackColor = true;
        this.btnSettings.Click += this.btnSettings_Click;
        // 
        // btnFullScreen
        // 
        this.btnFullScreen.Location = new Point(138, 48);
        this.btnFullScreen.Name = "btnFullScreen";
        this.btnFullScreen.Size = new Size(110, 50);
        this.btnFullScreen.TabIndex = 5;
        this.btnFullScreen.Text = "Full Screen";
        this.btnFullScreen.UseVisualStyleBackColor = true;
        this.btnFullScreen.Click += this.btnFullScreen_Click;
        // 
        // trayIcon
        // 
        this.trayIcon.BalloonTipIcon = ToolTipIcon.Info;
        this.trayIcon.BalloonTipText = "Access Screenshot again here";
        this.trayIcon.BalloonTipTitle = "Minimized to tray";
        this.trayIcon.Icon = (Icon)resources.GetObject("trayIcon.Icon");
        this.trayIcon.Text = "Access Screenshot";
        this.trayIcon.MouseDoubleClick += this.trayIcon_MouseDoubleClick;
        // 
        // btnExit
        // 
        this.btnExit.Location = new Point(138, 160);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new Size(110, 50);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += this.btnExit_Click;
        // 
        // btnRecord
        // 
        this.btnRecord.Location = new Point(138, 104);
        this.btnRecord.Name = "btnRecord";
        this.btnRecord.Size = new Size(110, 50);
        this.btnRecord.TabIndex = 7;
        this.btnRecord.Text = "Recording";
        this.btnRecord.UseVisualStyleBackColor = true;
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(270, 228);
        this.Controls.Add(this.btnRecord);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnFullScreen);
        this.Controls.Add(this.btnSettings);
        this.Controls.Add(this.btnWindow);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnArea);
        this.Name = "MainWindow";
        this.Text = "Screenshot";
        Resize += this.MainWindow_Resize;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button btnArea;
    private Label label1;
    private Button btnWindow;
    private Button btnSettings;
    private Button btnFullScreen;
    private NotifyIcon trayIcon;
    private Button btnExit;
    private Button btnRecord;
}
