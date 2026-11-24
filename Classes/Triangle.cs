using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _7pr.Classes
{
    public class Triangle : GeometricFigure
    {
        public double Size {  get; set; }

        public Triangle(double x, double y, double size) : base(x, y)
        {
            Size = size;
        }

        public override void Draw(Canvas canvas)
        {
            Polygon triangle = new Polygon();

            triangle.Points = new PointCollection
            {
                new Point(X, Y -  Size),
                new Point(X - Size, Y + Size/2),
                new Point(X + Size, Y + Size/2),
            };
            triangle.Stroke = Brushes.Red;
            triangle.StrokeThickness = 3;

            canvas.Children.Add(triangle);
        }
    }
}
