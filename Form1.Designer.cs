namespace BetterSeliwareLauncher
{
    partial class SeliwareLauncher
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(206, 142);
            button2.Name = "button2";
            button2.Size = new Size(87, 44);
            button2.TabIndex = 1;
            button2.Text = "Synapse X 2019 UI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(206, 5);
            button3.Name = "button3";
            button3.Size = new Size(87, 40);
            button3.TabIndex = 2;
            button3.Text = "Electron UI";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(2, 142);
            button4.Name = "button4";
            button4.Size = new Size(87, 42);
            button4.TabIndex = 3;
            button4.Text = "Seliware Loader";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Location = new Point(2, 3);
            button7.Name = "button7";
            button7.Size = new Size(87, 42);
            button7.TabIndex = 6;
            button7.Text = "Launch Roblox";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(360, 3);
            button6.Name = "button6";
            button6.Size = new Size(93, 26);
            button6.TabIndex = 7;
            button6.Text = "Multi-Instance";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(416, 156);
            button5.Name = "button5";
            button5.Size = new Size(88, 28);
            button5.TabIndex = 8;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // SeliwareLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.Seliware;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(507, 187);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SeliwareLauncher";
            Text = "SeliwareLaucher(Custom made by Bloom )";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Button button5;
        private Button button6;
    }
}
