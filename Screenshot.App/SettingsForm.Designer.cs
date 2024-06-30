namespace Screenshot.App;

partial class SettingsForm
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
        this.textBox1 = new TextBox();
        this.groupBox1 = new GroupBox();
        this.label2 = new Label();
        this.comboBox1 = new ComboBox();
        this.cbxOverwriteIfExist = new CheckBox();
        this.cbxSaveAs = new CheckBox();
        this.cbxAutosave = new CheckBox();
        this.btnSaveSettings = new Button();
        this.groupBox1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new Size(101, 15);
        this.label1.TabIndex = 0;
        this.label1.Text = "Screenshot Folder";
        // 
        // textBox1
        // 
        this.textBox1.Location = new Point(12, 38);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new Size(242, 23);
        this.textBox1.TabIndex = 1;
        // 
        // groupBox1
        // 
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Controls.Add(this.comboBox1);
        this.groupBox1.Controls.Add(this.cbxOverwriteIfExist);
        this.groupBox1.Controls.Add(this.cbxSaveAs);
        this.groupBox1.Controls.Add(this.cbxAutosave);
        this.groupBox1.Location = new Point(12, 87);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new Size(242, 178);
        this.groupBox1.TabIndex = 6;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Persistence";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new Point(15, 110);
        this.label2.Name = "label2";
        this.label2.Size = new Size(114, 15);
        this.label2.TabIndex = 12;
        this.label2.Text = "File naming strategy";
        // 
        // comboBox1
        // 
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new Point(15, 130);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new Size(199, 23);
        this.comboBox1.TabIndex = 11;
        // 
        // cbxOverwriteIfExist
        // 
        this.cbxOverwriteIfExist.AutoSize = true;
        this.cbxOverwriteIfExist.Location = new Point(15, 72);
        this.cbxOverwriteIfExist.Name = "cbxOverwriteIfExist";
        this.cbxOverwriteIfExist.Size = new Size(114, 19);
        this.cbxOverwriteIfExist.TabIndex = 10;
        this.cbxOverwriteIfExist.Text = "Overwrite if exist";
        this.cbxOverwriteIfExist.UseVisualStyleBackColor = true;
        // 
        // cbxSaveAs
        // 
        this.cbxSaveAs.AutoSize = true;
        this.cbxSaveAs.Location = new Point(15, 47);
        this.cbxSaveAs.Name = "cbxSaveAs";
        this.cbxSaveAs.Size = new Size(64, 19);
        this.cbxSaveAs.TabIndex = 9;
        this.cbxSaveAs.Text = "Save as";
        this.cbxSaveAs.UseVisualStyleBackColor = true;
        // 
        // cbxAutosave
        // 
        this.cbxAutosave.AutoSize = true;
        this.cbxAutosave.Location = new Point(15, 22);
        this.cbxAutosave.Name = "cbxAutosave";
        this.cbxAutosave.Size = new Size(75, 19);
        this.cbxAutosave.TabIndex = 8;
        this.cbxAutosave.Text = "Autosave";
        this.cbxAutosave.UseVisualStyleBackColor = true;
        // 
        // btnSaveSettings
        // 
        this.btnSaveSettings.Location = new Point(12, 271);
        this.btnSaveSettings.Name = "btnSaveSettings";
        this.btnSaveSettings.Size = new Size(242, 23);
        this.btnSaveSettings.TabIndex = 7;
        this.btnSaveSettings.Text = "Save";
        this.btnSaveSettings.UseVisualStyleBackColor = true;
        // 
        // Settings
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(277, 310);
        this.Controls.Add(this.btnSaveSettings);
        this.Controls.Add(this.groupBox1);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.label1);
        this.Name = "Settings";
        this.Text = "Settings";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label label3;
    private Label label4;
    private GroupBox groupBox1;
    private CheckBox cbxAutosave;
    private CheckBox cbxSaveAs;
    private CheckBox cbxOverwriteIfExist;
    private Label label2;
    private ComboBox comboBox1;
    private Button btnSaveSettings;
}