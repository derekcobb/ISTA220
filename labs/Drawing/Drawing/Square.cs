using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Square: IDraw, IColor
    {
        private int sideLength;
        private int locX = 0, locY = 0;
        private Rectangle rect = null;  //Declaring a new variable of type Rectangle and not initializing it. Set equal to null

        public Square(int sideLength)
        {
            this.sideLength = sideLength;
        }

        void IDraw.Draw(Canvas canvas)
        {
            if (this.rect != null)
                canvas.Children.Remove(this.rect);
            else
                this.rect = new Rectangle();
            this.rect.Height = this.sideLength;
            this.rect.Width = this.sideLength;
            Canvas.SetTop(this.rect, this.locY);
            Canvas.SetLeft(this.rect, this.locX);
            canvas.Children.Add(this.rect);
        }

        void IColor.SetColor(Color color) //'IColor' here it is explicit implementation
        {
            if (this.rect != null)  //Curly braces are needed when you have multiple statements inside of your 'if' block
            {
                SolidColorBrush brush = new SolidColorBrush(color);
                this.rect.Fill = brush;   //'Fill is  a property
            }
        }

        void IDraw.SetLocation(int xCoord, int yCoord)
        {
            this.locX = xCoord;
            this.locY = yCoord;
        }
    }
}
