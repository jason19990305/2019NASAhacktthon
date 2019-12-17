using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarForm
{
    public partial class Choice : Form
    {
        Image pic1 = Image.FromFile("11.png");
        Image pic2 = Image.FromFile("22.png");
        Image pic3 = Image.FromFile("33.png");
        Image pic4 = Image.FromFile("44.png");
        Image pic5 = Image.FromFile("55.png");
        public Choice()
        {
            InitializeComponent();
            //StarCreate.Form8 f = new StarCreate.Form8();
            //MessageBox.Show("選擇一個恆星模型儅你星係的中心","Hint",)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X;
            int y = e.Location.Y;
           
            //label1.Text = x.ToString();
            if (x >= 451 - 20 && x <= 451 + 20)
            {
                if (y > 353 - 20 && y <= 353 + 20)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 3000;
                    xx += 3000;
                    if(MessageBox.Show("光度:10^"+yy.ToString()         
                        +"溫度:"+xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(Math.Pow(10, -4),yy,pic5);
                        f.ShowDialog();
                        this.Close();
                    }
                    
                }
            }
            if (x >= 386 - 20 && x <= 386 + 20)
            {
                if (y > 307 - 20 && y <= 307 + 20)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 3000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(Math.Pow(10, -2), yy,pic4);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (x >= 316 - 20 && x <= 316 + 20)
            {
                if (y > 229 - 20 && y <= 229 + 20)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 3000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(1.0,yy,pic3);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (x >= 243 - 20 && x <= 243 + 20)
            {
                if (y > 319 - 20 && y <= 319 + 20)
                {

                    MessageBox.Show("它\n快要死了...請不要再按它了。謝謝您的配合", "我是白矮星，我快去世了。");
                    
                }
            }
            if (x >= 378 - 30 && x <= 378 + 30)
            {
                if (y > 158 - 30 && y <= 158 + 30)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 3000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(100.0,yy,pic4);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (x >= 462 - 30 && x <= 462 + 30)
            {
                if (y > 51 - 30 && y <= 51 + 30)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 5000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(100000.0,yy,pic5);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (x >= 239 - 20 && x <= 239 + 20)
            {
                if (y > 148 - 20 && y <= 148 + 20)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    xx *= 5000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(Math.Pow(10, 3), yy,pic2);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
            if (x >= 164 - 20 && x <= 164 + 20)
            {
                if (y > 64 - 20 && y <= 64 + 20)
                {
                    double yy = 371 - y;
                    yy /= 35;
                    yy -= 4;
                    double xx = 462 - x;
                    xx /= 77;
                    
                    xx *= 5000;
                    xx += 3000;
                    if (MessageBox.Show("光度:10^" + yy.ToString() + "溫度:" + xx.ToString(), "Confirm Message", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        StarCreate.Form8 f = new StarCreate.Form8(Math.Pow(10,4),yy,pic1);
                        f.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}




























































































































































































































































































