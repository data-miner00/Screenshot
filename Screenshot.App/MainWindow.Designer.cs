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
            btnArea = new Button();
            label1 = new Label();
            btnWindow = new Button();
            btnSettings = new Button();
            SuspendLayout();
            // 
            // btnArea
            // 
            btnArea.Location = new Point(22, 48);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(110, 50);
            btnArea.TabIndex = 0;
            btnArea.Text = "Specific Area";
            btnArea.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 18);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 2;
            label1.Text = "Take useful screenshots";
            label1.Click += label1_Click;
            // 
            // btnWindow
            // 
            btnWindow.Location = new Point(22, 104);
            btnWindow.Name = "btnWindow";
            btnWindow.Size = new Size(110, 50);
            btnWindow.TabIndex = 3;
            btnWindow.Text = "Isolated Window";
            btnWindow.UseVisualStyleBackColor = true;
            btnWindow.Click += btnWindow_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(22, 160);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(110, 50);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 244);
            Controls.Add(btnSettings);
            Controls.Add(btnWindow);
            Controls.Add(label1);
            Controls.Add(btnArea);
            Name = "MainWindow";
            Text = "Screenshot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArea;
        private Label label1;
        private Button btnWindow;
        private Button btnSettings;
    }
}
