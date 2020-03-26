using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Taks_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath maPath = new System.Drawing.Drawing2D.GraphicsPath();
            maPath.AddPolygon(new Point[] { new Point(this.Width, this.Height/2), new Point (this.Width/2, this.Height), new Point(0, this.Height/2), new Point (this.Width/2, 0)});
            Region myRegion = new Region(maPath); this.Region = myRegion;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
