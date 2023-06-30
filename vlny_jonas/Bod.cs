using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlny_jonas
{
    public class Bod
    {
        private bool Mode { get; set; }
        private int Rychlost { get; set; } = 2;
        private int Counter { get; set; } = 0;
        public bool Pohyb { get; set; } = false;
        public int Index { get; set; }
        private bool Smer { get; set; } = true;
        public int X { get; set; }
        public int Y { get; set; }
        private int Width { get; set; } = 20;
        private int Height { get; set; } = 20;
        public Bod(int x, int y, int index, bool b)
        {
            Mode = b;
            Index = index;
            X = x;
            Y = y;

        }
        public void Draw(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, X, Y, Width, Height);
        }
        public void Update()
        {
            if (Mode)
            {
                if (Smer)
                    this.Y = this.Y + Rychlost;
                else
                    this.Y = this.Y - Rychlost;
            }
            else
            {
                if (Smer)
                    this.X = this.X + Rychlost;
                else
                    this.X = this.X - Rychlost;
            }

            Counter++;
            if (Counter == 40)
            {
                Counter = 0;
                Smer = !Smer;
            }

            if (Counter > 35 || Counter < 15)
                Rychlost = 1;
            else
                Rychlost = 3;
        }
    }
}
