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
    public partial class Form6 : Form
    {
        String flag;
        public Form6(string s)
        {
            InitializeComponent();
            label1.Parent = this;
            SolarSystem S = new SolarSystem();
            flag = s;
            string[] jieshao = new string[]
            {
                "水星\n類地行星\n水星由大約70%的金屬和30%的矽酸鹽材料組成，" +
                "水星的密度是5.427克/cm³，\n在太陽系中是第二高的，僅次於地球的5.515克/cm³。\n" +
                "從水星的密度可以推測其內部結構的詳細資料。\n地球的高密度，特別是核心的高密度是由" +
                "重力壓縮所導致的。\n水星是如此的小，因此它的內部不會被強力的擠壓。\n所以它要有如此" +
                "高的密度，\n它的核心必然很大且含有許多的鐵。\n" ,

                "金星\n類地行星\n金星地殼的厚度大約是 50公里，" +
                "由矽酸鹽礦物組成；\n地函厚度約 3000公里，組成成分仍未知。" +
                "\n因為金星是類地行星，因此一般假設金星有一個\n成分以鐵和鎳" +
                "為主的半固體核心，\n半徑約 3000公里。\n",

                "地球\n類地行星\n地殼主要由石英（矽的氧化物）\n類長石的其他矽酸鹽構成。\n" +
                " 71％的地球表面為水所覆蓋。\n" +
                "地球是行星中唯一一顆能在表面存在有液態水的星球。\n" +
                "地球的大氣由77％的氮，21％氧，\n微量的氬、二氧化碳和水組成。\n",

                "火星\n類地行星\n地核半徑約為火星半徑的一半，\n除了主要的鐵還包含15~17%的硫，\n" +
                "較輕元素含量亦為地球的兩倍，故熔點較低，\n使地核部份為液態，如地球的內外核。\n" +
                "核外包覆矽酸鹽的地函，曾形成火星地\n表的構造與火山，但現今似乎不活動了。\n",

                "木星\n類木行星\n木星的主要成分是氫，\n但只佔十分之一分子數量的氦，\n卻佔了總質量的四分之一；\n" +
                "它可能有岩石的核心和重元素，\n但是像其他的巨行星一樣，\n木星沒有可以明確界定的固體表面。\n",

                "土星\n類木行星\n土星主要由氫組成，還有少量的氦與微痕元素，\n內部的核心包括岩石和冰，" +
                "外圍由數層金屬氫和氣體包覆著。\n最外層的大氣層在外觀上通常情況下都是平淡的，" +
                "雖然有時會有長時間存在的特徵出現。\n土星的風速高達1,800公里/時，\n風速明顯比木" +
                "星快。\n土星的行星磁場強度介於地球和更強的木星之間。\n",

                "天王星\n類海行星\n天王星大氣的主要成分是氫和氦，\n還包含較高比例的由水、氨、甲烷等結成的「冰」，\n" +
                "與可以探測到的碳氫化合物。\n天王星是太陽系內大氣層最冷的行星，\n" +
                "最低溫度只有49K（−224℃）。\n其外部的大氣層具有複雜的雲層結構，\n" +
                "水在最低的雲層內，\n而甲烷組成最高處的雲層。\n相比較而言，\n天王星的內部則是由冰和岩石所構成。\n",

                "海王星\n類海行星\n海王星的大氣層以氫和氦為主，還有微量的甲烷。\n" +
                "在大氣層中的甲烷，\n只是使行星呈現藍色的一部分原因。\n" +
                "因為海王星的藍色比有同樣份量的天王星更為鮮豔，\n" +
                "因此應該還有其他成分對海王星明顯的顏色有所貢獻。\n"
            };
            string[] star = new string[] { "水星", "金星", "地球", "火星", "土星", "木星", "天王星", "海王星" };
            Image shui = Image.FromFile("水.png");
            Image jin = Image.FromFile("金.png");
            Image di = Image.FromFile("地.png");
            Image huo = Image.FromFile("火.png");
            Image tu = Image.FromFile("土.png");
            Image mu = Image.FromFile("木.png");
            Image tian = Image.FromFile("天.png");
            Image hai = Image.FromFile("海.png");
            Image[] palent = new Image[] { shui, jin, di, huo, tu, mu, tian, hai };
            for (int i = 0; i < 8; i++)
                if (s == star[i])
                {
                    label1.Text = jieshao[i];
                    this.BackgroundImage = palent[i];
                }
        }
        Bitmap bit;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            bit = new Bitmap("oie_transparent (1).png");
            bit.MakeTransparent(Color.Blue);
        }
    }
}
