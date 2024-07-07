namespace Screenshot.App.Views;

partial class SelectArea
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
        this.panelDrag = new Panel();
        this.SuspendLayout();
        // 
        // panelDrag
        // 
        this.panelDrag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        this.panelDrag.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        this.panelDrag.Cursor = Cursors.SizeAll;
        this.panelDrag.Location = new Point(12, 12);
        this.panelDrag.Name = "panelDrag";
        this.panelDrag.Size = new Size(349, 232);
        this.panelDrag.TabIndex = 0;
        this.panelDrag.MouseDown += this.panelDrag_MouseDown;
        // 
        // SelectArea
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(373, 256);
        this.Controls.Add(this.panelDrag);
        this.Name = "SelectArea";
        this.Text = "SelectArea";
        Load += this.SelectArea_Load;
        KeyPress += this.SelectArea_KeyPress;
        this.ResumeLayout(false);
    }

    #endregion

    private Panel panelDrag;
}
