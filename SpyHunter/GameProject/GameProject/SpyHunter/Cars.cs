using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace SpyHunter
{
    class Cars : PictureBox
    {
        private double mSpeed;
        private Vector mPosition;

        public Cars(double X, double Y, double Angle, int Size) : base()
        {

            //initialize cars
            mPosition = new Vector(X, Y);
            this.Left = (int)Position.X;
            this.Top = (int)Position.Y;
            mSpeed = 6;

            
            this.Image = Resource1.Drawing_2_sketchpad;
            this.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Visible = true;


        }
        public double Speed
        {
            get { return mSpeed; }
            set { mSpeed = value; }
        }

        public Vector Position
        {
            get { return mPosition; }
            set { mPosition = value; }
        }
    }
}

