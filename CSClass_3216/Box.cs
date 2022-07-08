using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass_3216
{
    internal class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) width = value;
                else Console.WriteLine("너비는 자연수를 입력");
            }
        }


        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) height = value;
                else Console.WriteLine("높이도 자연수로 입력");
            }
        }

        public Box(int width, int height)
        {
            this.Width = width; 
            this.Height = height;
        }

        public int Area
        {
            get { return this.Width * this.Height; } 
        }
    }
}
//22-8 속성 #14