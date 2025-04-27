using Brushes;
using Iinterface;

namespace Creators
{
    abstract class Creator
    {
        public abstract IDraw Method();
    }

    class PencilCreator : Creator
    {
        public override IDraw Method()
        {
            return new PencilBrush();
        }
    }

    class InkCreator : Creator
    {
        public override IDraw Method()
        {
            return new InkBrush();
        }
    }
    class PaintCreator : Creator
    {
        public override IDraw Method()
        {
            return new PaintBrush();
        }
    }
}
