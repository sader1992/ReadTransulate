using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace ReadTransulate
{
    internal class Config
    {
        public static List<Keys> Key_list = new List<Keys>();
        private static string application_path = Application.ExecutablePath.ToString();
        public static string path = Path.GetDirectoryName(application_path);
        private static string setting = Application.ProductName.ToString() + ".ini";
        private static string setting_path = path + @"\" + setting;
        public static string transulation_path = path + @"\traineddata";

        public static bool readConfig()
        {
            if (!File.Exists(setting_path))
            {
                string[] Default_Config =
                {
                    "always_on_top:false",
                    "copy_on_take:false",
                    "lang_file:jpn",
                    "lang:jp",
                    "transulate:en",
                    "take_key:none",
                    "clear_key:none",
                    "copy_key:none",
                    "font:Arial-12",
                    "font_color:red"

                };
                File.WriteAllText(setting_path, string.Join(Environment.NewLine, Default_Config.Select(i => i.ToString()).ToArray()));
            }
            Key_list.Clear();
            string[] Config = File.ReadAllLines(setting_path);
            foreach (string line in Config)
            {
                if (line.StartsWith("#")) continue;
                string c = "";
                if (line.StartsWith("always_on_top"))
                {
                    c = StringConfig(line, "always_on_top");
                    Form1.AlwaysOnTop = false;
                    if (c.Contains("true")) Form1.AlwaysOnTop = true;
                    continue;
                }

                if (line.StartsWith("copy_on_take"))
                {
                    c = StringConfig(line, "copy_on_take");
                    Form1.CopyOnTake = false;
                    if (c.Contains("true")) Form1.CopyOnTake = true;
                    continue;
                }

                if (line.StartsWith("lang_file"))
                {
                    c = StringConfig(line, "lang_file");
                    Form1.lang_file = c;
                    continue;
                }
                if (line.StartsWith("lang"))
                {
                    c = StringConfig(line, "lang");
                    Form1.tran_from = c;
                    continue;
                }
                if (line.StartsWith("font:"))
                {
                    c = StringConfig(line, "font");
                    string[] x = c.Split(new[] { "-" }, StringSplitOptions.None);
                    Font f = new Font(x[0], (float)Convert.ToDouble(x[1]));
                    Form1.font = f;
                    continue;
                }
                if (line.StartsWith("font_color"))
                {
                    c = StringConfig(line, "font_color");
                    Form1.color = c;
                    continue;
                }
                if (line.StartsWith("transulate"))
                {
                    c = StringConfig(line, "transulate");
                    Form1.tran_to = c;
                    continue;
                }

                if (line.StartsWith("take_key"))
                {
                    c = StringConfig(line, "take_key").ToUpper();
                    if (Enum.TryParse(c, out Keys k1))
                    {
                        if (!Enum.IsDefined(typeof(Keys), k1)) continue;
                        Form1.take_key = k1;
                        Key_list.Add(k1);

                    }
                    continue;
                }
                if (line.StartsWith("clear_key"))
                {
                    c = StringConfig(line, "clear_key").ToUpper();
                    if (Enum.TryParse(c, out Keys k1))
                    {
                        if (!Enum.IsDefined(typeof(Keys), k1)) continue;
                        Form1.clear_key = k1;
                        Key_list.Add(k1);
                    }
                    continue;
                }
                if (line.StartsWith("copy_key"))
                {
                    c = StringConfig(line, "copy_key").ToUpper();
                    if (Enum.TryParse(c, out Keys k1))
                    {
                        if (!Enum.IsDefined(typeof(Keys), k1)) continue;
                        Form1.copy_key = k1;
                        Key_list.Add(k1);
                    }
                    continue;
                }


            }
            return true;
        }

        public static bool SaveConfig()
        {
            File.Delete(setting_path);
            string[] Default_Config =
                {
                    "always_on_top:" + (Form1.AlwaysOnTop?"true":"false"),
                    "copy_on_take:" + (Form1.CopyOnTake?"true":"false"),
                    "lang_file:" + Form1.lang_file,
                    "lang:" + Form1.tran_from,
                    "transulate:" + Form1.tran_to,
                    "take_key:" + Form1.take_key.ToString(),
                    "clear_key:" + Form1.clear_key.ToString(),
                    "copy_key:" + Form1.copy_key.ToString(),
                    "font:" + Form1.font.Name.ToString() + "-" + Form1.font.Size.ToString(),
                    "font_color:" + Form1.color.ToString(),

                };
            File.WriteAllText(setting_path, string.Join(Environment.NewLine, Default_Config.Select(i => i.ToString()).ToArray()));
            readConfig();
            return true;
        }

        private static string StringConfig(string line, string config)
        {
            string s = line.Replace(config + ":", "").ToLower();
            return s;
        }

    }
}
