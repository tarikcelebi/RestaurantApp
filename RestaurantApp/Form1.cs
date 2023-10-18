using RestaurantApp.Concretes;

namespace RestaurantApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public static List<Menu> Menuler=new List<Menu>();
        public static List<ExtraProducts> ExtraProducts=new List<ExtraProducts>();
        public static List<Siparis> Siparisler = new List<Siparis>();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            SiparisOlusturEkraniGetir();
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlusturEkraniGetir();
        }

        private void SiparisOlusturEkraniGetir()
        {
            FormlariKapat();
            SiparisOlustur sof = new SiparisOlustur();
            sof.MdiParent = this;
            sof.Dock = DockStyle.Fill;
            sof.Size = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height);
            sof.Show();

        }

        private void tümSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            TumSiparisler tsf = new TumSiparisler();
            tsf.MdiParent = this;
            tsf.Dock = DockStyle.Fill;
            tsf.Size = new Size(this.ClientRectangle.Width, this.ClientRectangle.Height);
            tsf.Show();
            
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            MenuAdd mef = new MenuAdd();
            mef.MdiParent = this;
            mef.Dock = DockStyle.Fill;
            mef.Height = this.Height;
            mef.Width = this.Width;
            mef.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariKapat();
            EkstraMalzemeEkle emef = new EkstraMalzemeEkle();
            emef.MdiParent = this;
            emef.Dock = DockStyle.Fill;
            emef.Height = this.Height;
            emef.Width = this.Width;
            emef.Show();
        }

        private void FormlariKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }
        }
    }
}