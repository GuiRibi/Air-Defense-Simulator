using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.IO.Packaging;

namespace Air_defense_simulator
{
    public class Missile
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point PointMissile { get; set; }
        public Target Target { get; set; }
        public Passenger Passenger { get; set; }
        public bool TargetReached { get; set; } 
        public bool PassengerReached { get; set; }
        public int TrackNumber { get; set; }

        double XFireball; // Point of intersection's X coordinate
        double YFireball; // Point of intersection's Y coordinate

        public Missile(int missileX, int missileY, Target target, Passenger passenger, int trackNumber)
        {
            X = missileX;
            Y = missileY;
            Target = target;
            Passenger = passenger;
            TargetReached = false;
            PassengerReached = false;
            TrackNumber = trackNumber;
        }
        public void DrawMissile(Graphics missile)
        {
            //Drawing the missile
            Point point2 = new Point(PointMissile.X - 6, PointMissile.Y - 16);
            Point point3 = new Point(PointMissile.X + 6, PointMissile.Y - 16);

            missile.DrawLine(Pens.Green, PointMissile, point2);
            missile.DrawLine(Pens.Green, PointMissile, point3);

            missile.DrawString("Track " + TrackNumber, new Font("Segoe", 7), Brushes.Green, PointMissile.X + 6, PointMissile.Y + 6);
        }

        //Target
        public void MoveMissile()
        {
            if (Target != null)
            {
                //Calculating where the missile and target should intercept
                double V01 = 2.291; // Missile's speed in pixels per second
                double m01; // the slope of the missile's trajectory
                double t; // time

                double K1 = (Target.X - X) * (Target.X - X) + (Target.Y - Y) * (Target.Y - Y);
                double K2 = (2 * ((Target.X - X) * Math.Cos(Target.A) * Target.V)) + (2 * ((Target.Y - Y) * Math.Sin(Target.A) * Target.V));
                double K3 = (Math.Cos(Target.A) * Target.V) * (Math.Cos(Target.A) * Target.V) + (Math.Sin(Target.A) * Target.V) * (Math.Sin(Target.A) * Target.V) - (V01 * V01);

                double t1 = (-K2 + Math.Sqrt((K2 * K2) - 4 * K1 * K3)) / (2 * K3);
                double t2 = (-K2 - Math.Sqrt((K2 * K2) - 4 * K1 * K3)) / (2 * K3);

                if (t1 > 0)
                {
                    t = t1;
                }
                else
                {
                    t = t2;
                }

                XFireball = Target.X + Math.Cos(Target.A) * Target.V * t;
                YFireball = Target.Y + Math.Sin(Target.A) * Target.V * t;

                //Moving the missile
                m01 = (Y - YFireball) / (X - XFireball);
                double A = Math.Atan(m01);

                if (XFireball < X)
                    A = Math.PI + A;

                X = X + V01 * Math.Cos(A) * 3;
                Y = Y + V01 * Math.Sin(A) * 3;

                PointMissile = new Point((int)Math.Round(X), (int)Math.Round(Y));

                bool HitboxX = X < Target.X + 6 && X > Target.X - 6;
                bool HitboxY = Y < Target.Y + 6 && Y > Target.Y - 6;

                if (HitboxX && HitboxY)
                {
                    TargetReached = true;
                }
            }
        }

        //Passenger
        public void MoveMissilePassenger()
        {
            if (Passenger != null)
            {
                //Calculating where the missile and passenger should intercept
                double V01 = 1.927; // Missile's speed in pixels per second
                double m01; // the slope of the missile's trajectory
                double t; // time

                double K1 = (Passenger.X - X) * (Passenger.X - X) + (Passenger.Y - Y) * (Passenger.Y - Y);
                double K2 = (2 * ((Passenger.X - X) * Math.Cos(Passenger.A) * Passenger.V)) + (2 * ((Passenger.Y - Y) * Math.Sin(Passenger.A) * Passenger.V));
                double K3 = (Math.Cos(Passenger.A) * Passenger.V) * (Math.Cos(Passenger.A) * Passenger.V) + (Math.Sin(Passenger.A) * Passenger.V) * (Math.Sin(Passenger.A) * Passenger.V) - (V01 * V01);

                double t1 = (-K2 + Math.Sqrt((K2 * K2) - 4 * K1 * K3)) / (2 * K3);
                double t2 = (-K2 - Math.Sqrt((K2 * K2) - 4 * K1 * K3)) / (2 * K3);

                if (t1 > 0)
                {
                    t = t1;
                }
                else
                {
                    t = t2;
                }

                XFireball = Passenger.X + Math.Cos(Passenger.A) * Passenger.V * t;
                YFireball = Passenger.Y + Math.Sin(Passenger.A) * Passenger.V * t;

                //Moving the missile
                m01 = (Y - YFireball) / (X - XFireball);
                double A = Math.Atan(m01);

                if (XFireball < X)
                    A = A - Math.PI;

                X = X + V01 * Math.Cos(A) * 3;
                Y = Y + V01 * Math.Sin(A) * 3;

                PointMissile = new Point((int)Math.Round(X), (int)Math.Round(Y));

                bool HitboxX = X < Passenger.X + 6 && X > Passenger.X - 6;
                bool HitboxY = Y < Passenger.Y + 6 && Y > Passenger.Y - 6;

                if (HitboxX && HitboxY)
                {
                    PassengerReached = true;
                }
            }
        }

        public void DrawDashedLine(Graphics dashedline)
        {
            //Drawing dashed line between the missile and the predicted interception point
            Point Fireball = new Point((int)XFireball, (int)YFireball);
            Point Cross1 = new Point(Fireball.X - 6, Fireball.Y - 6);
            Point Cross2 = new Point(Fireball.X + 6, Fireball.Y + 6);
            Point Cross3 = new Point(Fireball.X - 6, Fireball.Y + 6);
            Point Cross4 = new Point(Fireball.X + 6, Fireball.Y - 6);

            var pendash = new Pen(Color.Green, 2);
            pendash.DashStyle = DashStyle.Dash;
            dashedline.DrawLine(pendash, PointMissile, Fireball);

            var pen = new Pen(Color.Green, 2);
            pen.DashStyle = DashStyle.Solid;
            dashedline.DrawLine(pen, Cross1, Cross2);
            dashedline.DrawLine(pen, Cross3, Cross4);
        }
    }
}
