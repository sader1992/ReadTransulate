
namespace ReadTransulate
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label_result = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.take_button = new System.Windows.Forms.Button();
            this.Setting_Button = new System.Windows.Forms.Button();
            this.MainWindow_Hidden_timer = new System.Windows.Forms.Timer(this.components);
            this.TranTimer = new System.Windows.Forms.Timer(this.components);
            this.ClearTimer = new System.Windows.Forms.Timer(this.components);
            this.CopyTimer = new System.Windows.Forms.Timer(this.components);
            this.Exit_Button = new System.Windows.Forms.Button();
            this.checkBox_HotKeys = new System.Windows.Forms.CheckBox();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_result
            // 
            this.label_result.AutoEllipsis = true;
            this.label_result.AutoSize = true;
            this.label_result.BackColor = System.Drawing.Color.Transparent;
            this.label_result.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_result.Location = new System.Drawing.Point(25, 19);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(0, 40);
            this.label_result.TabIndex = 1;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.clear_button.Location = new System.Drawing.Point(776, 269);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(28, 23);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "-";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // take_button
            // 
            this.take_button.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.take_button.Location = new System.Drawing.Point(810, 269);
            this.take_button.Name = "take_button";
            this.take_button.Size = new System.Drawing.Size(26, 23);
            this.take_button.TabIndex = 0;
            this.take_button.Text = "+";
            this.take_button.UseVisualStyleBackColor = true;
            this.take_button.Click += new System.EventHandler(this.take_button_Click);
            // 
            // Setting_Button
            // 
            this.Setting_Button.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.Setting_Button.Location = new System.Drawing.Point(776, 222);
            this.Setting_Button.Name = "Setting_Button";
            this.Setting_Button.Size = new System.Drawing.Size(75, 23);
            this.Setting_Button.TabIndex = 6;
            this.Setting_Button.Text = "S";
            this.Setting_Button.UseVisualStyleBackColor = true;
            this.Setting_Button.Click += new System.EventHandler(this.Setting_Button_Click);
            // 
            // MainWindow_Hidden_timer
            // 
            this.MainWindow_Hidden_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TranTimer
            // 
            this.TranTimer.Enabled = true;
            this.TranTimer.Interval = 50;
            this.TranTimer.Tick += new System.EventHandler(this.TranTimer_Tick);
            // 
            // ClearTimer
            // 
            this.ClearTimer.Enabled = true;
            this.ClearTimer.Interval = 50;
            this.ClearTimer.Tick += new System.EventHandler(this.ClearTimer_Tick);
            // 
            // CopyTimer
            // 
            this.CopyTimer.Enabled = true;
            this.CopyTimer.Interval = 50;
            this.CopyTimer.Tick += new System.EventHandler(this.CopyTimer_Tick);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(553, 155);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 40);
            this.Exit_Button.TabIndex = 7;
            this.Exit_Button.Text = "x";
            this.Exit_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // checkBox_HotKeys
            // 
            this.checkBox_HotKeys.AutoSize = true;
            this.checkBox_HotKeys.Location = new System.Drawing.Point(416, 155);
            this.checkBox_HotKeys.Name = "checkBox_HotKeys";
            this.checkBox_HotKeys.Size = new System.Drawing.Size(18, 17);
            this.checkBox_HotKeys.TabIndex = 8;
            this.checkBox_HotKeys.UseVisualStyleBackColor = true;
            this.checkBox_HotKeys.CheckedChanged += new System.EventHandler(this.checkBox_HotKeys_CheckedChanged);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_Button.Location = new System.Drawing.Point(730, 119);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(38, 24);
            this.Minimize_Button.TabIndex = 9;
            this.Minimize_Button.Text = "ー";
            this.Minimize_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 319);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.checkBox_HotKeys);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Setting_Button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.take_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button take_button;
        private System.Windows.Forms.Button Setting_Button;
        private System.Windows.Forms.Timer MainWindow_Hidden_timer;
        private System.Windows.Forms.Timer TranTimer;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Timer ClearTimer;
        private System.Windows.Forms.Timer CopyTimer;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.CheckBox checkBox_HotKeys;
        private System.Windows.Forms.Button Minimize_Button;
    }
}

