using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiggyBankEK.Exception_Library;


namespace PiggyBankEK
{
    public partial class KumbaraForm : Form
    {
        Kumbara kumbara = new Kumbara(40000);

        private readonly List<KagitPara> KagitParalar = new List<KagitPara>();
        private readonly List<BozukPara> BozukParalar = new List<BozukPara>();
        private readonly BindingList<Para> atilanKagitParalar = new BindingList<Para>();
        private readonly BindingList<Para> atilanBozukParalar = new BindingList<Para>();

        Para secilen;
        string atilacak;
        bool katlandiMi = false;
        int kirilmaSayisi = 0;
        double birikenMiktar = 0;
        double toplamHacim = 0;
        double fazlaHacim = 0;
        public KumbaraForm()
        {
            InitializeComponent();
            ParalariOlusturEkle();
        }

        public void Ozet()
        {
            
            var messageLines = new string[]
            {
                " ****Merhaba, Kumbara (PIGGY BANK) Uygulamamıza Hoş Geldiniz! Kullanma Talimatı Şu Şekildedir;****",
                "1) 2 adet Para tipi bulunmaktadır, Bozuk ve Kağıt Paralardır. Kağıt Para Seçimi sonrası Kumbaraya atabilmek için Katlayarak atılması gerekmektedir. (Kağıt Parayı katla Butonu)",
                "2) Her seçilen para sonrası Kumbaraya Paraları İtele butonuna basılarak paralar kumbaraya aktarılır. Her seçim sonrası bu işlem yapılmalıdır.",
                "3) Kumbaranın içerisinde kalan hacimler gösterilmektedir. Shake It! butonuna basarak kumbarayı sallayıp daha fazla yer açılmasını sağlayabilirsiniz.",
                "4) Destroy Butonu 2 kere kullanılabilinir. İlk seferde Kumbarayı Kırmanızı sağlar ve kumbarada bu zamana kadar atmış olduğunuz paraları listeler ve Birikmiş paranızı gösterir.",
                "5) Destroy yani kumbarayı Kırdıktan sonra 1 kereye mahsur Tamir Etme imkanınız vardır (Yapıştır!), bu sayede bir kerey mahsus kumbara tamir edilir ve kumbaranızı (sıfırdan) (kumbara hacmide boşalır) doldurmaya devam edebilirsiniz.",
                "6) Yapıştırılan kumbara birkez daha kırılırsa paralarınız ve kumbaranız kalıcı olarak kaybolacaktır Dikatli olun :)",
                "7) İşlem sırasında kafanız karışırsa Aydınlat Beni butonuna basarak bu bilgileri tekrardan okuyabilirisniz. iyi Eğlenceler!"
            };

            MessageBox.Show(string.Join(Environment.NewLine, messageLines));
        }
        public void KumbaraninIcindekiler(BindingList<Para> kagit, BindingList<Para> bozuk, double biriken)
        {
            DataGuncelle(kagit, bozuk, biriken);
        }
        public void DataGuncelle(BindingList<Para> kagitlar, BindingList<Para> bozuklar, double birikmis)
        {
            label5.Text = "Biriken Miktar: " + birikmis.ToString() + "₺";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kagitlar.ToList();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = bozuklar.ToList();
        }

