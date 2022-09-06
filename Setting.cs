using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Input;

namespace ReadTransulate
{
    public partial class Setting : Form
    {
        Form Main_Window;
        private static bool k1_cap = false;
        private static bool k2_cap = false;
        private static bool k3_cap = false;

        private static bool AlwaysOnTop = ReadTransulate.MainWindow.AlwaysOnTop;
        private static bool CopyOnTake = ReadTransulate.MainWindow.CopyOnTake;
        private static string lang_file = ReadTransulate.MainWindow.lang_file;
        private static Font font = ReadTransulate.MainWindow.font;
        private static string color = ReadTransulate.MainWindow.color;
        private static Key take_key = ReadTransulate.MainWindow.take_key;
        private static Key clear_key = ReadTransulate.MainWindow.clear_key;
        private static Key copy_key = ReadTransulate.MainWindow.copy_key;

        public Setting(Form main)
        {
            InitializeComponent();
            Main_Window = main;
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
            
            if (ReadTransulate.MainWindow.AlwaysOnTop) checkBox_AlwaysOnTop.Checked = true;
            if (ReadTransulate.MainWindow.CopyOnTake) copy_to_clip_take.Checked = true;
            comboBox_lang_file.SelectedIndex = comboBox_lang_file.FindStringExact(ReadTransulate.MainWindow.lang_file);
            comboBox_lang_file.SelectedText = ReadTransulate.MainWindow.lang_file;
            textBox_tran_from.Text = ReadTransulate.MainWindow.tran_from;
            textBox_tran_to.Text = ReadTransulate.MainWindow.tran_to;
            TakeShortcut.Text = ReadTransulate.MainWindow.take_key.ToString();
            ClearShortcut.Text = ReadTransulate.MainWindow.clear_key.ToString();
            CopyShortcut.Text = ReadTransulate.MainWindow.copy_key.ToString();
            FontButton.ForeColor = Color.FromName(ReadTransulate.MainWindow.color);
            FontButton.Text = "Font[" + ReadTransulate.MainWindow.font.FontFamily.Name.ToString() + "(" + ReadTransulate.MainWindow.font.Size.ToString() + "px)]";
        }


        private void checkBox_AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            AlwaysOnTop = checkBox_AlwaysOnTop.Checked;
        }

        private void comboBox_lang_file_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang_file = comboBox_lang_file.Text;
        }

        private void copy_to_clip_take_CheckedChanged(object sender, EventArgs e)
        {
            CopyOnTake = copy_to_clip_take.Checked;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog_1.ShowDialog() != DialogResult.Cancel)
            {
                font = fontDialog_1.Font;
                color = fontDialog_1.Color.Name.ToString();
                FontButton.ForeColor = Color.FromName(color);
                FontButton.Text = "Font[" + font.FontFamily.Name.ToString() + "(" + font.Size.ToString() + "px)]";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(TakeShortcut.Text != "None")
            {
                TakeShortcut.Text = "None";
                take_key = Key.None;
            }
            else
            {
                TakeShortcut.Text = "Click";
                k1_cap = true;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ClearShortcut.Text != "None")
            {
                ClearShortcut.Text = "None";
                clear_key = Key.None;
            }
            else
            {
                ClearShortcut.Text = "Click";
                k2_cap = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CopyShortcut.Text != "None")
            {
                CopyShortcut.Text = "None";
                copy_key = Key.None;
            }
            else
            {
                CopyShortcut.Text = "Click";
                k3_cap = true;
            }
        }

        private void button4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k1_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Key key))
                    if (!Enum.IsDefined(typeof(Key), key)) return;
                take_key = key;
                TakeShortcut.Text = take_key.ToString();
                k1_cap = false;
            }
        }

        private void button5_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k2_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Key key))
                    if (!Enum.IsDefined(typeof(Key), key)) return;
                clear_key = key;
                ClearShortcut.Text = clear_key.ToString();
                k2_cap = false;
            }
        }

        private void button6_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (k3_cap)
            {
                if (Enum.TryParse(e.KeyCode.ToString(), out Key key))
                    if (!Enum.IsDefined(typeof(Key), key)) return;
                copy_key = key;
                CopyShortcut.Text = copy_key.ToString();
                k3_cap = false;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ReadTransulate.MainWindow.AlwaysOnTop = AlwaysOnTop;
            ReadTransulate.MainWindow.CopyOnTake = CopyOnTake;
            ReadTransulate.MainWindow.lang_file = lang_file;
            ReadTransulate.MainWindow.tran_from = textBox_tran_from.Text;
            ReadTransulate.MainWindow.tran_to = textBox_tran_to.Text;
            ReadTransulate.MainWindow.font = font;
            ReadTransulate.MainWindow.color = color;
            ReadTransulate.MainWindow.take_key = take_key;
            ReadTransulate.MainWindow.clear_key = clear_key;
            ReadTransulate.MainWindow.copy_key = copy_key;
            Config.SaveConfig();

            
            Main_Window.Show();
            this.Close();
        }
    }
}
