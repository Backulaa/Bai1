using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<MySprite2D> sprites;
        int nSprites;
        private void Form1_Load(object sender, EventArgs e)
        {
            sprites = new List<MySprite2D>();
            nSprites = 2;

            Bitmap spriteImage = LoadAndSetupImage(@"C:\Users\LENOVO\Downloads\bao-nhieu-ngay-nua-den-noel-4-.png");

            for (int i = 0; i < nSprites; i++)
            {
                sprites.Add(new MySprite2D(spriteImage, i * 30, i * 50));
            }

            sprites.Add(new MySprite2D(spriteImage, 0, 0));
            nSprites++;
        }
        private Bitmap LoadAndSetupImage(string path)
        {
            Bitmap image = new Bitmap(path);
            image.MakeTransparent(image.GetPixel(0, 0));
            return image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < nSprites; i++)
            {
                sprites[i].Update();
            }

            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < nSprites; i++)
            {
                sprites[i].Draw(g);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nSprites++;
            Bitmap[] bmp;
            bmp = new Bitmap[15];
            bmp[0] = new Bitmap(@"C:\Users\LENOVO\Downloads\bao-nhieu-ngay-nua-den-noel-4-.png");
            for (int i = 0; i < bmp.Length; i++)
                bmp[i].MakeTransparent(bmp[i].GetPixel(0, 0));
            Random r = new Random();
            sprites.Add(new MySprite2D(bmp, r.Next(500), r.Next(400)));
        }
    }
}