        private void ParalariOlusturEkle()
        {
            BozukParalar.Add(new BozukPara() { Ad = "1 Kuruş", Deger = 0.01, Cap = 16.50, Yukseklik = 1.35 });
            BozukParalar.Add(new BozukPara() { Ad = "5 Kuruş", Deger = 0.05, Cap = 17.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "10 Kuruş", Deger = 0.10, Cap = 18.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "25 Kuruş", Deger = 0.25, Cap = 20.50, Yukseklik = 1.65 });
            BozukParalar.Add(new BozukPara() { Ad = "50 Kuruş", Deger = 0.50, Cap = 23.85, Yukseklik = 1.90 });
            BozukParalar.Add(new BozukPara() { Ad = "1 Lira", Deger = 1.0, Cap = 26.15, Yukseklik = 1.90 });

            KagitParalar.Add(new KagitPara() { Ad = "5 Lira", Deger = 5.0, En = 64.0, Boy = 130.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "10 Lira", Deger = 10.0, En = 64.0, Boy = 136.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "20 Lira", Deger = 20.0, En = 68.0, Boy = 142.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "50 Lira", Deger = 50.0, En = 68.0, Boy = 148.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "100 Lira", Deger = 100.0, En = 72.0, Boy = 154.0, Yukseklik = 0.25 });
            KagitParalar.Add(new KagitPara() { Ad = "200 Lira", Deger = 200.0, En = 72.0, Boy = 160.0, Yukseklik = 0.25 });

            cmbKagitPara.Items.Add("Kağıt Para Seçiniz:");
            foreach (var item in KagitParalar)
            {
                cmbKagitPara.Items.Add(item.Ad);
            }
            cmbKagitPara.SelectedIndex = 0;
            cmbBozukPara.Items.Add("Madeni Para Seçiniz:");
            foreach (var item in BozukParalar)
            {
                cmbBozukPara.Items.Add(item.Ad);
            }
            cmbBozukPara.SelectedIndex = 0;
        }
        private void cmbKagitPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnKatla.Visible = false;
            if (cmbKagitPara.SelectedIndex > 0)
            {
                cmbBozukPara.Enabled = false;
                btnKatla.Visible = true;
                atilacak = cmbKagitPara.SelectedItem.ToString();
                foreach (var item in KagitParalar)
                {
                    if (atilacak == item.Ad)
                    {
                        secilen = (KagitPara)item;
                    }
                }
            }
        }
        private void cmbBozukPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBozukPara.SelectedIndex > 0)
            {
                cmbKagitPara.Enabled = false;
                atilacak = cmbBozukPara.SelectedItem.ToString();
                foreach (var item in BozukParalar)
                {
                    if (atilacak == item.Ad)
                    {
                        secilen = (BozukPara)item;
                    }
                }
            }
        }
        private void btnParaAt_Click(object sender, EventArgs e)
        {
            try
            {
                if (secilen == null)
                {
                    throw new AtilacakParaSecilmediException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (secilen is BozukPara)
            {
                BozukPara bozukpara = (BozukPara)secilen;
                try
                {
                    if (toplamHacim + bozukpara.Hacim() + bozukpara.FazladanHacim(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                atilanBozukParalar.Add(bozukpara);
                birikenMiktar += bozukpara.Deger;
                toplamHacim += bozukpara.Hacim() + bozukpara.FazladanHacim(bozukpara.Hacim());
                fazlaHacim += bozukpara.FazladanHacim(bozukpara.Hacim());

                kumbara.ParaEkle(bozukpara.Hacim() + bozukpara.FazladanHacim(bozukpara.Hacim()));
                HacimleriYazdir();
            }
            else if (secilen is KagitPara)
            {
                KagitPara kagitpara = (KagitPara)secilen;
                try
                {
                    if (toplamHacim + kagitpara.Hacim() + kagitpara.FazladanHacim(secilen.Hacim()) > kumbara.KumbaraHacmi)
                    {
                        throw new KumbaraDolduException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VerileriSifirla();
                }
                try
                {
                    if (katlandiMi == false)
                    {
                        throw new ParaKatlanmadiException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                atilanKagitParalar.Add(kagitpara);
                birikenMiktar += kagitpara.Deger;
                toplamHacim += kagitpara.Hacim() + kagitpara.FazladanHacim(kagitpara.Hacim());
                fazlaHacim += kagitpara.FazladanHacim(kagitpara.Hacim());

                kumbara.ParaEkle(kagitpara.Hacim() + kagitpara.FazladanHacim(kagitpara.Hacim()));
                HacimleriYazdir();
            }
            btnShakeIt.Enabled = true;
            VerileriSifirla();
        }
        private void VerileriSifirla()
        {
            cmbBozukPara.SelectedIndex = 0;
            cmbKagitPara.SelectedIndex = 0;
            katlandiMi = false;
            btnKatla.Text = "Parayı 4'e Katla!";
            btnKatla.Enabled = true;
            btnKatla.Visible = false;
            secilen = null;
            cmbBozukPara.Enabled = true;
            cmbKagitPara.Enabled = true;
        }
        private void btnKatla_Click(object sender, EventArgs e)
        {
            KagitPara katlanacak = (KagitPara)secilen;
            if (katlanacak != null)
            {
                katlandiMi = true;
                katlanacak.Katla(katlanacak.Hacim());
                btnKatla.Text = "Paralar 4'e Katlandı!";
                btnKatla.Enabled = false;
            }
        }
        private void btnSalla_Click(object sender, EventArgs e)
        {
            if (toplamHacim > fazlaHacim)
            {
                toplamHacim = toplamHacim - kumbara.Salla(fazlaHacim);
                kumbara.ParaEkle(-kumbara.Salla(fazlaHacim));
            }
            fazlaHacim = 0;
            btnShakeIt.Enabled = false;
            HacimleriYazdir();
            VerileriSifirla();
        }

        private void btnKir_Click(object sender, EventArgs e)
        {
            if (kirilmaSayisi == 0)
            {
                try
                {
                    if (birikenMiktar > 0)
                    {
                        KumbaraninIcindekiler(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                    }
                    else
                    {
                        throw new KumbaraBosException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnDestroy.Text = "Kumbarayı Yapıştır! (Tamir Et!)";
                btnDestroy.BackColor = Color.Green;
                btnParaAt.Enabled = false;
                btnKatla.Enabled = false;
                btnShakeIt.Enabled = false;
                atilanKagitParalar.Clear();
                atilanBozukParalar.Clear();
                kirilmaSayisi++;
                cmbBozukPara.Enabled = false;
                cmbKagitPara.Enabled = false;
                KumbaraSifirla();
            }
            else if (kirilmaSayisi == 1)
            {
                btnDestroy.Text = "DESTROY MUHAHAHA!";
                btnDestroy.BackColor = Color.DarkRed;
                cmbBozukPara.Enabled = true;
                cmbKagitPara.Enabled = true;
                btnParaAt.Enabled = true;
                btnKatla.Enabled = true;
                btnShakeIt.Enabled = true;
                kirilmaSayisi++;
                birikenMiktar = 0;
                KumbaraSifirla();
            }
            else if (kirilmaSayisi > 1)
            {
                try
                {
                    if (birikenMiktar > 0)
                    {
                        KumbaraninIcindekiler(atilanKagitParalar, atilanBozukParalar, birikenMiktar);
                    }
                    else
                    {
                        throw new KumbaraBosException();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnDestroy.Text = "Artıkın Kırılamaz! Bakiye BOŞALTILDI";
                btnParaAt.Enabled = false;
                btnDestroy.Enabled = false;
                btnKatla.Enabled = false;
                btnShakeIt.Enabled = false;
                KumbaraSifirla();
                try
                {
                    throw new KumbaraKullanilamazException();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Close();
            }
        }
        private void KumbaraSifirla()
        {
            birikenMiktar = 0;
            kumbara.ParaMiktari = 0;
            toplamHacim = 0;
            fazlaHacim = 0;
            lblParaHacmi.Text = "Paraların kapladığı hacim: 0";
            lblFazladan.Text = "Paraların kapladığı fazladan hacim: 0";
        }

        public void HacimleriYazdir()
        {
            lblParaHacmi.Text = "Paraların kapladığı hacim: " + toplamHacim.ToString();
            lblFazladan.Text = "Paraların kapladığı fazladan hacim: " + fazlaHacim.ToString();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblParaHacmi_Click(object sender, EventArgs e)
        {

        }

        private void lblFazladan_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KumbaraForm_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)this.Ozet);
        }

        private void btnAydinlat_Click(object sender, EventArgs e)
        {
            var messageLines = new string[]
            {
                " ****Kullanma Talimatı Şu Şekildedir;****",
                "1) 2 adet Para tipi bulunmaktadır, Bozuk ve Kağıt Paralardır. Kağıt Para Seçimi sonrası Kumbaraya atabilmek için Katlayarak atılması gerekmektedir. (Kağıt Parayı katla Butonu)",
                "2) Her seçilen para sonrası Kumbaraya Paraları İtele butonuna basılarak paralar kumbaraya aktarılır. Her seçim sonrası bu işlem yapılmalıdır.",
                "3) Kumbaranın içerisinde kalan hacimler gösterilmektedir. Shake It! butonuna basarak kumbarayı sallayıp daha fazla yer açılmasını sağlayabilirsiniz.",
                "4) Destroy Butonu 2 kere kullanılabilinir. İlk seferde Kumbarayı Kırmanızı sağlar ve kumbarada bu zamana kadar atmış olduğunuz paraları listeler ve Birikmiş paranızı gösterir.",
                "5) Destroy yani kumbarayı Kırdıktan sonra 1 kereye mahsur Tamir Etme imkanınız vardır (Yapıştır!), bu sayede bir kerey mahsus kumbara tamir edilir ve kumbaranızı doldurmaya devam edebilirsiniz.",
                "6) Yapıştırılan kumbara birkez daha kırılırsa paralarınız ve kumbaranız kalıcı olarak kaybolacaktır Dikatli olun :)",
                "7) İyi Eğlenceler!"
            };

            MessageBox.Show(string.Join(Environment.NewLine, messageLines));
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
