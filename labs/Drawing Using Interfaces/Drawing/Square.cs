﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square : DrawingShape, IDraw, IColor
    {
        /*
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle rect = null;
        */

        public Square(int sideLength): base(sideLength)
        {
        }

        //void IDraw.SetLocation(int xCoord, int yCoord)
        //{
        //    this.locX = xCoord;
        //    this.locY = yCoord;
        //}

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
                canvas.Children.Remove(this.shape);
            else
                this.shape = new Rectangle();
            base.Draw(canvas);
        }
        /*

        void IColor.SetColor(Color color)
        {
            if (this.rect != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;
            }
        }
        */
    }
}
