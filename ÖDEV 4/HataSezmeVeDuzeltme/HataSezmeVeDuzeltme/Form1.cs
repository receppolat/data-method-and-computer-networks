using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HataSezmeVeDuzeltme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private byte LRC(byte[] bytes)
        {
            byte LRC = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                LRC ^= bytes[i];
            }
            return LRC;
        }

        private void hamming()
        {
            int basamakSayisi, ikininKatlari = 1;
            string ikiliSayi = tbVeriHamming.Text;
            string hammingOlusturma = "";
            basamakSayisi = ikiliSayi.Length;
            int sayac1 = 1, sayac2 = 1;
            while (sayac2 <= basamakSayisi)
            {
                if (ikininKatlari == sayac1)
                {
                    ikininKatlari *= 2;
                    hammingOlusturma += "X";
                }
                else
                {
                    hammingOlusturma += ikiliSayi[basamakSayisi - sayac2];
                    sayac2++;
                }
                sayac1++;
            }

            for (int sayac = hammingOlusturma.Length - 1; sayac >= 0; sayac--)
            {
                tbKodHamming.Text += hammingOlusturma[sayac].ToString();
            }
        }

        private void CRC()
        {
           
            string ikilisayi, divisor, ilkKontrolKod = "0000";
            ikilisayi = tbVeriCRC.Text + ilkKontrolKod;// datamızı ve divisorımızı yan yana yazıyoruz. Sadece 1 ve 0 lardan oluşur textbocların textChanged özlliğinde kontorl ediliyor.
            divisor = tbDivisorCRC.Text;//divisaora kullanıcının divisor değerini giriyor.
            int[] ikilisayidizi = new int[ikilisayi.Length];
            int[] divisordizi = new int[divisor.Length];
            for (int sayac = 0; sayac < ikilisayidizi.Length; sayac++)//yeni verimiz<in uzunluğu kadar dönüyor.
            {
                ikilisayidizi[sayac] = Convert.ToInt32(ikilisayi[sayac].ToString());//stringin dizi özelliğinden yararlanıp dizimizi yeni int diziye atıyoruz.
                if (sayac < divisordizi.Length)//divisorımızın uzunluğu kadar işlem yaptırır.
                {
                    divisordizi[sayac] = Convert.ToInt32(divisor[sayac].ToString());
                }
            }
            int basamakfarki, sayac1 = 0;
            basamakfarki = ikilisayi.Length - divisor.Length;
            bool sifir = false;
            while (sayac1 <= basamakfarki)
            {
                if (ikilisayidizi[sayac1] == 0)
                {
                    sifir = true;
                }
                else
                {
                    sifir = false;
                }
                for (int sayac2 = 0; sayac2 < divisor.Length; sayac2++)
                {
                    if (sifir == false)
                    {
                        ikilisayidizi[sayac1 + sayac2] = ikilisayidizi[sayac1 + sayac2] ^ divisordizi[sayac2];
                    }
                    else
                    {
                        ikilisayidizi[sayac1 + sayac2] = ikilisayidizi[sayac1 + sayac2] ^ 0;
                    }
                }
                sayac1 = sayac1 + 1;
            }
            tbCodeWordCRC.Text = tbVeriCRC.Text;
            for (int sayac = ikilisayidizi.Length - ilkKontrolKod.Length; sayac < ikilisayidizi.Length; sayac++)
            {
                tbCodeWordCRC.Text += ikilisayidizi[sayac];
            }
            tbCodeWordCRC.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
            tbDivisorCRC.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
            tbVeriCRC.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
        }

        private void CheckSumHesapla()
        {
            //Hexadecimal için de aynı kodlar geçerli olacaktır ancak ben harfleri alırken ASCI kodlarını alabildim 2lik sistemde karşılıklarını değil. öRN A için 69 aldım 10 değil. Buyüzden onun kodunu geliştiremedim. Ama algoritma olarak aynı yolların alınabileceğini düşünüyorum.
           
            byte a = Convert.ToByte(lbVerilerCS.Items[0].ToString(), 2);//ilk elemanı byte türüne çevirerek a değişkenine atıyoruz.
            byte b = Convert.ToByte(lbVerilerCS.Items[1].ToString(), 2);//ikinci elemanı byte türüne çevirerek b değişkenine atıyoruz.
            byte c = (byte)(a + b);//ilk iki elemanı toplayarak byte türüne çevirerek c değişkenine atıyoruz. 
            for (int i = 0; i < lbVerilerCS.Items.Count; i++)//Girilen veri kadar dönmesini sağlıyoruz.
            {
                if (i == 0)//Eğer ilk işlem ise yukarıda yaptığımız işlemi yapmasını sağlıyoruz.
                {
                    if (a + b > 255)//Byte türü 255e kadar Değer tutabilir.(MAX = (11111111)2lik sistemde) eğer toplamalrı 255i geçerse yani CarryBiti varsa carry bitini toplama atıyoruz.
                        c = (byte)(a + b + 1);
                    continue;//Başa dönemsini sağlıyoruz. 
                }
                else
                {
                    if (c + Convert.ToByte(lbVerilerCS.Items[i].ToString(), 2) > 255)//Toplam ve sıradaki verinin toplamı 255i geçerse eğer carry biti vardır demek. 
                    {

                        c += (byte)(Convert.ToByte(lbVerilerCS.Items[i].ToString(), 2) + 1);//Bu yüzden de yukardaki gibi 1 ekliyoruz. Ve toplamla toplattırıyoruz.
                    }
                    else
                        c += Convert.ToByte(lbVerilerCS.Items[i].ToString(), 2);//Eğer carry biti yoksa sadece toplamı ve segmenti ekliyoruz.
                }
                tbToplam.Text = Convert.ToString(c, 2);//bulduğumuz byte türündeki veriyi 2lik sisteme çevirerek, tbToplama atıyoruz.
                tbCheckSum.Text = Convert.ToString(255 - c, 2);//Bulduğumz sayımızın tümleyenini almamız gerekir. Bu yüzden de byte türüdneyken 255 çıkartırsak 1'e tümleyeneni almış oluruz.

            }
            tbVeriCS.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
            tbToplam.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
            tbCheckSum.Clear();//Üst üst eklenmemesi için sıfırlamamız lazım
        }

        private void rbHex_CheckedChanged(object sender, EventArgs e)
        {
            Hex_Bin.Text = "Veri uzunluğunu 4 haneli girerek sırasıyla ekleyiniz.";
        }

        private void rbBinary_CheckedChanged(object sender, EventArgs e)
        {
            Hex_Bin.Text = "Veri uzunluğunu 8 haneli girerek sırasıyla ekleyiniz.";
        }

        private void btnEkleCS_Click(object sender, EventArgs e)
        {
            Hex_Bin.ForeColor = Color.Black;
            if (rbBinary.Checked)
            {
                if (tbVeriCS.Text.Length == 8)//8 Bitlik veriler için işlemlerin yapılmasını sağlar.
                {
                    lbVerilerCS.Items.Add(tbVeriCS.Text);//Veriler eğer 8 bitse ve sadece 0 ve 1 den oluşmuşsa ekleme işlemini yapar. 0 ve 1 kontolünü de tbVeriCS_TextChanged fonksiyonunda kontrol ediyoruz.
                }
                else
                    MessageBox.Show("Lütfen verinizi 8 haneli olacak şekilde yazınız.", "Uzunluk Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);//Eğer 8 bitten oluşmuyorsa hata mesajını veriyoruz.
            }
            else
                Hex_Bin.ForeColor = Color.Red;//RadioButtonu seçmesi için kullanıcı uyaran labela dikkat çekmek amaçlı rengi kırmızı yaptık.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (lbVerilerCS.Items.Count >= 2)
                CheckSumHesapla();//CheckSumHesapla fonksiyonunu çağırıyoruz.
            lbVerilerCS.Items.Clear();
        }

        private void tbVeri_TextChanged(object sender, EventArgs e)
        {
            if (rbBinary.Checked)
            {
                string kontrol = tbVeriCS.Text;
                for (int i = 0; i < kontrol.Length; i++)
                {
                    if (kontrol[i] == '0' || kontrol[i] == '1')
                    {

                    }
                    else
                    {
                        MessageBox.Show("Sadece 1 ve 0 giriniz.", "Binary Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbVeriCS.Clear();
                    }

                }
            }
        }

        private void tbVeriCRC_TextChanged(object sender, EventArgs e)
        {
            string kontrol = tbVeriCRC.Text;
            for (int i = 0; i < kontrol.Length; i++)
            {
                if (kontrol[i] == '0' || kontrol[i] == '1')
                {

                }
                else
                {
                    MessageBox.Show("Sadece 1 ve 0 giriniz.", "Binary Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbVeriCRC.Clear();
                }

            }
        }

        private void tbDivisorCRC_TextChanged(object sender, EventArgs e)
        {
            string kontrol = tbDivisorCRC.Text;
            for (int i = 0; i < kontrol.Length; i++)
            {
                if (kontrol[i] == '0' || kontrol[i] == '1')
                {

                }
                else
                {
                    MessageBox.Show("Sadece 1 ve 0 giriniz.", "Binary Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbVeriCRC.Clear();
                }

            }
        }

        private void btnHesaplaCRC_Click(object sender, EventArgs e)
        {
            if (tbVeriCRC.Text.Length != 0)
                CRC();
        }

        private void btnKotrolCRC_Click(object sender, EventArgs e)
        {
            string codeword, divisor, ilk = "0000";
            codeword = tbCodeWordCRC.Text;
            divisor = tbDivisorCRC.Text;
            int[] codeworddizi = new int[codeword.Length];
            int[] divisordizi = new int[divisor.Length];
            for (int sayac = 0; sayac < codeworddizi.Length; sayac++)
            {
                codeworddizi[sayac] = Convert.ToInt32(codeword[sayac].ToString());
                if (sayac < divisordizi.Length)
                {
                    divisordizi[sayac] = Convert.ToInt32(divisor[sayac].ToString());
                }
            }
            int basamakfarki = codeworddizi.Length - divisordizi.Length;
            int sayac1 = 0;
            bool sifir = false;
            while (sayac1 <= basamakfarki)
            {
                if (codeworddizi[sayac1] == 0)
                {
                    sifir = true;
                }
                else
                {
                    sifir = false;
                }
                for (int sayac2 = 0; sayac2 < divisordizi.Length; sayac2++)
                {
                    if (sifir == false)
                    {
                        codeworddizi[sayac1 + sayac2] = codeworddizi[sayac1 + sayac2] ^ divisordizi[sayac2];
                    }
                    else
                    {
                        codeworddizi[sayac1 + sayac2] = codeworddizi[sayac1 + sayac2] ^ 0;
                    }
                }
                sayac1 = sayac1 + 1;
            }
            for (int sayac = codeworddizi.Length - ilk.Length; sayac < codeworddizi.Length; sayac++)
            {
                tbKontrolCRC.Text += codeworddizi[sayac].ToString();
            }
        }

        private void btnHesaplaHamming_Click(object sender, EventArgs e)
        {

        }

        private void tbVeriHamming_TextChanged(object sender, EventArgs e)
        {
            string kontrol = tbVeriHamming.Text;
            for (int i = 0; i < kontrol.Length; i++)
            {
                if (kontrol[i] == '0' || kontrol[i] == '1')
                {

                }
                else
                {
                    MessageBox.Show("Sadece 1 ve 0 giriniz.", "Binary Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbVeriHamming.Clear();
                }

            }
        }

        private void btnEkleLRC_Click(object sender, EventArgs e)
        {
            if (tbVeriLRC.Text.Length < 8)
            {
                lbVeriLRC.Items.Add(tbVeriLRC.Text);
                tbVeriLRC.Clear();
            }
        }

        private void tbVeriLRC_TextChanged(object sender, EventArgs e)
        {
            string kontrol = tbVeriLRC.Text;
            for (int i = 0; i < kontrol.Length; i++)
            {
                if (kontrol[i] == '0' || kontrol[i] == '1')
                {

                }
                else
                {
                    MessageBox.Show("Sadece 1 ve 0 giriniz.", "Binary Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbVeriLRC.Clear();
                }

            }
        }

        private void btnHesaplaLRC_Click(object sender, EventArgs e)
        {
            lbLRC.Items.Clear();
            byte[] bytes = new byte[lbVeriLRC.Items.Count];
            byte b;
            for (int i = 0; i < lbVeriLRC.Items.Count; i++)
            {
                bytes[i] = Convert.ToByte(lbVeriLRC.Items[i].ToString(), 2);
                lbLRC.Items.Add(Convert.ToString(LRC(bytes), 2));
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
