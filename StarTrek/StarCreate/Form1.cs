using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCreate
{
    public partial class StartForm : Form
    {
        public StartForm(int mode)
        {
            InitializeComponent();
            button1.Parent = pictureBox1;
            button2.Parent = pictureBox2;
            button3.Parent = pictureBox2;
            label1.Parent = pictureBox1;
            button4.Parent = pictureBox3;
            timer1.Start();
            if (mode == 1)
            {
                StartPage.Visible = false;
                panel1.Visible = false;
            }
            axWindowsMediaPlayer1.URL = @"opening.wav";
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            game = new NASA2._0.Form1(this);
            game.Show();
            this.Visible = false;
            StartPage.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SolarSystem f = new SolarSystem();
            this.Visible = false;
            f.Visible = true;
            MessageBox.Show("現在你正在太陽系内探索！\n但你還缺乏一點對我們行星的一些瞭解~\n選擇參數決定你想探索的行星吧！\n", "説明");
        }
        private NASA2._0.Form1 game;
        private void button2_Click(object sender, EventArgs e)
        {

            StarForm.Choice f = new StarForm.Choice();
            this.Visible = false;
            f.Visible = true;
            MessageBox.Show("現在你離開了太陽系來到了其他星係！\n先挑選你要取得恆星類型~\n再設定參數去選擇你要去的行星類型！", "提示：溫度很重要");

        }
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            count++;
            if (count == 260)
            {
                panel1.Visible = false;
                //axWindowsMediaPlayer1.Ctlcontrols.stop();
                timer1.Stop();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            //axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
    }
}
