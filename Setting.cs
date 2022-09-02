using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ReadTransulate
{
    public partial class Setting : Form
    {
        Form Main_Window;
        private static bool k1_cap = false;
        private static bool k2_cap = false;
        private static bool k3_cap = false;

        public Setting(Form main)
        {
            InitializeComponent();
            Main_Window = main;
        }

        private void checkBox_AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            Form1.AlwaysOnTop = checkBox_AlwaysOnTop.Checked;
            Config.SaveConfig();
        }

        private void Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main_Window.Show();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            fontDialog_1.ShowColor = true;
            fontDialog_1.ShowApply = true;
            fontDialog_1.ShowEffects = true;
            fontDialog_1.ShowHelp = true;

            string[] files = Directory.GetFiles(Config.transulation_path, "*.*");
            foreach (string file in files)
            {
                string f_n_e = file.Replace(Config.transulation_path + @"\", "");
                string f_n = f_n_e.Replace(".traineddata", "");
                comboBox_lang_file.Items.Add(f_n);
            }
            
            if (Form1.AlwaysOnTop) checkBox_AlwaysOnTop.Checked = true;
            if (Form1.CopyOnTake) copy_to_clip_take.Checked = true;
            comboBox_lang_file.SelectedIndex = comboBox_lang_file.FindStringExact(Form1.lang_file);
            comboBox_lang_file.SelectedText = Form1.lang_file;
            textBox_tran_from.Text = Form1.tran_from;
            textBox_tran_to.Text = Form1.tran_to;
            TakeShortcut.Text = Form1.take_key.ToString();
            ClearShortcut.Text = Form1.clear_key.ToString();
            CopyShortcut.Text = Form1.copy_key.ToString();
            FontButton.ForeColor = Color.FromName(Form1.color);
            FontButton.Text = "Font[" + Form1.font.FontFamily.Name.ToString() + "(" + Form1.font.Size.ToString() + "px)]";
        }

        private void comboBox_lang_file_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.lang_file = comboBox_lang_file.Text;
            Config.SaveConfig();
        }

        private void copy_to_clip_take_CheckedChanged(object sender, EventArgs e)
        {
            Form1.CopyOnTake = copy_to_clip_take.Checked;
            Config.SaveConfig();
        }

        private void textBox_tran_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form1.tran_from = textBox_tran_from.Text;
            Config.SaveConfig();
        }

        private void textBox_tran_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form1.tran_to = textBox_tran_to.Text;
            Config.SaveConfig();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog_1.ShowDialog() != DialogResult.Cancel)
            {
                Form1.font = fontDialog_1.Font;
                Form1.color = fontDialog_1.Color.Name.ToString();
                FontButton.ForeColor = Color.FromName(Form1.color);
                FontButton.Text = "Font[" + Form1.font.FontFamily.Name.ToString() + "(" + Form1.font.Size.ToString() + "px)]";
                Config.SaveConfig();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TakeShortcut.Text = "Click";
            k1_cap = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearShortcut.Text = "Click";
            k2_cap = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CopyShortcut.Text = "Click";
            k3_cap = true;
        }

        private void button4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k1_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Keys key))
                    if (!Enum.IsDefined(typeof(Keys), key)) return;
                Form1.take_key = key;
                TakeShortcut.Text = Form1.take_key.ToString();
                k1_cap = false;
                Config.SaveConfig();
            }
        }

        private void button5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k2_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Keys key))
                    if (!Enum.IsDefined(typeof(Keys), key)) return;
                Form1.clear_key = key;
                ClearShortcut.Text = Form1.clear_key.ToString();
                k2_cap = false;
                Config.SaveConfig();
            }
        }

        private void button6_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k3_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Keys key))
                    if (!Enum.IsDefined(typeof(Keys), key)) return;
                Form1.copy_key = key;
                CopyShortcut.Text = Form1.copy_key.ToString();
                k3_cap = false;
                Config.SaveConfig();
            }
        }
    }
}
