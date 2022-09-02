
namespace ReadTransulate
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.comboBox_lang_file = new System.Windows.Forms.ComboBox();
            this.checkBox_AlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.copy_to_clip_take = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TakeShortcut = new System.Windows.Forms.Button();
            this.ClearShortcut = new System.Windows.Forms.Button();
            this.CopyShortcut = new System.Windows.Forms.Button();
            this.textBox_tran_from = new System.Windows.Forms.TextBox();
            this.textBox_tran_to = new System.Windows.Forms.TextBox();
            this.fontDialog_1 = new System.Windows.Forms.FontDialog();
            this.FontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_lang_file
            // 
            this.comboBox_lang_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_lang_file.FormattingEnabled = true;
            this.comboBox_lang_file.Location = new System.Drawing.Point(212, 87);
            this.comboBox_lang_file.Name = "comboBox_lang_file";
            this.comboBox_lang_file.Size = new System.Drawing.Size(110, 23);
            this.comboBox_lang_file.TabIndex = 9;
            this.comboBox_lang_file.SelectedIndexChanged += new System.EventHandler(this.comboBox_lang_file_SelectedIndexChanged);
            // 
            // checkBox_AlwaysOnTop
            // 
            this.checkBox_AlwaysOnTop.AutoSize = true;
            this.checkBox_AlwaysOnTop.Location = new System.Drawing.Point(97, 21);
            this.checkBox_AlwaysOnTop.Name = "checkBox_AlwaysOnTop";
            this.checkBox_AlwaysOnTop.Size = new System.Drawing.Size(125, 19);
            this.checkBox_AlwaysOnTop.TabIndex = 8;
            this.checkBox_AlwaysOnTop.Text = "Always On Top";
            this.checkBox_AlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBox_AlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox_AlwaysOnTop_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Language File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Shortcut Take";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Shortcut Clear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Shortcut Copy";
            // 
            // copy_to_clip_take
            // 
            this.copy_to_clip_take.AutoSize = true;
            this.copy_to_clip_take.Location = new System.Drawing.Point(97, 46);
            this.copy_to_clip_take.Name = "copy_to_clip_take";
            this.copy_to_clip_take.Size = new System.Drawing.Size(189, 19);
            this.copy_to_clip_take.TabIndex = 8;
            this.copy_to_clip_take.Text = "Copy to clipbord on Take";
            this.copy_to_clip_take.UseVisualStyleBackColor = true;
            this.copy_to_clip_take.CheckedChanged += new System.EventHandler(this.copy_to_clip_take_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Transulate From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Transulate To";
            // 
            // TakeShortcut
            // 
            this.TakeShortcut.Location = new System.Drawing.Point(225, 182);
            this.TakeShortcut.Name = "TakeShortcut";
            this.TakeShortcut.Size = new System.Drawing.Size(75, 30);
            this.TakeShortcut.TabIndex = 20;
            this.TakeShortcut.Text = "+";
            this.TakeShortcut.UseVisualStyleBackColor = true;
            this.TakeShortcut.Click += new System.EventHandler(this.button4_Click);
            this.TakeShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button4_KeyDown);
            // 
            // ClearShortcut
            // 
            this.ClearShortcut.Location = new System.Drawing.Point(225, 218);
            this.ClearShortcut.Name = "ClearShortcut";
            this.ClearShortcut.Size = new System.Drawing.Size(75, 30);
            this.ClearShortcut.TabIndex = 21;
            this.ClearShortcut.Text = "+";
            this.ClearShortcut.UseVisualStyleBackColor = true;
            this.ClearShortcut.Click += new System.EventHandler(this.button5_Click);
            this.ClearShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button5_KeyDown);
            // 
            // CopyShortcut
            // 
            this.CopyShortcut.Location = new System.Drawing.Point(225, 254);
            this.CopyShortcut.Name = "CopyShortcut";
            this.CopyShortcut.Size = new System.Drawing.Size(75, 30);
            this.CopyShortcut.TabIndex = 22;
            this.CopyShortcut.Text = "+";
            this.CopyShortcut.UseVisualStyleBackColor = true;
            this.CopyShortcut.Click += new System.EventHandler(this.button6_Click);
            this.CopyShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button6_KeyDown);
            // 
            // textBox_tran_from
            // 
            this.textBox_tran_from.Location = new System.Drawing.Point(215, 116);
            this.textBox_tran_from.Name = "textBox_tran_from";
            this.textBox_tran_from.Size = new System.Drawing.Size(100, 22);
            this.textBox_tran_from.TabIndex = 23;
            this.textBox_tran_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tran_from_KeyPress);
            // 
            // textBox_tran_to
            // 
            this.textBox_tran_to.Location = new System.Drawing.Point(215, 144);
            this.textBox_tran_to.Name = "textBox_tran_to";
            this.textBox_tran_to.Size = new System.Drawing.Size(100, 22);
            this.textBox_tran_to.TabIndex = 23;
            this.textBox_tran_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tran_to_KeyPress);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(97, 290);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(225, 35);
            this.FontButton.TabIndex = 26;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 431);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.textBox_tran_to);
            this.Controls.Add(this.textBox_tran_from);
            this.Controls.Add(this.CopyShortcut);
            this.Controls.Add(this.ClearShortcut);
            this.Controls.Add(this.TakeShortcut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_lang_file);
            this.Controls.Add(this.copy_to_clip_take);
            this.Controls.Add(this.checkBox_AlwaysOnTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_FormClosing);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_lang_file;
        private System.Windows.Forms.CheckBox checkBox_AlwaysOnTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox copy_to_clip_take;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button TakeShortcut;
        private System.Windows.Forms.Button ClearShortcut;
        private System.Windows.Forms.Button CopyShortcut;
        private System.Windows.Forms.TextBox textBox_tran_from;
        private System.Windows.Forms.TextBox textBox_tran_to;
        private System.Windows.Forms.FontDialog fontDialog_1;
        private System.Windows.Forms.Button FontButton;
    }
}