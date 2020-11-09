using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CARKİFELEK
{
    public partial class Form3 : Form
    {
        int sayi;
        public int deger;
        public string img, nickname;
        public Form3()
        {
            InitializeComponent();
        }
        string[] resimler = {@"resim\1-01.png", @"resim\2-01.png" , @"resim\3-01.png", @"resim\4-01.png",
        @"resim\5-01.png",@"resim\6-01.png",@"resim\7-01.png",@"resim\8-01.png",@"resim\9-01.png",
        @"resim\10-01.png",@"resim\11-01.png",@"resim\12-01.png",@"resim\13-01.png",
        @"resim\14-01.png",@"resim\15-01.png",@"resim\16-01.png",@"resim\17-01.png"};

        private void button6_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 50;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Form4 menu = new Form4();
            menu.img = img;
            menu.nickname = nickname;
            menu.Show();
            this.Hide();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(img);
            label3.Text = nickname;
            label1.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int sayac = rastgele.Next(0, 17);
            Random r = new Random();
            sayi = r.Next(0, 4);
            pictureBox1.Image = Image.FromFile(resimler[sayac]);
            timer1.Interval = timer1.Interval + 5;
            if (timer1.Interval == 200)
            {
                timer1.Stop();

                deger = sayac + 1;
                if (deger == 1)
                {
                    pictureBox3.Image = Image.FromFile(@"anakart-png-4.png");
                    label1.Text = "ATX, bir anakart türüdür. ATX, micro-ATX, Flex-ATX, NLX, WTX, LPX gibi terimler anaakrt için kullanılır. ATX anakartlar, AT anakartlardan daha sonra üretilmeye başlanılan bir anakart çeşididir. Öncekilere nazaran çok daha fazla giriş ve çıkış bağlantı desteğine sahiptirler. Çeşitli donanım kartları ATX anakart çeşidiyle birlikte tümleşik yapıda kullanılmaya başlanmıştır. Günümüzde en çok kullanılan anakart çeşididir.";


                }
                else if (deger == 2)
                {
                    pictureBox3.Image = Image.FromFile(@"kuzeygüney.png");
                    label1.Text = "Kuzey köprüsünün görevi, bilgisayarın ekran kartının takıldığı portu kontrol etmektir. Kuzey köprüsü, güney köprüsü, super I/O gibi terimler Chipset ile ilgilidir. AGP,RAM,CPU , kuzey köprüsünün denetlediği çevre birimlerindendir.";

                }
                else if (deger == 3)
                {
                    pictureBox3.Image = Image.FromFile(@"sata.png");
                    label1.Text = "SATA bir veri taşıma teknolojisidir. SATA’nın açılımı Serial ATA ‘dır. eSata dışarıdan bağlanacak SATA birimleri için bağlantı noktası oluşturur.";

                }
                else if (deger == 4)
                {
                    pictureBox3.Image = Image.FromFile(@"kuzeygüney.png");
                    label1.Text = "PCI, USB, ve ISA , BIOS  güney köprüsünün denetlediği çevre birimlerindendir. Güç yönetiminin kontrolü, AGP iletişimi düzenleme, PCI – USB portu arasındaki iletişim kontrolünü yapar.";

                }
                else if (deger == 5)
                {
                    pictureBox3.Image = Image.FromFile(@"pcı-e.png");
                    label1.Text = "PCI-E yüksek hızlı seri bilgisayar genişleme veriyolu standardıdır. ExpressCard, Mobile PCI Express Module, XQD card PCI Express’in tak çıkar arayüzlerindendir. Yüksekliği düşük kart, Mini kart, AMC PCI-E form faktörlerindendir. PCI Express sorun çözme ve geliştirme araçları osiloskop, mantık analizörleri, veri yolu analizörleridir.";
                }
                else if (deger == 6)
                {
                    pictureBox3.Image = Image.FromFile(@"pci.png");
                    label1.Text = "PCI Bilgisayara harici  kartlar halinde donanım eklenmesini sağlayan bir veriyolu arabirimidir. PCI veriyolu 64 bittir. Uzun yıllarca ses ve ekran kartları için standart arabirim olarak kullanılmıştır. “Çevresel bileşen bağlantısı” anlamına gelir. Entegre devreler halinde donanım eklenmesini sağlar. Bant genişliği yeterli düzeyde değildi. Bu yüzden yerini PCI-Express ve AGP’ye bırakmıştır.";
                }
                else if (deger == 7)
                {
                    pictureBox3.Image = Image.FromFile(@"usb.png");
                    label1.Text = "USB cihazlar istenilen zamanda takılıp çıkarılabilir. USB cihazlar istenilen zamanda takılıp çıkarılabilir. Bilgisayar host gibi davranır. Fare veya klavye gibi çok az sayıda veri gönderen cihazlar USB’nin ”kesme“ transfer modunu tercih eder. Yazıcı gibi büyük paketler halinde veri alan cihazlar USB’nin bulk transfer modunu kullanır.";

                }
                else if (deger == 8)
                {
                    pictureBox3.Image = Image.FromFile(@"güc.png");
                    label1.Text = "Power Supply, donanımların çalışması için gerekli olan elektrik enerjisini üreten parçadır. AC akımı DC akıma dönüştürür. ATX kasa için ATX güç kaynağı gereklidir. Türkiye şartlarında güç kaynağına gelen akım 220 volttur. BIOS üzerinden bilgisayara güç kaynağından gelen enerjiyi kontrol edebiliriz.";
                }
                else if (deger == 9)
                {
                    pictureBox3.Image = Image.FromFile(@"bios.png");
                    label1.Text = "BIOS sistem ve donanımlar arasında bağlantı kurmamızı sağlar. BIOS bilgisayar açıldığında aktif olur ve ROM bellekte saklanır. BIOS çipinde bulunan, başlatma bilgilerini içeren ve çok düşük güç tüketimi yapan bellek CMOS’tur.";
                }
                else if (deger == 10)
                {
                    pictureBox3.Image = Image.FromFile(@"seskarti.png");
                    label1.Text = "Ses ile ilgili dijital verileri depolamak için kullanılan bellek ROM’dur.  Telefon çaldığında ses modem üzerinden ses kartına TAD noktasına bağlı kablo ile ses kartına aktarılır. Bilgisayardaki dijital ses verileri çıkış birimlerine aktarılırken ekran kartındaki DAC bu verileri analog sinyallere dönüştürüp ses kartının çıkışına gönderir. DSP bir ses kartı bileşenidir.";

                }
                else if (deger == 11)
                {
                    pictureBox3.Image = Image.FromFile(@"biospili.png");
                    label1.Text = "Gücünü BIOS pilinden alan bellek CMOS’tur. Saat ve tarih ayarı yapar. Bilgisayardaki saat ayarlarını sıfırlamak istersek, BIOS bili doğru bir şekilde çıkarılıp tekrar takılmalıdır.";
                }
                else if (deger == 12)
                {
                    pictureBox3.Image = Image.FromFile(@"işlemci.png");
                    label1.Text = "Mikroişlemciyi ifade eden terimler şunlardır: MİB, CPU, μP. İletim yolları, kaydedici ve sayıcı ,işlemcinin yapısını oluşturur. 32 adres hattına sahip bir işlemcinin adresleyebileceği bellek miktarı 4GB’dir. İşlemci yuvası etrafında çok fazla yer kaplayan elemanın olmaması gerekir.";
                }
                else if (deger == 13)
                {
                    pictureBox3.Image = Image.FromFile(@"rom.png");
                    label1.Text = "İç bellek kullanım amacına bağlı olarak RAM ve ROM olmak üzere ayrılır. Kullanıcının müdahale edemediği bellek türüdür. EEPROM,,EPROM,PROM gibi çeşitleri bulunur. Örneğin, bir kereye mahsus olarak programlanabilen ROM çeşidi PROM’dur.";

                }
                else if (deger == 14)
                {
                    pictureBox3.Image = Image.FromFile(@"ram.png");
                    label1.Text = "Bilgilerin geçici olarak tutulduğu bellek RAM’dir.  Bellek birimleri küçükten büyüğe doğru sıralanışı Byte- Kilobyte- Megabyte-Gigabyte’tır. RAM slotlarının fazla oluşu daah fazla RAM eklenmesini sağlar. RAM monte edilirken vücutta statik elektriğe,kasa kablosunun takılı olmamasına,slota oturup oturmamasına dikkat edilmelidir.";
                }
                else if (deger == 15)
                {
                    pictureBox3.Image = Image.FromFile(@"ethernetkarti.png");
                    label1.Text = "Bilgisayarın birbirlerine veya ağa bağlanmasını sağlayan kart Ethernet kartıdır. Bir Ethernet kartında üretim sırasında karta yazılan ve değiştirilemeyen, başka bir eşi olmayan numaraya MAC adresi denir. Ethernet kartı portu BNC’dir.";
                }
                else if (deger == 16)
                {
                    pictureBox3.Image = Image.FromFile(@"ekrankarti.png");
                    label1.Text = "AGP sadece ekran kartları için kullanılan veri yoludur. Bilgisayardaki görüntüleri ekran kartı oluşturur ve sonra montitöre  gönderir. Ekran kartı görüntü belleğini saniye belirli sayıda tarayıp verileri alıp analog sinyallere dönüştürüp monitöre aktaran çevirici RAMDAC’tir. Ekran kartlarında bulunan standart monitör çıkışı VGA’dır.";
                }
                else if (deger == 17)
                {
                    pictureBox3.Image = Image.FromFile(@"anakart-png-4.png");
                    label1.Text = "Anakart bütün donanımlar anakart portlarına, soketlerine, slotlarına, konnektörlerine göre tasarlanır. Günümüz anakartlarında en çok kullanılan veriyolu PCI-E’dir. ISA, yavaş olması sebebiyle günümüz anakartlarında kullanılmayan veriyoludur. Anakart üzerinde yer alan parçalara örnek olarak chipset,bellek ve işlemciyi verebiliriz.";
                }
                this.Size = new Size(780, 568);
                pictureBox4.Location = new Point(687, 35);

                label1.Visible = true;
            }
        }

    }
}
