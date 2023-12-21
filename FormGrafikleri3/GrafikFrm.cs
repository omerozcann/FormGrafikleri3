using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGrafikleri3
{
    public partial class GrafikFrm : Form
    {
        Graphics g;
        public GrafikFrm()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void ciz_Click(object sender, EventArgs e)
        {
            Random r=new Random();
            
            for (int i = 0; i < 100; i++)
            {
                int x=r.Next(100);
                g.FillEllipse(Brushes.Blue,r.Next(500),r.Next(300),x,x);
            }
        }

        private void temizlebtn_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
        }
    }
}
