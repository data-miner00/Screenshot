namespace Screenshot.App;

partial class PreviewForm
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
        this.pbxPreview = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)this.pbxPreview).BeginInit();
        this.SuspendLayout();
        // 
        // pbxPreview
        // 
        this.pbxPreview.Location = new Point(12, 12);
        this.pbxPreview.Name = "pbxPreview";
        this.pbxPreview.Size = new Size(776, 426);
        this.pbxPreview.TabIndex = 0;
        this.pbxPreview.TabStop = false;
        // 
        // PreviewForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.pbxPreview);
        this.Name = "PreviewForm";
        this.Text = "PreviewForm";
        ((System.ComponentModel.ISupportInitialize)this.pbxPreview).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private PictureBox pbxPreview;
}