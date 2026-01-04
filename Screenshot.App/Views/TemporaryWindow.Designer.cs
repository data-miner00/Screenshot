namespace Screenshot.App.Views;

partial class TemporaryWindow
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
        this.canvas1 = new Canvas();
        this.SuspendLayout();
        // 
        // canvas1
        // 
        this.canvas1.Location = new Point(12, 12);
        this.canvas1.Name = "canvas1";
        this.canvas1.Size = new Size(776, 426);
        this.canvas1.TabIndex = 0;
        // 
        // TemporaryWindow
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.canvas1);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "TemporaryWindow";
        this.Text = "TemporaryWindow";
        this.ResumeLayout(false);
    }

    #endregion

    private Canvas canvas1;
}