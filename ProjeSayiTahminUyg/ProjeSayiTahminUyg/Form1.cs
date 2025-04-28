namespace ProjeSayiTahminUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sol altaki 20 sayýdan birini secin ve tahmin etmeye baþlayýn", "Nasýl Oynanýr?");
        }
        int BabaProCoin = 2000;
        int BenimCoin = 2000;
        int benimSayi;
        int BPsayi;
        int Sonucsayi;
        bool secimYapildi;
        Random sayi1 = new Random();
        Random sayi2 = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            lblBenimBakiye.Text = BenimCoin.ToString();
            lblProBakiye.Text = BabaProCoin.ToString();
            lblSonucSayi.Visible = false;
            lblbenimSayi.Visible = false;
            lblBabaProSayi.Visible = false;
        }

        private void btnOyna_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton rb && rb.Checked)
                {
                    lblBabaProSayi.Visible = true;
                    BPsayi = sayi2.Next(1, 20);
                    lblBabaProSayi.Text = BPsayi.ToString();

                    lblSonucSayi.Visible = true;
                    Sonucsayi = sayi1.Next(1, 20);
                    lblSonucSayi.Text = Sonucsayi.ToString();

                    secimYapildi = true;

                    lblbenimSayi.Visible = true;
                    break;
                }

            }

            if (secimYapildi)
            {
                if (radioButton1.Checked)
                {
                    benimSayi = 1;
                }
                if (radioButton2.Checked)
                {
                    benimSayi = 2;
                }
                if (radioButton3.Checked)
                {
                    benimSayi = 3;
                }
                if (radioButton4.Checked)
                {
                    benimSayi = 4;
                }
                if (radioButton5.Checked)
                {
                    benimSayi = 5;
                }
                if (radioButton6.Checked)
                {
                    benimSayi = 6;
                }
                if (radioButton7.Checked)
                {
                    benimSayi = 7;
                }
                if (radioButton8.Checked)
                {
                    benimSayi = 8;
                }
                if (radioButton9.Checked)
                {
                    benimSayi = 9;
                }
                if (radioButton10.Checked)
                {
                    benimSayi = 10;
                }
                if (radioButton11.Checked)
                {
                    benimSayi = 11;
                }
                if (radioButton12.Checked)
                {
                    benimSayi = 12;
                }
                if (radioButton13.Checked)
                {
                    benimSayi = 13;
                }
                if (radioButton14.Checked)
                {
                    benimSayi = 14;
                }
                if (radioButton15.Checked)
                {
                    benimSayi = 15;
                }
                if (radioButton16.Checked)
                {
                    benimSayi = 16;
                }
                if (radioButton17.Checked)
                {
                    benimSayi = 17;
                }
                if (radioButton18.Checked)
                {
                    benimSayi = 18;
                }
                if (radioButton19.Checked)
                {
                    benimSayi = 19;
                }
                if (radioButton20.Checked)
                {
                    benimSayi = 20;
                }   // Seçim yapýlmýþ
            }
            if (secimYapildi)
            {
                if (benimSayi != 0)
                {
                    lblbenimSayi.Text = benimSayi.ToString();
                }
                if (BenimCoin < 50)
                {
                    MessageBox.Show("paranýz yeteriz bu yüzden oyunu kaybettiniz");
                }
                if (BenimCoin >= 50)
                {
                    BenimCoin -= 50;
                    lblBenimBakiye.Text = BenimCoin.ToString();
                    if (benimSayi == Sonucsayi)
                    {
                        BenimCoin += 1000;
                        MessageBox.Show("tebrikler 1000 coin kazandýnýz");
                        lblBenimBakiye.Text = BenimCoin.ToString();
                    }
                }
            }
            if (secimYapildi)
            {
                if (BabaProCoin != 0)
                {
                    lblProBakiye.Text = BabaProCoin.ToString();

                    if (BabaProCoin >= 50)
                    {
                        BabaProCoin -= 50;
                        lblProBakiye.Text = BabaProCoin.ToString();
                        if (BPsayi == Sonucsayi)
                        {
                            BabaProCoin += 1000;
                            MessageBox.Show("BabaPro 1000 coin kazandý");
                            lblProBakiye.Text = BabaProCoin.ToString();
                        }
                    }
                }
                if (BabaProCoin < 50)
                {
                    MessageBox.Show("BabaPro battý bu yüzden oyunu kazandýnýz");

                }

            }

            else
            {
                MessageBox.Show("bir sayý seciniz");
            }
        }
    }
}
