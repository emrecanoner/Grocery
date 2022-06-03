using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakkal
{
    public partial class frmBakkal : Form
    {
        public frmBakkal()
        {
            InitializeComponent();
        }
        decimal ekmek = 1.25m;
        decimal süt = 2.25m;
        decimal sakız = 0.35m;
        decimal yoğurt = 5.45m;
        decimal doritos = 3.50m;
        decimal süzme_peynir = 7.50m;
        decimal pepsi = 4.90m;
        decimal hesap1 = 0;
        decimal hesap2 = 0;
        decimal hesap3 = 0;
        decimal hesap4 = 0;
        decimal hesap5 = 0;
        decimal hesap6 = 0;
        decimal hesap7 = 0;
        decimal toplam = 0;
        private void frmBakkal_Load(object sender, EventArgs e)
        {

        }

        private void btnyazdır_Click(object sender, EventArgs e)
        {
            if (Ürünler.SelectedIndex == 0)
            {
                hesap1 = (Convert.ToDecimal(se1.EditValue) * ekmek);
                tbox1.Text = Convert.ToString(hesap1);
                if (se1.EditValue == "0")
                { tbox1.Text = "0"; }
            }

            else if (Ürünler.SelectedIndex == 2)
            {
                hesap2 = (Convert.ToDecimal(se2.EditValue) * süt);
                tbox2.Text = Convert.ToString(hesap2);
                if (se2.EditValue == "0")
                { tbox2.Text = "0"; }
            }
            else if (Ürünler.SelectedIndex == 4)
            {
                hesap3 = (Convert.ToDecimal(se3.EditValue) * sakız);
                tbox3.Text = Convert.ToString(hesap3);
                if (se3.EditValue == "0")
                { tbox3.Text = "0"; }
            }
            else if (Ürünler.SelectedIndex == 6)
            {
                hesap4 = (Convert.ToDecimal(se4.EditValue) * yoğurt);
                tbox4.Text = Convert.ToString(hesap4);
                if (se4.EditValue == "0")
                { tbox4.Text = "0"; }
            }
            else if (Ürünler.SelectedIndex == 8)
            {
                hesap5 = (Convert.ToDecimal(se5.EditValue) * doritos);
                tbox5.Text = Convert.ToString(hesap5);
                if (se5.EditValue == "0")
                { tbox5.Text = "0"; }
            }
            else if (Ürünler.SelectedIndex == 10)
            {
                hesap6 = (Convert.ToDecimal(se6.EditValue) * süzme_peynir);
                tbox6.Text = Convert.ToString(hesap6);
                if (se6.EditValue == "0")
                { tbox6.Text = "0"; }
            }
            else if (Ürünler.SelectedIndex == 12)
            {
                hesap7 = (Convert.ToDecimal(se7.EditValue) * pepsi);
                tbox7.Text = Convert.ToString(hesap7);
                if (se7.EditValue == "0")
                { tbox7.Text = "0"; }
            }
            else
            {
                MessageBox.Show("Ürün Seçiniz", "UYARI", MessageBoxButtons.OK);
            }
        }

        private void Ürünler_DoubleClick(object sender, EventArgs e)
        {
            Alınanlar.Items.Add(Ürünler.SelectedItem);
        }

        private void btnfiş_Click(object sender, EventArgs e)
        {
            tboxtarih.Text = DateTime.Now.ToLongDateString();
            tboxzaman.Text = DateTime.Now.ToLongTimeString();
            toplam = (hesap1 + hesap2 + hesap3 + hesap4 + hesap5 + hesap6 + hesap7);
            tboxtoplam.Text = Convert.ToString(toplam);
            string mtutar = Convert.ToString(toplam).Replace(",", ".");
            string lira = mtutar.Substring(0, mtutar.IndexOf("."));
            string kurus = mtutar.Substring(mtutar.IndexOf(".") + 1, 2);
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] yüzler = { "", "Yüz", "İkiyüz", "Üçyüz", "Dörtyüz", "Beşyüz", "Altıyüz", "Yediyüz", "Sekizyüz", "Dokuzyüz" };
            string yazi = "";

            int yaziuzunluk = yazi.Length;
            int grupsayisi = 3;
            lira = lira.PadLeft(grupsayisi * 3, '0');
            string grupdegeri = "";

            for (int i = 0; i < grupsayisi * 3; i += 3)
            {

                if (lira.Substring(i, 1) != "0")
                {
                    grupdegeri += yüzler[Convert.ToInt32(lira.Substring(i, 1))];
                }
                if (lira.Substring(i + 1, 1) != "0")
                {
                    grupdegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))];
                }
                if (lira.Substring(i + 2, 1) != "0")
                {
                    grupdegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))];
                }
            }
            if (yazi.Length > yaziuzunluk)
            {
                tboxyazıyla.Text = (yazi += "TL#");
            }
            if (kurus.Substring(0, 1) != "0")
            {
                tboxyazıyla.Text = yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];
            }
            if (kurus.Substring(1, 1) != "0")
            {
                tboxyazıyla.Text = yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
            }
            tboxyazıyla.Text =" # "+ grupdegeri+ " # TL # " + yazi + " # Kr # ";
        }
    }
}
