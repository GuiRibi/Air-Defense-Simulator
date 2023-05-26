using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Air_defense_simulator
{

    public class Target
    {
        public static double RNG(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble() * (max - min) + min;
        }

        public double V { get; set; }
        public double A { get; set; }
        public Color Color { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Point PointTarget { get; set; }
        public int TrackNumber { get; set; }
        public double IFF { get; set; }
        public int GIPX { get; set; }
        public int GIPY { get; set; }
        public bool GIP { get; set; }
        public bool GIPReached { get; set; }
        public Target(double v, double a, Color c, int pointx, int pointy, int tracknumber, double iFF, int gipX, int gipY, bool gip)
        {
            V = v;
            A = a;
            Color = c;
            X = pointx;
            Y = pointy;
            TrackNumber = tracknumber;
            IFF = iFF;
            GIPX = gipX; 
            GIPY = gipY;
            GIP = gip;
        }
        double M1; //The slope
        double M2; //The inverse of M1
        double x1; //Relative to M1
        double y1; //Relative to M1
        double x2; //Relative to M2
        double y2; //Relative to M2

        public void DrawTarget(Graphics target)
        {
            //Making the Target's icon turn
            M1 = Math.Tan(A);
            M2 = -1 / M1;

            x1 = 12 * Math.Cos(A);
            y1 = 12 * Math.Sin(A);

            x2 = 12 * Math.Cos(Math.Atan(M2));
            y2 = 12 * Math.Sin(Math.Atan(M2));

            Point point1 = new Point(PointTarget.X - (int)Math.Round((x1 + x2) / 2), PointTarget.Y - (int)Math.Round((y1 + y2) / 2));
            Point point2 = new Point(point1.X + (int)Math.Round(x1), point1.Y + (int)Math.Round(y1));
            Point point3 = new Point(point2.X + (int)(Math.Round(x2)), point2.Y + (int)Math.Round(y2));
            Point point4 = new Point(point1.X + (int)Math.Round(x2), point1.Y + (int)Math.Round(y2));
            Point point5 = new Point(PointTarget.X + (int)(1.5 * Math.Round(x1)), PointTarget.Y + (int)(1.5 * Math.Round(y1)));

            //Drawing the target
            target.DrawLine(new Pen(Color), point1, point2);
            target.DrawLine(new Pen(Color), point2, point3);
            target.DrawLine(new Pen(Color), point3, point4);
            target.DrawLine(new Pen(Color), point4, point1);
            target.DrawLine(new Pen(Color), PointTarget, point5);

            target.DrawString("Track " + TrackNumber, new Font("Segoe", 7), new SolidBrush(Color), PointTarget.X + 6, PointTarget.Y + 6);
        }

        public void MoveTarget()
        {
            //Moving the target
            X = X + V * Math.Cos(A) * 3;
            Y = Y + V * Math.Sin(A) * 3;

            PointTarget = new Point((int)Math.Round(X), (int)Math.Round(Y));

            bool HitboxX = X < GIPX + 1 && X > GIPX - 1;
            bool HitboxY = Y < GIPY + 1 && Y > GIPY - 1;

            if (HitboxX && HitboxY)
            {
                GIPReached = true;
            }
        }
        public void DrawGIP(Graphics gip)
        {
            //Drawing dashed line between the Target and the predicted Ground Impact Point
            Point GIP = new Point(GIPX, GIPY);

            var pendash = new Pen(Color.Red, 1);
            pendash.DashStyle = DashStyle.Dash;
            gip.DrawLine(pendash, PointTarget, GIP);

            gip.FillEllipse(Brushes.Red, GIPX - 3, GIPY - 3, 6, 6);

            gip.DrawString("GIP " + TrackNumber, new Font("Segoe", 7), Brushes.Red, GIPX + 5, GIPY + 5);
        }
    }
}
