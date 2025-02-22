using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class MySprite2D
    {
        private Bitmap[] _BMP;
        private int _nBMP;
        private int _iBMP;
        private int _Left;
        private int _Top;
        private int _Width;
        private int _Height;

        public Bitmap[] BMP 
        { 
            get => _BMP; 
            set
            {
                _BMP = value;
                _nBMP = _BMP.Length;
                _iBMP = 0;
                _Width = _BMP[0].Width;
                _Height = _BMP[0].Height;
            }

        }
        public int nBMP { get => _nBMP; set => _nBMP = value; }
        public int iBMP { get => _iBMP; set => _iBMP = value; }
        public int Left { get => _Left; set => _Left = value; }
        public int Top { get => _Top; set => _Top = value; }
        public int Width { get => _Width; set => _Width = value; }
        public int Height { get => _Height; set => _Height = value; }

        public MySprite2D(Bitmap[] bmp, int left, int top)
        {
            BMP = bmp;
            Left = left;
            Top = top;
        }

        public void Update()
        {
            _iBMP = (_iBMP + 1) % _nBMP;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(_BMP[_iBMP], _Left, _Top);
        }
    }
}
