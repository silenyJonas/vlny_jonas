using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlny_jonas
{
    public class Spojnice
    {
        public Bod OdchBod { get; set; }
        public Bod KoncBod { get; set; }
        public int ZacX { get; set; }
        public int ZacY { get; set; }
        public int KonX { get; set; }
        public int KonY { get; set; }
        public Spojnice(Bod odch, Bod konc)
        {
            OdchBod = odch;
            KoncBod = konc;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black,2), ZacX, ZacY, KonX, KonY);
        }
        public void Update()
        {
            ZacX = OdchBod.X + 10;
            ZacY = OdchBod.Y + 10;
            KonX = KoncBod.X + 10;
            KonY = KoncBod.Y + 10;
            //MessageBox.Show(ZacX.ToString());
        }

    }

}
