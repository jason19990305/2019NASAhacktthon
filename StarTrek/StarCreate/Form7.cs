using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASA2._0
{
    public partial class Form1 : Form
    {
        private Graphics plant;
        private rock Rock1;
        private rock Rock2;
        private int countdown;
        private int Second1;
        private int Second2;
        private int Second4;
        private bool BoolExplosion;
        private int Second3;
        private StarCreate.StartForm f;

        public Form1(StarCreate.StartForm t)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            panel2.Visible = true;
            panel1.Visible = false;
            button1.Parent = pictureBox2;
            button2.Parent = pictureBox1;
            f = t;

        }
        private void PanelStart()
        {
            Random num = new Random();
            int x = num.Next(0, 200);
            Rock1 = new rock(x, 0);
            this.Controls.Add(Rock1);
            //pictureBox1.Parent = Rock;
            BoolExplosion = false;

            label1.Parent = pictureBox1;
            label1.Visible = false;
            label2.Parent = pictureBox1;
            label2.Visible = false;

            int x1 = num.Next(0, 200);
            Rock2 = new rock(x1, 0);
            this.Controls.Add(Rock2);

            Timer1.Start();
            Timer2.Start();

            BW_bangbang.RunWorkerAsync();

            PictureRocket.Parent = pictureBox1;
            Rock1.Parent = pictureBox1;
            Rock2.Parent = pictureBox1;

            Second1 = 0;
            Second2 = 0;
            Second3 = 0;
            Second4 = 0;
            countdown = 0;

            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.URL = @"Rain_Cloud_Music.mp3";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //int index = e.KeyChar;
            //int x = PictureRocket.Location.X;
            //int y = PictureRocket.Location.Y;

            //if (index == 'A' || index == 'a')
            //{
            //    PictureRocket.Location = new Point(x - 10, y);
            //}
            //else if (index == 'D' || index == 'd')
            //{
            //    PictureRocket.Location = new Point(x + 10, y);
            //}
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            countdown++;

            Second1++;
            //label1.Text = Second.ToString();
            if (Second1 / 10 % 10 == 9)
            {
                Rock1.Dispose();
                Random num = new Random();
                int x = num.Next(0, 200);
                Rock1 = new rock(x, 0);

                this.Controls.Add(Rock1);
                Rock1.Parent = pictureBox1;
                Second1 += 10;
            }
            Rock1.Top += 8;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Second2++;

            //label1.Text = Second.ToString();
            if (Second2 / 10 % 8 == 7)
            {

                Rock2.Dispose();
                Random num = new Random();
                int x = num.Next(0, 200);
                Rock2 = new rock(x, 0);

                this.Controls.Add(Rock2);
                Rock2.Parent = pictureBox1;
                Second2 += 10;
            }
            Rock2.Top += 12;
        }

        private void BW_bangbang_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                BW_bangbang.ReportProgress(1);
                System.Threading.Thread.Sleep(300);
            }
        }

        private void BW_bangbang_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            int x1, x2, y1, y2, x3, y3, x, y;
            x1 = Rock1.Location.X;
            y1 = Rock1.Location.Y + 40;
            x2 = Rock2.Location.X;
            y2 = Rock2.Location.Y + 40;
            x = PictureRocket.Location.X;
            y = PictureRocket.Location.Y;


            //double distance1 = Math.Sqrt(Math.Pow(x-x1,2)+Math.Pow(y-y1,2));
            //double distance2 = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));



            if (Math.Abs(y - y1) <= 40)
            {
                if (Math.Abs(x - x1) <= 30)
                {
                    axWindowsMediaPlayer1.URL = @"350980__cabled-mess__lose-c-08.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    PictureRocket.Image = Image.FromFile("C:\\Users\\huang\\source\\repos\\StarCreate\\StarCreate\\Properties\\explosion.gif");
                    BoolExplosion = true;
                    Timer3.Start();
                }
            }
            else if (Math.Abs(y - y2) <= 40)
            {
                if (Math.Abs(x - x2) <= 30)
                {
                    axWindowsMediaPlayer1.URL = @"350980__cabled-mess__lose-c-08.wav";
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    PictureRocket.Image = Image.FromFile("explosion.gif");
                    BoolExplosion = true;
                    Timer3.Start();
                }
            }
            int n = countdown / 10;
            n = 6 - n;


            if (countdown >= 60)
            {
                axWindowsMediaPlayer1.URL = @"391539__mativve__electro-win-sound.wav";
                axWindowsMediaPlayer1.Ctlcontrols.play();
                label2.Visible = true;
                Timer1.Stop();
                Timer2.Stop();
                Timer3.Stop();
                countdown = 0;

                f.Visible = true;
                
                
                this.Close();
            }
            else
                label3.Text = "CountDown:" + n.ToString();
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            Second3++;
            if (Second3 == 8)
            {

                PictureRocket.Dispose();
                Timer1.Stop();
                Timer2.Stop();

                Timer3.Stop();
                label1.Visible = true;
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
        }


        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {

            int x = e.Location.X;
            if (!label2.Visible)
                PictureRocket.Location = new Point(x - 30, 270);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            PanelStart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1(f);
            s.Show();
            this.Visible = false;
        }
    }
}
