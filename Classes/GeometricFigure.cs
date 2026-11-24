using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _7pr.Classes
{
    public class GeometricFigure
    {
        public double Y {  get; set; }
        public double X { get; set; }

        public GeometricFigure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public virtual void Draw(Canvas canvas)
        {

        }
    }
}
