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
    class Circle : DrawingShape, IDraw, IColor
    {
        /*
        private int diameter;
        private int locX = 0, locY = 0;
        private Ellipse circle = null;
        */

        public Circle(int diameter): base(diameter)
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
                this.shape = new Ellipse();
            base.Draw(canvas);
        }
        /*

        void IColor.SetColor(Color color)
        {
            if (this.circle != null)
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.circle.Fill = brush;
            }
        }
        */
    }
}
