using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Tesseract;
using System.Windows.Input;

namespace ReadTransulate
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
		//static readonly IntPtr HWND_TOP = new IntPtr(0);
		//static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
		const UInt32 SWP_NOSIZE = 0x0001;
		const UInt32 SWP_NOMOVE = 0x0002;
		const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		public static bool AlwaysOnTop = false;
        public static bool CopyOnTake = false;
        public static string tran_from = "ja";
        public static string lang_file = "jpn";
        public static string tran_to = "en";
        public static Font font = new Font("Arial", 12F);
        public static string color = Color.Black.ToString();
        public static Key take_key;
        public static Key clear_key;
        public static Key copy_key;
        public static bool KotkeyActivated = false;


        private const int cGrip = 16;
        private const int cCaption = 32;
		public Image bitmap_old;

        public static bool Start_tran = false;
        public static bool Start_clear = false;
        public static bool Start_copy = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(71, 50, 60);
            this.TransparencyKey = this.BackColor;


			take_button.BringToFront();
			label_result.BackColor = Color.Transparent;
			label_result.Font = font;
            label_result.ForeColor = Color.FromName(color);

            take_button.Height = 20;
			take_button.Width = 20;

			clear_button.Height = 20;
			clear_button.Width = 20;

            Setting_Button.Height = 20;
            Setting_Button.Width = 20;

            checkBox_HotKeys.Height = 20;
            checkBox_HotKeys.Width = 20;

            Exit_Button.Height = 25;
            Exit_Button.Width = 25;
            Minimize_Button.Height = 25;
            Minimize_Button.Width = 25;
            checkBox_HotKeys.Checked = true;


            Config.readConfig();
        }

        private async void take_button_Click(object sender, EventArgs e)
		{
			await TakeTran(true, CopyOnTake);
		}

		public async Task TakeTran(bool tran, bool copy = false)
		{
            if (this.WindowState == FormWindowState.Minimized) return;
			string path = AppDomain.CurrentDomain.BaseDirectory;
			label_result.Text = "";
			this.BackColor = Color.FromArgb(71, 50, 60);
			this.TransparencyKey = this.BackColor;
			clear_button.Hide();
			take_button.Hide();
            Setting_Button.Hide();
            Exit_Button.Hide();
            Minimize_Button.Hide();
            checkBox_HotKeys.Hide();
            await Task.Delay(1);
			Rectangle bounds = this.DesktopBounds;

			using (Image bitmap = new Bitmap(this.Size.Width, this.Size.Height))
			{
				using (Graphics g = Graphics.FromImage(bitmap))
				{
					g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                    
                }
				string original_text = GetText((Bitmap)bitmap, copy);
				string translated = "";

                if (tran)
				{
                    translated = Translate_Text(original_text);
                    this.TransparencyKey = Control.DefaultBackColor;
                    this.BackColor = Color.White;
                }
                label_result.Text = "";
                
                label_result.Text = translated;
                this.DoubleBuffered = true;
                this.SetStyle(ControlStyles.ResizeRedraw, true);
                bitmap_old = bitmap;
                //bitmap.Save(Config.path + @"\" + Application.ProductName.ToString() + ".jpg");
            }
			clear_button.Show();
			take_button.Show();
            Setting_Button.Show();
            Exit_Button.Show();
            Minimize_Button.Show();
            checkBox_HotKeys.Show();
        }

		private string Translate_Text(string original_text)
        {
            string translated_text = string.Empty;
            int trycount = 0;

            bool success;
            do
            {
                try
                {
                    success = GTranslateService.Translate(original_text, tran_from, tran_to, out translated_text);
                }
                catch (Exception)
                {
                    success = false;
                }
                trycount++;
            } while (success == false && trycount <= 2);
            return translated_text;
        }

        public static string GetText(Bitmap imgsource,bool copy = false)
		{
			var ocrtext = string.Empty;
			using (var engine = new TesseractEngine(@"./traineddata", lang_file, EngineMode.Default))
			{
				using (var img = PixConverter.ToPix(imgsource))
				{
					using (var page = engine.Process(img))
					{
						ocrtext = page.GetText();
					}
				}
			}
			if(copy) System.Windows.Forms.Clipboard.SetText(ocrtext);

            return ocrtext;
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);

			Pen redPen = new Pen(Color.Red, 10);
			e.Graphics.DrawRectangle(redPen, 5, 5, this.Width - 10, this.Height - 10);

			Pen blackPen = new Pen(Color.FromArgb(255, 0, 0, 0), 10);
            e.Graphics.DrawRectangle(blackPen, 0, 0, this.Width, this.Height);

            Exit_Button.Top = 20;
            Exit_Button.Left = this.Width - 50;
            Minimize_Button.Top = 20;
            Minimize_Button.Left = this.Width - 80;

            checkBox_HotKeys.Top = this.Height - 130;
            checkBox_HotKeys.Left = this.Width - 40;

            Setting_Button.Top = this.Height - 100;
            Setting_Button.Left = this.Width - 40;

            clear_button.Top = this.Height - 70;
			clear_button.Left = this.Width - 40;

			take_button.Top = this.Height - 40;
			take_button.Left = this.Width - 40;

			label_result.Top = 20;
			label_result.Left = 20;
			label_result.MaximumSize = new System.Drawing.Size(Width-50, 0);
		}

		protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < cCaption)
                    {
                        m.Result = (IntPtr)2;
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                    {
                        m.Result = (IntPtr)17;
                        return;
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
			label_result.Text = "";
			this.BackColor = Color.FromArgb(71, 50, 60);
			this.TransparencyKey = this.BackColor;
		}

        public void AlwaysOnTop_F()
		{
            if (AlwaysOnTop == true)
            {
                SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else
            {
                SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
        }

		private void Setting_Button_Click(object sender, EventArgs e)
		{
			Form s = new Setting(this);
            MainWindow_Hidden_timer.Start();
            s.Show();
			this.Hide();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (this.Visible)
			{
                AlwaysOnTop_F();
                MainWindow_Hidden_timer.Stop();
                label_result.Font = font;
                label_result.ForeColor = Color.FromName(color);
            }

		}

        private async void TranTimer_Tick(object sender, EventArgs e)
        {
            if (Start_tran)
            {
                Start_tran = false;
                TranTimer.Stop();
                await TakeTran(true, CopyOnTake);
                TranTimer.Start();
            }

        }

        private void ClearTimer_Tick(object sender, EventArgs e)
        {
            if (Start_clear)
            {
                Start_clear = false;
                ClearTimer.Stop();
                label_result.Text = "";
                this.BackColor = Color.FromArgb(71, 50, 60);
                this.TransparencyKey = this.BackColor;
                ClearTimer.Start();
            }
        }

        private async void CopyTimer_Tick(object sender, EventArgs e)
        {
            if (Start_copy)
            {
                Start_copy = false;
                CopyTimer.Stop();
                await TakeTran(false, true);
                CopyTimer.Start();
            }
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_HotKeys_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_HotKeys.Checked)
            {
                KotkeyActivated = true;
            }
            else
            {
                KotkeyActivated = false;
            }
        }

        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
