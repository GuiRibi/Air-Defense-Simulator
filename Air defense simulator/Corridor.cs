using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_defense_simulator
{
    public class Corridor
    {
        public void corridor(Graphics corridor)
        {
            //Drawing Airway corridor
            Point pointCorridor0_1 = new Point(198, 262);
            Point pointCorridor0_2 = new Point(284, 204);
            Point pointCorridor0_3 = new Point(413, 182);
            Point pointCorridor0_4 = new Point(511, 189);
            Point pointCorridor1_1 = new Point(174, 239);
            Point pointCorridor1_2 = new Point(264, 170);
            Point pointCorridor1_3 = new Point(391, 151);
            Point pointCorridor1_4 = new Point(541, 161);

            var pen = new Pen(Color.Blue, 2);

            corridor.DrawLine(pen, pointCorridor0_1, pointCorridor0_2);
            corridor.DrawLine(pen, pointCorridor0_2, pointCorridor0_3);
            corridor.DrawLine(pen, pointCorridor0_3, pointCorridor0_4);
            corridor.DrawLine(pen, pointCorridor1_1, pointCorridor1_2);
            corridor.DrawLine(pen, pointCorridor1_2, pointCorridor1_3);
            corridor.DrawLine(pen, pointCorridor1_3, pointCorridor1_4);


            corridor.DrawString("Airway", new Font("Segoe", 11), Brushes.Blue, 474, 162);
        }
    }
}
