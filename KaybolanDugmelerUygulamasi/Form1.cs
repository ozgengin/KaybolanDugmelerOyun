namespace KaybolanDugmelerUygulamasi
{
    public partial class Form1 : Form
    {
        DateTime ilkYokOlusZamani;
        int yokOlanAdet = 0;
        public Form1()
        {
            InitializeComponent();
            DugmeleriYukle();
        }

        private void DugmeleriYukle()
        { 
            int sayac = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Text = sayac.ToString();
                    btn.Size = new Size(40, 40);
                    btn.Left += j * 50;
                    btn.Top += i * 50;
                    btn.MouseEnter += Btn_MouseEnter;
                    pnlDugmeler.Controls.Add(btn);
                    sayac++;
                }
            }
        }

        private void Btn_MouseEnter(object? sender, EventArgs e) //sender içinde mouseevent'in tetiklediği buton var.
        {
            if (yokOlanAdet == 0)
            {
                ilkYokOlusZamani = DateTime.Now;
            }
            Button uzerineGelinenButon = (Button)sender;
            uzerineGelinenButon.Hide();
            yokOlanAdet++;
            if (yokOlanAdet == 100)
            {
                TimeSpan sure = DateTime.Now - ilkYokOlusZamani;
                MessageBox.Show($"Oyun bitti. Geçen süre {sure}");
            }
        }
    }
}