using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gallary
{
    
    public partial class Form1 : Form
    {

        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (i==20)
            {
                return;
            }
            else
            {
                i++;
            }
                pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("image" + i);
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                return;
            }
            else
            {
                i--;
            }

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("image" + i);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path;
            path = Application.ExecutablePath;
            int i = path.LastIndexOf("bin");
            path = path.Substring(0, i)+"image\\Women.png";
            pictureBox2.Image = Image.FromFile(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            path = Application.ExecutablePath;
            int i = path.LastIndexOf("bin");
            path = path.Substring(0, i)+ "image\\wololooooooooooooooooooooo.jpg";
            pictureBox2.Image = Image.FromFile(path);
        }
    }
}
