namespace vlny_jonas
{
    public partial class Form1 : Form
    {
        private More More = new More();
        int i = 0;
        int ii = 0;
        private bool Mode { get; set; } = true;
        

        public Form1()
        {
            InitializeComponent();
            More.Start(Mode);
            label1.Text = "Pøíèné vlnìní";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            More.UpdateBody();
            More.UpdateSpoje();
            this.pictureBox1.Refresh();
            if (i % 15 == 0 && i <= 1050)
            {
                int[] pole = new int[] { ii, ii+21, ii+42 };
                More.RozpohybovatBod(pole);
                
                ii++;
            }
            if (i <= 1050)
                i++;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {          
            Graphics g = e.Graphics;
            More.DrawSpoje(g);
            More.DrawBody(g);
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Mode = !Mode;
            More.Start(Mode);

            if (Mode)
                label1.Text = "Pøíèné vlnìní";
            else
                label1.Text = "Podélné vlnìní";


            i=0;
            ii=0;
        }

        
    }
}