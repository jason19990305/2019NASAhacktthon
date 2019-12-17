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
    public partial class Form4 : Form
    {
        double t;
        public Form4(double t)
        {
            this.t = t;
            InitializeComponent();
            LB_T.Text = "地表溫度:"+t.ToString();
            if (t <= 0)
            {
                String t0 = "天氣太過寒冷 較少動物能夠生存";
                LB_creatresult.Text = t0;
            }
            else if (t > 0 && t < 16)
            {
                String t16down ="單細胞生物\n" +
                                "哺乳類、鳥類、被子植物\n"+
                                "蕨類植物的時代\n"+
                                "裸子植物出現\n"+
                                "藻類、無脊椎生物\n"+
                                "三葉蟲\n"+
                                "昆蟲\n";
                LB_creatresult.Text = "可生存的生物有:\n"+t16down;
            }
            else if (t >= 16 && t <= 18)
            {
                String t1618 ="蘚苔植物\n" +
                              "節肢動物、兩生類\n" +
                              "恐龍、哺乳類、鳥類\n" +
                              "裸子植物\n" +
                              "針葉樹比較繁茂\n" +
                              "被子植物興盛\n" +
                              "陸地出現維管植物\n" +
                              "昆蟲\n";
                LB_creatresult.Text = "可生存的生物有:\n" + t1618;
            }
            else if (t > 18 && t < 50)
            {
                String t1850 = "可生存的生物有:\n" + "海生無脊椎動物\n" + "種子進行繁殖的種子蕨門\n";
                LB_creatresult.Text = t1850;

            }
            else if (t >= 50) {
                String t50up = "天氣太過炎熱\n"+"較少動物可以生存\n";
                LB_creatresult.Text = t50up;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
