using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace StarCreate
{
    
    public partial class SolarSystem : Form
    {
        bool d;
        bool f = false;
        string[] temper = new string[] { "-173~427", "420~485", "-88~58", "-87~-5", "-148", "-178", "-216", "-214" };
        string[] volume = new string[] { "0.054", "0.88", "1", "0.150", "1316", "763.6", "63.1", "57.7" };
        string[] density = new string[] { "5.427", "5.24", "5.515", "3.94", "1.33", "0.7", "1.3", "1.76" };
        string[] rotation = new string[] { "58.646", "243", "0.997", "1.026", "0.413", "0.444", "0.718", "0.671" };
        string[] Revolution = new string[] { "87.97", "224.7", "365.24", "686.93", "11.856", "29.448", "84.02", "164.79" };
        string[] elem = new string[] { "N2", "O2", "CO2", "CH4", "H2","HE"};
        

        String[] shui = new string[] { "-173~427", "0.054", "5.427", "58.646", "87.97", "57.90million km", "0", "1", "0", "0", "1", "0" };
        String[] jin = new string[] { "420~485", "0.88", "5.24", "243", "224.7", "108.20million km", "1", "0", "1", "0", "0", "0" };
        String[] di = new string[] { "-88~58", "1", "5.515", "0.997", "365.24", "149.59million km", "1", "1", "0", "0", "0", "0" };
        String[] huo = new string[] { "-87~-5", "0.150", "3.94", "1.026", "686.93", "227.93million km", "1", "0", "1", "0", "0", "0" };
        String[] mu = new string[] { "-148", "1316", "1.33", "0.413", "11.856", "778.41million km", "0", "0", "0", "0", "1", "1" };
        String[] tu = new string[] { "-178", "763.6", "0.7", "0.444", "29.448", "1426.72million km", "0", "0", "0", "0", "1", "1" };
        String[] tian = new string[] { "-216", "63.1", "1.3", "0.718", "84.02", "2870.97million km", "0", "0", "0", "1", "1", "1" };
        String[] hai = new string[] { "-214", "57.7", "1.76", "0.671", "164.79", "4498.25million km", "0", "0", "0", "1", "1", "1" };
        public string[] Getrandom(string[] str)
        {
            int len = str.Length;//用變數記會快一點點點
            Random rd = new Random();
            int r;//記下隨機產生的號碼
            string tmp;//暫存用
            for (int i = 0; i < len-1; i++)
            {
                r = rd.Next(i, len);//取亂數，範圍從自己到最後，決定要和哪個位置交換，因此也不用跑最後一圈了
                if (i == r) continue;
                tmp = str[i];
                str[i] = str[r];
                str[r] = tmp;
            }
            return str;
        }
        public SolarSystem()
        {
            InitializeComponent();
            panel1.Parent = pictureBox1;
            pictureBox2.Parent = pictureBox1;
            pictureBox3.Parent = pictureBox1;
            pictureBox4.Parent = pictureBox1;
            pictureBox5.Parent = pictureBox1;
            pictureBox6.Parent = pictureBox1;
            pictureBox7.Parent = pictureBox1;
            pictureBox8.Parent = pictureBox1;
            pictureBox9.Parent = pictureBox1;
            pictureBox10.Parent = pictureBox1;
            pictureBox11.Parent = pictureBox1;
            pictureBox12.Parent = pictureBox1;
            pictureBox13.Parent = pictureBox1;
            pictureBox14.Parent = pictureBox1;
            pictureBox15.Parent = pictureBox1;
            pictureBox16.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label14.Parent = pictureBox1;
            checkBox1.Parent = pictureBox1;
            checkBox2.Parent = pictureBox1;
            checkBox3.Parent = pictureBox1;
            checkBox4.Parent = pictureBox1;
            checkBox5.Parent = pictureBox1;
            checkBox6.Parent = pictureBox1;
            //button1.Parent = pictureBox1;
            button2.Parent = pictureBox1;
            //MessageBox.Show("現在你正在太陽系内探索！\n但你還缺乏一點對我們行星的一些瞭解~\n選擇參數決定你想探索的行星吧！\n", "説明");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (d)
            {
                int x = new int();
                int y = new int();
                int nx = new int();
                int ny = new int();
                y = e.Location.Y;
                x = e.Location.X;
                nx = pictureBox2.Location.X;
                ny = pictureBox2.Location.Y;
                x = nx + x;
                y = ny + y;
                pictureBox2.Location = new Point(x-25, 232);
                label7.Location = new Point(x - 50, 270);
                pictureBox16.Location = new Point(x + 25, 232);
                //label3.Text = pictureBox16.Location.X.ToString()+" "+pictureBox16.Location.Y.ToString() ;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            d = true;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            d = false;
            int x = new int();
            int y = new int();
            int nx = new int();
            int ny = new int();
            y = e.Location.Y;
            x = e.Location.X;
            nx = pictureBox2.Location.X;
            ny = pictureBox2.Location.Y;
            x = nx + x;
            y = ny + y;
            if (nx > 800) { pictureBox2.Location = new Point(840, 232); label7.Location = new Point(804, 270); label7.Text = "57.90million km"; pictureBox16.Location = new Point(880, 232); }
            if (nx < 800 && nx > 724) { pictureBox2.Location = new Point(760, 232); label7.Location = new Point(724, 270); label7.Text = "108.20million km"; pictureBox16.Location = new Point(817, 232); }
            if (nx < 724 && nx > 645) { pictureBox2.Location = new Point(681, 232); label7.Location = new Point(645, 270); label7.Text = "149.59million km"; pictureBox16.Location = new Point(731, 232); }
            if (nx < 645 && nx > 577) { pictureBox2.Location = new Point(610, 232); label7.Location = new Point(574, 270); label7.Text = "227.93million km"; pictureBox16.Location = new Point(660, 232); }
            if (nx < 577 && nx > 497) { pictureBox2.Location = new Point(540, 232); label7.Location = new Point(504, 270); label7.Text = "778.41million km"; pictureBox16.Location = new Point(590, 232); }
            if (nx < 497 && nx > 425) { pictureBox2.Location = new Point(462, 232); label7.Location = new Point(426, 270); label7.Text = "1426.72million km"; pictureBox16.Location = new Point(512, 232); }
            if (nx < 425 && nx > 330) { pictureBox2.Location = new Point(388, 232); label7.Location = new Point(352, 270); label7.Text = "2870.97million km"; pictureBox16.Location = new Point(432, 232); }
            if (nx < 330) { pictureBox2.Location = new Point(282, 232); label7.Location = new Point(246, 270); label7.Text = "4498.25million km"; pictureBox16.Location = new Point(362, 232); }

        }

        

        private void SolarSystem_Load(object sender, EventArgs e)
        {
            temper = Getrandom(temper);
            volume = Getrandom(volume);
            density = Getrandom(density);
            rotation = Getrandom(rotation);
            Revolution = Getrandom(Revolution);
            //elem = Getrandom(elem);
            for(int i = 0; i < 8; i++)
            {
                this.comboBox1.Items.Add(temper[i]);
                this.comboBox2.Items.Add(volume[i]);
                this.comboBox3.Items.Add(density[i]);
                this.comboBox4.Items.Add(rotation[i]);
                this.comboBox5.Items.Add(Revolution[i]);
                //this.comboBox6.Items.Add(elem[i]);
            }
        }

        

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            StartForm f = new StartForm(1);
            this.Close();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String quetion = comboBox6.Text;
            label14.Visible = false;
            label3.Text = quetion;
            f = false;
            pictureBox5.Visible = false;
            pictureBox10.Visible = false;
            pictureBox9.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox16.Visible = false;
            pictureBox13.Visible = false;
            pictureBox15.Visible = false;
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox6.Visible = false;
            pictureBox14.Visible = false;
            String pytemp = comboBox1.Text;
            String pyvol = comboBox2.Text;
            String pyd = comboBox3.Text;
            String pyro = comboBox4.Text;
            String pyre = comboBox5.Text;
            String pym = label7.Text;
            String co = "0", n = "0", ch = "0", o = "0", h = "0", he = "0";
            int[] count = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            if (checkBox1.Checked == true) n = "1";
            if (checkBox2.Checked == true) o = "1";
            if (checkBox3.Checked == true) co = "1";
            if (checkBox4.Checked == true) ch = "1";
            if (checkBox5.Checked == true) h = "1";
            if (checkBox6.Checked == true) he = "1";
            //string[] elem = new string[] { "N2", "O2", "CO2", "CH4", "H2", "HE" };
            string[] plstar = new string[] { pytemp, pyvol, pyd, pyro, pyre, pym, n, o, co, ch, h, he };
            string[] star = new string[] { "水星", "金星", "地球", "火星", "土星", "木星", "天王星", "海王星" };


            for (int i = 0; i < 12; i++)
            {
                    if (plstar[i] == shui[i]) count[0]++;
                    if (plstar[i] == jin[i]) count[1]++;
                    if (plstar[i] == di[i]) count[2]++;
                    if (plstar[i] == huo[i]) count[3]++;
                    if (plstar[i] == tu[i]) count[4]++;
                    if (plstar[i] == mu[i]) count[5]++;
                    if (plstar[i] == tian[i]) count[6]++;
                    if (plstar[i] == hai[i]) count[7]++;
             }
                Dictionary<string, int> dic = new Dictionary<string, int>();
                dic.Add(star[0], count[0]);
                dic.Add(star[1], count[1]);
                dic.Add(star[2], count[2]);
                dic.Add(star[3], count[3]);
                dic.Add(star[4], count[4]);
                dic.Add(star[5], count[5]);
                dic.Add(star[6], count[6]);
                dic.Add(star[7], count[7]);
                dic = (from entry in dic orderby entry.Value ascending select entry).ToDictionary(pair => pair.Key, pair => pair.Value);
                //label13.Text = dic.Last().Value.ToString() + " " + dic.Last().Key.ToString();
            String tishi = "";
            bool k = false;
            if (quetion == "") { quetion = dic.Last().Key.ToString(); k = true; }
            
            if (quetion == "水星")
            {
                tishi = "你輸入的數據最接近水星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != shui[i])
                    {
                        f = true;
                        // string[] elem = new string[] { "N2", "O2", "CO2", "CH4", "H2", "HE" };
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "金星")
            {
                tishi = "你輸入的數據最接近金星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != jin[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "地球")
            {
                tishi = "你輸入的數據最接近地球！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != di[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "火星")
            {
                tishi = "你輸入的數據最接近火星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != huo[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "土星")
            {
                tishi = "你輸入的數據最接近土星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != tu[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "木星")
            {
                tishi = "你輸入的數據最接近木星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != mu[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else if (quetion == "天王星") 
            {
                tishi = "你輸入的數據最接近天王星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != tian[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            else
            {
                tishi = "你輸入的數據最接近海王星！\n";
                for (int i = 0; i < 12; i++)
                {
                    if (plstar[i] != hai[i])
                    {
                        f = true;
                        if (i == 0) pictureBox5.Visible = true;
                        if (i == 1) pictureBox10.Visible = true;
                        if (i == 2) pictureBox9.Visible = true;
                        if (i == 3) pictureBox8.Visible = true;
                        if (i == 4) pictureBox7.Visible = true;
                        if (i == 5) pictureBox16.Visible = true;
                        if (i == 6) pictureBox13.Visible = true;
                        if (i == 7) pictureBox15.Visible = true;
                        if (i == 8) pictureBox12.Visible = true;
                        if (i == 9) pictureBox11.Visible = true;
                        if (i == 10) pictureBox6.Visible = true;
                        if (i == 11) pictureBox14.Visible = true;
                    }
                    //System.Threading.Thread.Sleep(2000);
                }
            }
            if (k == true) { label14.Text = tishi; label14.Visible = true; }
            if(f == false && k!=true)
            {
                Form6 f = new Form6(quetion);
                f.ShowDialog();
            }
        }    

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
