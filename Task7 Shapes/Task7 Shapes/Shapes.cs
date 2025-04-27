using Prototype;
namespace ShapeLibrary
{
    class Circle : IPrototype<Circle>
    {
        private double _radius { get; set; }

        public Circle(double Radius)
        {
            _radius = Radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if(value <= 0) throw new ArgumentException("Radius can not be negative or zero");
                _radius = value;
            }
        }

        public Circle Clone()
        {
            return new Circle(this.Radius);
        }
    }

    class Rectangle : IPrototype<Rectangle>
    {
        private double _width { get; set; }
        private double _length { get; set; }

        public Rectangle(double Width, double Length)
        {
            _width = Width;
            _length = Length;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if(value <= 0) throw new ArgumentException("Value can not be negative");
                _width = value;
            }
        }

        public double Length
        {
            get { return _length; }
            set
            {
                if(value <= 0) throw new ArgumentException("Value can not be negative");
                _length = value;
            }
        }

        public Rectangle Clone()
        {
            return new Rectangle(this.Length, this.Width);
        }
    }

    class Square : IPrototype<Square>
    {
        private double _width { get; set; }

        public Square(double Width)
        {
            _width = Width;
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if(value <= 0) throw new ArgumentException("The value can not be negative");
                _width = value;
            }
        }

        public Square Clone()
        {
            return new Square(this.Width);
        } 
    }
}