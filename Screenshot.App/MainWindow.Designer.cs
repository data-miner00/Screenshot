namespace Screenshot.App
{
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
            this.btnArea = new Button();
            this.label1 = new Label();
            this.btnWindow = new Button();
            this.btnSettings = new Button();
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
            this.label1.Location = new Point(95, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(130, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Take useful screenshots";
            this.label1.Click += this.label1_Click;
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(319, 244);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnWindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnArea);
            this.Name = "MainWindow";
            this.Text = "Screenshot";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button btnArea;
        private Label label1;
        private Button btnWindow;
        private Button btnSettings;
    }
}
