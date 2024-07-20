namespace Screenshot.App;

partial class Canvas
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // Canvas
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.Name = "Canvas";
        Paint += this.Canvas_Paint;
        MouseClick += this.Canvas_MouseClick;
        MouseDown += this.Canvas_MouseDown;
        MouseMove += this.Canvas_MouseMove;
        MouseUp += this.Canvas_MouseUp;
        this.ResumeLayout(false);
    }

    #endregion
}
