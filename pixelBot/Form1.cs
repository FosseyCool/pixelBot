using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Media;
using System.Globalization;

namespace pixelBot
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;
        private int w;
        private int h;
        private Bitmap bitmap1;
        private Point? pt;

        private SoundPlayer player;
        // private Bitmap bitmap2;
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
            player = new SoundPlayer(@"Sound.wav");
        }

        private void MakeScreen()
        {
            Point location = pictureBox1.PointToScreen(Point.Empty);
            x = location.X + 5;
            y = location.Y + 5;
            w = pictureBox1.Width - 5;
            h = pictureBox1.Height - 5;

            bitmap1 = new Bitmap(w, h);

            using (Graphics g = Graphics.FromImage(bitmap1))
            {
                g.CopyFromScreen(x + 1, y, 10, 0, new Size(w, h - 2));
            }

            bitmap1.Save("scrstart.png", System.Drawing.Imaging.ImageFormat.Png);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // MakeScreen();
            // bitmap1.Dispose();

            bitmap1 = new Bitmap(Image.FromFile("scrstart.png"));

            Bitmap bmp2 = new Bitmap(w, h);
            using (Graphics g = Graphics.FromImage(bmp2))
            {
                // g.CopyFromScreen(x, y, 0, 0, new Size(w, h));
                g.CopyFromScreen(x + 1, y, 10, 0, new Size(w, h - 2));
            }


            pt = GetMismatchPoint(bitmap1, bmp2);

            if (pt != null)
            {
                // MessageBox.Show("текст изменен");             
                timer1.Enabled = false;
                //  VolUp();
                this.WindowState = FormWindowState.Normal;
                this.TopMost = true;
                player.Play();
                player.PlayLooping();


            }
        }

        Point? GetMismatchPoint(Bitmap bmp1, Bitmap bmp2)
        {
            using (var wr1 = new ImageWrapper(bmp1))
            using (var wr2 = new ImageWrapper(bmp2))
                foreach (var p in wr1)
                    if (wr1[p] != wr2[p])
                        return p;

            return null;
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);
        private void VolUp()
        {
            for (int i = 0; i < 50; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_UP);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            MakeScreen();
            timer1.Start();
        }

        private void timerForTime_Tick(object sender, EventArgs e)
        {
            timerForTime.Interval = 1000;
            timerForTime.Start();

            textBox1.Text = textBox1.Text = DateTime.Now.ToString("yyyy.MM.dd, HH.mm.ss");
        }

        private void muteProgram_Click(object sender, EventArgs e)
        {
            player.Stop();
            muteProgram.BackColor = Color.Blue;
        }
    }
}