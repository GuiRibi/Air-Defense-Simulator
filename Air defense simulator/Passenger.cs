using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_defense_simulator
{
    public class Passenger
    {
        public double V { get; set; }
        public double A { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Color Color { get; set; }
        public Point CenterPassenger { get; set; }
        public int TrackNumber { get; set; }
        public double IFF { get; set; }
        public Passenger(double v, double a, Color color, double x, double y, int trackNumber, double iFF)
        {
            V = v;
            A = a;
            X = x;
            Y = y;
            Color = color;
            TrackNumber = trackNumber;
            IFF = iFF;
        }

        public void DrawPassenger(Graphics passenger)
        {
            //Drawing the passenger
            double x1 = 12 * Math.Cos(A);
            double y1 = 12 * Math.Sin(A);

            Point pointDirection = new Point(CenterPassenger.X + (int)x1, CenterPassenger.Y + (int)y1);
            passenger.DrawEllipse(new Pen(Color), (int)Math.Round(X - 5), (int)Math.Round(Y - 5), 10, 10);
            passenger.DrawLine(new Pen(Color), CenterPassenger, pointDirection);

            passenger.DrawString("Track " + TrackNumber, new Font("Segoe", 7), new SolidBrush(Color), CenterPassenger.X + 6, CenterPassenger.Y + 6);
        }

        public void MovementPassenger()
        {
            //Moving the passenger
            X = X + V * Math.Cos(A) * 3;
            Y = Y + V * Math.Sin(A) * 3;

            CenterPassenger = new Point((int)Math.Round(X), (int)Math.Round(Y));
        }
    }
}
