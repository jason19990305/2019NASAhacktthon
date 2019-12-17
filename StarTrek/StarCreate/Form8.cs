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
    public partial class Form8 : Form
    {
        double L,yy;
        bool d = false;
        double A, km, AU;
        double t;
        int R;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            d = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            A = hScrollBar1.Value / 100.0;
            km = System.Convert.ToDouble(textBox3.Text);
            AU = hScrollBar2.Value / 100.0;
            if (checkBox2.Checked == true)
            {
                R = 1;
                checkBox6.Checked = false;
            }
            if (checkBox6.Checked == true)
            {
                R = 2;
                checkBox2.Checked = false;
            }
            
            if(R == 1)
            {
                t = Math.Pow(L / (16.0 * 3.14 * 0.0000000567) * (1 - A) / (AU*AU), 0.25);
            }
            if(R == 2)
            {
                t = Math.Pow(L / ((8.0 * 3.14 * 0.0000000567)) * ((1 - A) / (AU * AU)), 0.25);
            }
            bool flag;
            /*if(t >(-190) && t < 100)
            {
                
            }
            else
            {
                label5.Text = "You can not live here";
            }*/
            Form4 f = new Form4(t);
            f.ShowDialog();
        }

        

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = hScrollBar1.Value.ToString() + "%";
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            double v = hScrollBar2.Value / 100.0;
            label7.Text = Convert.ToString(v);
            
            pictureBox1.Location = new Point(Convert.ToInt32(763-8.17*v), 202);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox6.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int mode=1;
            StartForm p = new StartForm(1);
            p.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            d = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (d)
            {
                int x = new int();
                int y = new int();
                int nx = new int();
                int ny = new int();
                y = e.Location.Y;
                x = e.Location.X;
                nx = pictureBox1.Location.X;
                ny = pictureBox1.Location.Y;
                x = nx + x;
                y = ny + y;

                if (x > 360 && x < 760)
                {
                    pictureBox1.Location = new Point(x - 25, 202);
                    hScrollBar2.Value = Convert.ToInt32((x - 354) * 0.1223 * 100.0);
                    label7.Text = (hScrollBar2.Value/100).ToString();
                }
                //label5.Text = nx.ToString() + " "  + ny.ToString();
                

            }
        }

        

        public Form8(double xx,double yy,Image pic)
        {
            InitializeComponent();
            L = xx;
            this.yy = yy;
            pictureBox2.Image=pic;
            
        }
    }
}
