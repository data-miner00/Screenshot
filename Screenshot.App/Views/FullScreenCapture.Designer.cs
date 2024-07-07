namespace Screenshot.App.Views;

partial class FullScreenCapture
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
        this.btnCapture = new Button();
        this.cbxSelectScreen = new ComboBox();
        this.tbxDelay = new TextBox();
        this.lblDelay = new Label();
        this.lblSelectScreen = new Label();
        this.SuspendLayout();
        // 
        // btnCapture
        // 
        this.btnCapture.Location = new Point(12, 104);
        this.btnCapture.Name = "btnCapture";
        this.btnCapture.Size = new Size(315, 27);
        this.btnCapture.TabIndex = 0;
        this.btnCapture.Text = "Capture";
        this.btnCapture.UseVisualStyleBackColor = true;
        this.btnCapture.Click += this.btnCapture_Click;
        // 
        // cbxSelectScreen
        // 
        this.cbxSelectScreen.FormattingEnabled = true;
        this.cbxSelectScreen.Location = new Point(12, 27);
        this.cbxSelectScreen.Name = "cbxSelectScreen";
        this.cbxSelectScreen.Size = new Size(315, 23);
        this.cbxSelectScreen.TabIndex = 1;
        // 
        // tbxDelay
        // 
        this.tbxDelay.Location = new Point(12, 75);
        this.tbxDelay.Name = "tbxDelay";
        this.tbxDelay.Size = new Size(315, 23);
        this.tbxDelay.TabIndex = 2;
        // 
        // lblDelay
        // 
        this.lblDelay.AutoSize = true;
        this.lblDelay.Location = new Point(12, 57);
        this.lblDelay.Name = "lblDelay";
        this.lblDelay.Size = new Size(36, 15);
        this.lblDelay.TabIndex = 3;
        this.lblDelay.Text = "Delay";
        // 
        // lblSelectScreen
        // 
        this.lblSelectScreen.AutoSize = true;
        this.lblSelectScreen.Location = new Point(12, 9);
        this.lblSelectScreen.Name = "lblSelectScreen";
        this.lblSelectScreen.Size = new Size(75, 15);
        this.lblSelectScreen.TabIndex = 4;
        this.lblSelectScreen.Text = "Select screen";
        // 
        // FullScreenCapture
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(339, 141);
        this.Controls.Add(this.lblSelectScreen);
        this.Controls.Add(this.lblDelay);
        this.Controls.Add(this.tbxDelay);
        this.Controls.Add(this.cbxSelectScreen);
        this.Controls.Add(this.btnCapture);
        this.Name = "FullScreenCapture";
        this.Text = "FullScreenCapture";
        Load += this.FullScreenCapture_Load;
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Button btnCapture;
    private ComboBox cbxSelectScreen;
    private TextBox tbxDelay;
    private Label lblDelay;
    private Label lblSelectScreen;
}
