namespace Screenshot.App.Views;

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
        this.btnSaveAs = new Button();
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
        // btnSaveAs
        // 
        this.btnSaveAs.Location = new Point(12, 453);
        this.btnSaveAs.Name = "btnSaveAs";
        this.btnSaveAs.Size = new Size(776, 27);
        this.btnSaveAs.TabIndex = 1;
        this.btnSaveAs.Text = "Save As";
        this.btnSaveAs.UseVisualStyleBackColor = true;
        this.btnSaveAs.Click += this.btnSaveAs_Click;
        // 
        // PreviewForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 492);
        this.Controls.Add(this.btnSaveAs);
        this.Controls.Add(this.pbxPreview);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Name = "PreviewForm";
        this.Text = "PreviewForm";
        ((System.ComponentModel.ISupportInitialize)this.pbxPreview).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private PictureBox pbxPreview;
    private Button btnSaveAs;
}
