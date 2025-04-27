using Iinterface;

namespace Brushes
{
    class PencilBrush : IDraw
    {
        public void Draw()
        {
            System.Console.WriteLine("Pencil is drawing");
        }
    }

    class InkBrush : IDraw
    {
        public void Draw()
        {
            System.Console.WriteLine("Ink drawing");
        }
    }

    class PaintBrush : IDraw
    {
        public void Draw()
        {
            System.Console.WriteLine("Drawing with paint");
        }
    }
}
