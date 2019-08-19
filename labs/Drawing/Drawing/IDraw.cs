using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        void SetLocation(int xCoord, int yCoord);
        void Draw(Canvas canvas); //Canvas is a type, which is a control in Xaml
    }
}
