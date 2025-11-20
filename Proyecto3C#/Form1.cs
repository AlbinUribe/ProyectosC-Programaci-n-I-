namespace Proyecto3C_
{
    public partial class ScreenSaver : Form
    {
        List<Image> BitImage = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        public ScreenSaver()
        {
            InitializeComponent();
        }

        private void ScreenSaver_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }




        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string image in images)
            {
                BitImage.Add(new Bitmap(image));
            }

            for (int i = 0; i < 50; ++i)
            {
                BritPic mp = new BritPic();
                mp.PicNum = i % BitImage.Count;
                mp.X = rand.Next(0, Width);
                mp.Y = rand.Next(0, Height);

                //mp.Speed = rand.Next(100, 300) / 100.0f;

                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics) {
            
                e.Graphics.DrawImage(BitImage[bp.PicNum], bp.X, bp.Y);

                if (bp.X < -250) {

                    bp.X = Width + rand.Next(20, 100);
                }
            }
        }
    }
}
