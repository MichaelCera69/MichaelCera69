using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace SpyHunter
{
    class TreesLeft : PictureBox
    {
        private double mSpeed;
        private Vector mPosition;

        public TreesLeft(double X, double Y, double Angle, int Size) : base()
        {

            //initialize trees
            mPosition = new Vector(X, Y);
            this.Left = (int)Position.X;
            this.Top = (int)Position.Y;
            mSpeed = 6;

            this.Width = Size;
            this.Height = Size;
            this.Image = Resource1.pixel_art_tree_icon_png1;
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
        public void MoveTick()
        {
            //move the Tree
            this.Top = (int)Position.Y + 5;
        }
    }
}

