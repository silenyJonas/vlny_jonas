using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlny_jonas
{

    public class More
    {
        List<Bod> ListBodu = new List<Bod>();
        List<Spojnice> ListSpojnice = new List<Spojnice>();
        

        public void Start(bool b)
        {
            ListBodu = new List<Bod>();
            ListSpojnice = new List<Spojnice>();

            //nastavi body
            for (int i = 0; i <= 20; i++)
            {
                ListBodu.Add(new Bod(320 + i * 70, 300 + i * 3, i,b));
            }

            for (int i = 0; i <= 20; i++)
            {
                ListBodu.Add(new Bod(170 + i * 70, 400 + i * 3, i + 21,b));
            }

            for (int i = 0; i <= 20; i++)
            {
                ListBodu.Add(new Bod(20 + i * 70, 500 + i * 3, i + 42,b));
            }

            //nastavi spojnice
            for (int i = 0; i <= 61; i++)
            {
                if (i == 20 || i == 41)
                    i++;

                ListSpojnice.Add(new Spojnice(GetBod(i), GetBod(i + 1)));
            }

            for (int i = 0; i < 42; i++)
            {
                ListSpojnice.Add(new Spojnice(GetBod(i), GetBod(i + 21)));
            }
        }
        private Bod GetBod(int index)
        {
            foreach (Bod item in ListBodu)
            {
                if (item.Index == index)
                    return item;
            }
            return null;
        }
        public void UpdateBody()
        {
            //totok zmeneni
            foreach (Bod item in ListBodu)
            {
                if(item.Pohyb)
                    item.Update();
            }
        }
        public void RozpohybovatBod(int[] pole)
        {
            foreach (Bod item in ListBodu)
            {
                if(pole.Contains(item.Index))
                    item.Pohyb = true;
            }
        }
        public void DrawBody(Graphics g)
        {
            foreach (Bod item in ListBodu)
                item.Draw(g);
        }

        public void UpdateSpoje()
        {
            foreach (Spojnice item in ListSpojnice)
            {
                item.Update();
            }
        }
        public void DrawSpoje(Graphics g)
        {
            foreach (Spojnice item in ListSpojnice)
                item.Draw(g);
        }

    }
}
