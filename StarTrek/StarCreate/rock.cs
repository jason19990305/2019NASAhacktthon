using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace NASA2._0
{
    public class rock:PictureBox
    {
        public rock(int x,int y)
        {
            this.Image = Image.FromFile(@"rock1.gif");
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(80, 80);
        }
       
        
    }
}
