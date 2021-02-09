using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var stream = new FileStream(@"D:\Courses\CSharpAdvanced - 19.01.2021\9.IO\BlueRose.jpeg", FileMode.Open))
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
        }
    }
}
