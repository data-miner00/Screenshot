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
        this.btnFullScreen = new Button();
        this.trayIcon = new NotifyIcon(this.components);
        this.btnExit = new Button();
        this.btnRecord = new Button();
        this.btnGithub = new Button();
        this.btnHelp = new Button();
        this.btnSettings = new Button();
        this.lstvwScreenshotsHistory = new ListView();
        this.colFileIndex = new ColumnHeader();
        this.colFileName = new ColumnHeader();
        this.colFileCreated = new ColumnHeader();
        this.SuspendLayout();
        // 
        // btnArea
        // 
        this.btnArea.Location = new Point(414, 54);
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
        this.label1.Location = new Point(12, 341);
        this.label1.Name = "label1";
        this.label1.Size = new Size(111, 15);
        this.label1.TabIndex = 2;
        this.label1.Text = "Taken 0 screenshots";
        // 
        // btnWindow
        // 
        this.btnWindow.Location = new Point(414, 110);
        this.btnWindow.Name = "btnWindow";
        this.btnWindow.Size = new Size(110, 50);
        this.btnWindow.TabIndex = 3;
        this.btnWindow.Text = "Isolated Window";
        this.btnWindow.UseVisualStyleBackColor = true;
        this.btnWindow.Click += this.btnWindow_Click;
        // 
        // btnFullScreen
        // 
        this.btnFullScreen.Location = new Point(414, 166);
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
        this.btnExit.Location = new Point(414, 278);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new Size(110, 50);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += this.btnExit_Click;
        // 
        // btnRecord
        // 
        this.btnRecord.Location = new Point(414, 222);
        this.btnRecord.Name = "btnRecord";
        this.btnRecord.Size = new Size(110, 50);
        this.btnRecord.TabIndex = 7;
        this.btnRecord.Text = "Recording";
        this.btnRecord.UseVisualStyleBackColor = true;
        // 
        // btnGithub
        // 
        this.btnGithub.BackColor = Color.Transparent;
        this.btnGithub.BackgroundImageLayout = ImageLayout.Stretch;
        this.btnGithub.FlatAppearance.BorderSize = 0;
        this.btnGithub.FlatStyle = FlatStyle.Flat;
        this.btnGithub.Image = Properties.Resources.github;
        this.btnGithub.Location = new Point(494, 378);
        this.btnGithub.Name = "btnGithub";
        this.btnGithub.Size = new Size(30, 30);
        this.btnGithub.TabIndex = 8;
        this.btnGithub.UseVisualStyleBackColor = false;
        this.btnGithub.Click += this.btnGithub_Click;
        // 
        // btnHelp
        // 
        this.btnHelp.BackColor = Color.Transparent;
        this.btnHelp.FlatAppearance.BorderSize = 0;
        this.btnHelp.FlatStyle = FlatStyle.Flat;
        this.btnHelp.Image = Properties.Resources.question_circle;
        this.btnHelp.Location = new Point(448, 12);
        this.btnHelp.Name = "btnHelp";
        this.btnHelp.Size = new Size(35, 35);
        this.btnHelp.TabIndex = 9;
        this.btnHelp.UseVisualStyleBackColor = false;
        // 
        // btnSettings
        // 
        this.btnSettings.BackColor = Color.Transparent;
        this.btnSettings.FlatAppearance.BorderSize = 0;
        this.btnSettings.FlatStyle = FlatStyle.Flat;
        this.btnSettings.Image = Properties.Resources.gear;
        this.btnSettings.Location = new Point(489, 12);
        this.btnSettings.Name = "btnSettings";
        this.btnSettings.Size = new Size(35, 35);
        this.btnSettings.TabIndex = 10;
        this.btnSettings.UseVisualStyleBackColor = false;
        this.btnSettings.Click += this.btnSettings_Click;
        // 
        // lstvwScreenshotsHistory
        // 
        this.lstvwScreenshotsHistory.Columns.AddRange(new ColumnHeader[] { this.colFileIndex, this.colFileName, this.colFileCreated });
        this.lstvwScreenshotsHistory.Location = new Point(12, 54);
        this.lstvwScreenshotsHistory.Name = "lstvwScreenshotsHistory";
        this.lstvwScreenshotsHistory.Size = new Size(396, 274);
        this.lstvwScreenshotsHistory.TabIndex = 11;
        this.lstvwScreenshotsHistory.UseCompatibleStateImageBehavior = false;
        this.lstvwScreenshotsHistory.View = View.Details;
        // 
        // colFileIndex
        // 
        this.colFileIndex.Text = "Index";
        // 
        // colFileName
        // 
        this.colFileName.Text = "Screenshot";
        this.colFileName.Width = 200;
        // 
        // colFileCreated
        // 
        this.colFileCreated.Text = "Created";
        this.colFileCreated.Width = 140;
        // 
        // MainWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(536, 420);
        this.Controls.Add(this.lstvwScreenshotsHistory);
        this.Controls.Add(this.btnSettings);
        this.Controls.Add(this.btnHelp);
        this.Controls.Add(this.btnGithub);
        this.Controls.Add(this.btnRecord);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnFullScreen);
        this.Controls.Add(this.btnWindow);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.btnArea);
        this.Name = "MainWindow";
        this.Text = "Screenshot";
        Load += this.MainWindow_Load;
        Resize += this.MainWindow_Resize;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button btnArea;
    private Label label1;
    private Button btnWindow;
    private Button btnSettings;
    private ListView lstvwScreenshotsHistory;
    private Button btnFullScreen;
    private NotifyIcon trayIcon;
    private Button btnExit;
    private Button btnRecord;
    private Button btnGithub;
    private Button btnHelp;
    private ColumnHeader colFileIndex;
    private ColumnHeader colFileName;
    private ColumnHeader colFileCreated;
}
