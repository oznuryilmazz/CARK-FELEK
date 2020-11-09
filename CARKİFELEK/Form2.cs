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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string[] resimler = {@"resim\1-01.png", @"resim\2-01.png" , @"resim\3-01.png", @"resim\4-01.png",
        @"resim\5-01.png",@"resim\6-01.png",@"resim\7-01.png",@"resim\8-01.png",@"resim\9-01.png",
        @"resim\10-01.png",@"resim\11-01.png",@"resim\12-01.png",@"resim\13-01.png",
        @"resim\14-01.png",@"resim\15-01.png",@"resim\16-01.png",@"resim\17-01.png"};

        System.Media.SoundPlayer sd = new System.Media.SoundPlayer();
        string dosya;

        public string img, nickname;

        public int deger;

        public int tutulanpuan;

        public int puan = 20;

        int sayi;

        string[] pciesorusu = { "PCI Express nedir?", "Aşağıdakilerden hangisi PCI Express tak çıkar arayüzlerindendir?", "Aşağıdakilerden hangisi PCI EXPRESS form faktörlerinden değildir?", "PCI Express sorun çözme ve gelştirme araçları nelerdir?" };
        string[] pciecevaplar = { "Bağlantı kablosudur", "Bağlantı türüdür", "İki kart arasında bağlantı sağlar", "Yüksek hızlı seri bilgisayar genişleme veriyolu standardıdır.", "ExpressCard", "Mobile PCI Express Module", "XQD card", "HEPSİ", "Yüksekliği düşük kart", "Mini kart", "AMC", "CAM", "Osiloskop", "Mantık analizörleri", "Veri yolu analizörleri", "Hepsi" };

        string[] pcisorusu = { "PCI ile ilgili hangisi yanlıştır?", "PCI ‘ın anlamı nedir?", "PCI ile ilgili hangisi yanlıştır?", "PCI veriyolu kaç bittir?" };
        string[] pcicevaplar = { "Bilgisayara harici  kartlar halinde donanım eklenmesini sağlayan bir veriyolu arabirimidir.", "Bilgisayara dahili donanım eklenmesini sağlayan bir veriyolu arabirimidir.", "Çevresel bileşen bağantısı anlamına gelir", "Entegre devreler halinde donanım eklenmesini sağlar", "Çevresel Bileşen Bağlantısı", "Çevre Bileşimi", "Bileşen Bağlantısı", "Çevreci Bileşen Bağlantısı", "Yerini PCI-Express ve AGP’ye bırakmıştır.", "Bant genişliği yeterli düzeydeydi", "Bant genişliği yeterli düzeyde değildi", "Uzun yıllarca ses ve ekran kartları için standart arabirim olarak kullanıldı.", "16bit", "32bit", "64bit", "128bit" };

        string[] islemcisorusu = { "İşlemci yuvası hakkında söylenenlerden hangisi doğrudur?", "Aşağıdakilerden hangisi mikroişlemciyi ifade etmez?", "Verilenlerden hangisi mikroişlemcinin yapısını oluşturmaz?", "32 adres hattına sahip bir işlemcinin adresleyebileceği bellek miktarı aşağıdaki seçeneklerden hangisidir?" };
        string[] islemcicevaplar = { "İşlemci yuvası etrafında çok fazla yer kaplayan elemanın olmaması gerekir.", "İşlemci yuvaları her türlü işlemciyi destekler.", "İşlemci yuvasına birden fazla işlemci takılabilir.", "Sadece soket tipi işlemci yuvası vardır.", "DSP", "MİB", "CPU", "μP", "Sinyal üretici", "İletim yolları", "Kaydedici", "Sayıcı", "4GB", "8GB", "8KB", "4MB" };

        string[] ethernetsorusu = { "Bir Ethernet kartında üretim sırasında karta yazılan ve değiştirilemeyen, başka bir eşi olmayan numaraya ne denir?", "Bilgisayarın birbirlerine veya ağa bağlanmasını sağlayan kart hangisidir?", "Aşağıdakilerden hangisi ethernet kartı portudur?", "Ethernet kartlarının sahip olduğu dünyada tekil olan ve 48 bit genişliğindeki adrese ne adresi denir?" };
        string[] ethernetcevaplar = { "MAC", "CRC", "BNC", "CSMA/CD", "Ethernet Kartı", "Ekran Kartı", "Ses Kartı", "TV Kartı", "VGA", "BNC", "DVI", "MIDI", "IP", "MAC", "DNS", "DSP" };

        string[] ramsorusu = { "RAM slotlarının fazla oluşu aşağıdakilerden hangisini sağlar?", "RAM monte edilirken aşağıdakilerden hangisine dikkat etmek gerekmez?", "Bilgiler geçici olarak hangi bellek üzerinde tutulur?", "Aşağıdakilerden hangisinde bellek birimleri küçükten büyüğe doğru sıralanmıştır?" };
        string[] ramcevaplar = { "Bilgisayarın daha hızlı çalışmasını sağlar.", "Anakart üzerinde daha fazla genişleme yuvası kullanılmasına olanak sağlar.", "Tümleşik ekran kartının daha performanslı çalışmasını sağlar.", "Daha fazla RAM eklenmesini sağlar.", "Vücutta statik elektriğe", "Kasa kablosunun takılı olmasına", "Slot rengine ", "Slota oturup oturmamasına", "Memory Card", "Hard Disk", "ROM", "RAM", "Byte- Kilobyte- Megabyte-Gigabyte", "Byte- Kilobyte- Gigabyte- Megabyte", "Gigabyte- Kilobyte- Byte- Megabyte", "Megabyte- Kilobyte- Byte- Gigabyte" };

        string[] anakartsorusu = { "Aşağıdakilerden hangisi anakartın içinde bulunmaz?", "Anakartın üzerinde haberleşmey sağlayan birimler nelerdir?", "Aşağıdakilerden hangisi günümüz anakartlarının en çok kullanılan veriyoludur?", "Aşağıdakilerden hangisi yavaş olması sebebiyle günümüz anakartlarında kullanılmayan veriyoludur?" };
        string[] anakartcevaplar = { "Yazıcı", "Ram", "Rom", "İşlemci", "Kuzey ve Güney Yolu", "Rom", "Ekran kartı", "Ses kartı", "ISA", "AGP", "PCI", "PCI-e", "PCI", "PCI-e", "AGP", "ISA" };

        string[] romsorusu = { "İç bellek kullanım amacına bağlı olarak kaça ayrılır?", "ROM hakkında hangisi doğrudur?", "ROM nedir?", "Bir kereye mahsus olarak programlanabilen ROM çeşidi aşağıdakilerden hangisidir?" };
        string[] romcevaplar = { "Ram ve Rom olmak üzere ikiye ayrılır.", "Sadece Rom olarak bir tanedir.", "Sadece Ram olarak bir tanedir.", "Ram, Rom, Cps olarak üçe ayrılır.", "Kullanıcının müdahale edebildiği bellek türüdür.", "Kullanıcının müdahale edemediği bellek türüdür.", "Elektrik kesildiği an bilgiler silinir.", "Geçici bellek olarak da tanımlanabilir.", "İç bellek türü", "İşlemci", "Hard Disk", "Yazılım", "EEPROM", "EPROM", "Flash ROM", "PROM" };

        string[] sessorusu = { "Aşağıdakilerden hangisi ses kartı bileşenidir?", "Ses ile ilgili dijital verileri depolamak için kullanılan bellek hangisidir?", "Telefon çaldığında ses modem üzerinden ses kartına hangi noktaya bağlı kablo ile ses kartına aktarılır?", "Bilgisayardaki dijital ses verileri çıkış birimlerine aktarılırken ekran kartındaki hangi çevirici bu verileri analog sinyallere dönüştürüp ses kartının çıkışına gönderir?" };
        string[] sescevaplar = { "DSP", "Tuner", "VGA portu", "BNC portu", "DDR SDRAM", "SDRAM", "RAM", "ROM", "TAD", "AUX-IN", "ADC", "DSP", "ADC", "DAC", "ASP", "TAD" };

        string[] ekransorusu = { "Aşağıdakilerden hangisi sadece ekran kartları için kullanılan veri yoludur?", "Bilgisayardaki görüntüleri ekran kartı oluşturur ve sonra hangi donanım parçasına  gönderir? ", "Ekran kartı görüntü belleğini saniye belirli sayıda tarayıp verileri alıp analog sinyallere dönüştürüp monitöre aktaran çevirici hangisidir?", "Ekran kartlarında bulunan standart monitör çıkışı hangisidir?" };
        string[] ekrancevaplar = { "PCI", "AGP", "PCI-e", "ISA", "Ses Kartı", "HDD", "Monitor", "RAM", "ADC", "DAC", "RAMDAC", "BIOS", "VGA", "GTX", "DVI", "HTMI" };

        string[] biossorusu = { "BIOS ilk ne zaman aktif olur?", "BIOS hangi tür bellekte saklanır?", "BIOS ne işe yarar?", "BIOS çipinde bulunan, başlatma bilgilerini içeren ve çok düşük güç tüketimi yapan bellek hangisidir?" };
        string[] bioscevaplar = { "Bilgisayar açıldığında", "Bilgisayar kapatıldığında", "Uyku moduna alındığında", "Bilgisayar yeniden başlatıldığında", "RAM", "ROM", "STATİKROM", "RDRAM", "İşletim sistemini yüklememizi sağlar", "Sistemler arası bağlantı kurmamızı sağlar", "Donanımlar arası bağlantı kurmamızı sağlar", "Sistem ve donanımlar arasında bağlantı kurmamızı sağlar", "CMOS", "DDRRAM", "SDRAM", "RAM" };

        string[] biospilisorusu = { "Gücünü BIOS pilinden alan bellek hangisidir?", "BIOS pili ne işe yarar?", "Hangisi BIOS pilinin görevlerinden değildir?", "Bilgisayardaki saat ayarlarını sıfırlamak istersek aşağıdakilerden hangisi yapılmalıdır?" };
        string[] biospilicevaplar = { "CMOS", "DVD", "USB", "CD", "Saat ve tarih ayarı yapar", "Geçici bilgileri hafızasında tutar", "Bilgisayarın kapanmasını sağlar", "Ethernet kartının veri ulaştırmasını sağlar", "Donanımların voltaj ve çalışma hızı bilgisi", "Donanım tanıtımı ", "Özel bios ayarlarının saklı kalması gibi önemli görevlerin yapılması", "Monitöre görüntüyü verir", "BIOS bili doğru bir şekilde çıkarılıp tekrar takılmalıdır", "BIOS pili kısmı boş bırakılmalıdır", "BIOS ayarlarından ayarlama yapılmalıdır", "Hiçbiri" };

        string[] guneysorusu = { "Aşağıdakilerden hangisi güney köprüsünün denetlediği çevre birimlerinden biri değildir?", "Aşağıdakilerden hangisi  güney köprüsünün işlevlerinden biridir?", "Aşağıdakilerden hangisi  güney köprüsünün işlevlerinden biri değildir?", "Aşağıdakilerden hangisi güney köprüsünün denetlediği çevre birimlerinden biridir?" };
        string[] guneycevaplar = { "BIOS", "AGP", "CPU", "RAM", "Chipset(Yonga Takımı)", "Sabit Disk", "Disket sürücü", "RAID", "AGP", "PCI", "USB", "ISA", "RAM", "AGP", "CPU", "USB" };

        string[] kuzeysorusu = { "Kuzey köprüsü, güney köprüsü, super I/O gibi terimler aşağıdaki kavramlardan hangisi ile ilintilidir?", "Aşağıdakilerden hangisi kuzey köprüsünün denetlediği çevre birimlerinden biridir?", "Aşağıdakilerden hangisi kuzey köprüsünün denetlediği çevre birimlerinden biri değildir?", "Kuzey köprüsünün görevi nedir?" };
        string[] kuzeycevaplar = { "Chipset(Yonga Takımı)", "Sabit Disk", "Disket sürücü", "RAID", "AGP", "PCI", "USB", "ISA", "RAM", "AGP", "CPU", "USB", "Bilgisayarın ekran kartının takıldığı portu kontrol etmektir.", "Bilgisayarın çevre birimlerini denetlemektir.", "Ses kartı portunu kontrol etmektir.", "Hiçbiri" };

        string[] satasorusu = { "eSATA hakkında söylenenlerden hangisi yanlıştır?", "SATA ile ilgili hangisi doğrudur?", "SATA VE PATA ile ilgili hangisi doğrudur?", "SATA’nın açılımı nedir?" };
        string[] satacevaplar = { "Dışarıdan bağlanacak SATA birimleri için bağlantı noktası oluşturur.", "SATA ve eSATA konnektörleri aynıdır.", "Bağlanacak kablo uzunluğu 2 metre uzunluğunda olabilir.", "USB’den daha hızlıdır.", "Bir veri taşıma teknolojisidir.", "Ekran kartı bağlantısıdır", "USB bağlantı teknolojisidir", "Sadece dahilidir, harici SATA yoktur.", "Hem SATA hem de PATA sürücüsü IDE sürücüsüdür.", "Özellikle sabit diskten ya da sabit diske veri aktarımı işlevini yerine getirir.", "İsim karışıklığı olmaması için eski ATA ismi PATA (Paralel ATA) olarak değiştirilmiştir.", "HEPSİ", "Surreal ATA", "Serial ATA", "Slider ATA", "Swap ATA" };

        string[] usbsorusu = { "Aşağıdakilerden hangisi USB çalışma modlarından  biri değildir?", "Aşağıdakilerden hangisi USB özelliklerindendir?", "Fare veya klavye gibi çok az sayıda veri gönderen cihazlar USB’nin hangi transfer modunu tercih eder?", "Yazıcı gibi büyük paketler halinde veri alan cihazlar USB’nin hangi transfer modunu kullanır?" };
        string[] usbcevaplar = { "Kesme", "Bulk", "Eşfrekanslı", "Denkfrekanslı", "Bilgisayar host gibi davranır", "127 cihaza kadar bağlantı yapılabilir", "USB cihazlar istenilen zamanda takılıp çıkarılabilir.", "Hepsi", "Kesme", "Bulk", "Eşfrekanslı", "Hiçbiri", "Kesme", "Bulk", "Eşfrekanslı", "Hiçbiri" };

        string[] atxsorusu = { "ATX, micro-ATX, Flex-ATX, NLX, WTX, LPX gibi terimler hangi bilgisayar birimi için kullanılır?", "ATX nedir?", "ATX anakartlar ile ilgili hangisi yanlıştır?", "ATX anakartlar ile ilgili hangisi doğrudur?" };
        string[] atxcevaplar = { "ses kartı", "işlemci", "bios", "anakart", "Anakart türü", "İşlemci türü", "Ram türü", "Rom türü", "ATX anakartlar, AT anakartlardan daha sonra üretilmeye başlanılan bir anakart çeşididir.", "Öncekilere nazaran çok daha fazla giriş ve çıkış bağlantı desteğine sahiptirler.", "Çeşitli donanım kartları ATX anakart çeşidiyle birlikte tümleşik yapıda kullanılmaya başlanmıştır.", "Hiçbiri", "AT anakartlardan önce üretilmiştir", "Günümüzde en çok kullanılan anakart çeşididir.", "Extra ATX çeşidi vardır.", "Öncekilerden daha az giriş çıkış bağlantı desteğine sahiptirler." };

        string[] gucsorusu = { "Aşağıdakilerden hangisi power suppyl’ın özelliklerindendir?", "Bilgisayarda güç kaynağı yetersiz olursa aşağıdakilerden hangisi ortaya çıkar?", "Türkiye şartlarında güç kaynağına gelen akım kaç volttur?", "Güç kaynağı ile ilgili aşağıdakilerden hangisi doğrudur?" };
        string[] guccevaplar = { "donanımların çalışması için gerekli olan elektrik enerjisini üreten parçadır", "AC akımı DC akıma dönüştürür.", "ATX kasa için ATX güç kaynağı gereklidir", "Hepsi", "Sistem gerektiği düzeyden düşük bir performansta çalışır", "Sistemimiz kendini başa alabilir.", "Güç kaynağımız yanabilir.", "Hepsi", "250V", "230V", "220V", "240V", "Güç kaynağının enerjisi sabittir.", "BIOS üzerinden bilgisayara güç kaynağından gelen enerjiyi kontrol edemeyiz.", "Güç kaynağımız her şartta sorunsuz çalışabilir.", "BIOS üzerinden bilgisayara güç kaynağından gelen enerjiyi kontrol edebiliriz." };


        private void Form2_Load_1(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(img);
            label3.Text = nickname;
            label2.Text = puan.ToString();

            button1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Pink;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Aqua;
            button4.BackColor = Color.Orange;
            timer1.Start();
            timer1.Interval = 50;
            button1.Enabled = true;
            button3.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.ForeColor = Color.Green;
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

                    if (sayi == 0)
                    {
                        label1.Text = atxsorusu[0];
                        button1.Text = atxcevaplar[0];
                        button2.Text = atxcevaplar[1];
                        button3.Text = atxcevaplar[2];
                        button4.Text = atxcevaplar[3];

                    }
                    else if (sayi == 1)
                    {
                        label1.Text = atxsorusu[1];
                        button1.Text = atxcevaplar[4];
                        button2.Text = atxcevaplar[5];
                        button3.Text = atxcevaplar[6];
                        button4.Text = atxcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = atxsorusu[2];
                        button1.Text = atxcevaplar[8];
                        button2.Text = atxcevaplar[9];
                        button3.Text = atxcevaplar[10];
                        button4.Text = atxcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = atxsorusu[3];
                        button1.Text = atxcevaplar[12];
                        button2.Text = atxcevaplar[13];
                        button3.Text = atxcevaplar[14];
                        button4.Text = atxcevaplar[15];
                    }
                }
                else if (deger == 2)
                {
                    pictureBox3.Image = Image.FromFile(@"kuzeygüney.png");
                    if (sayi == 0)
                    {
                        label1.Text = kuzeysorusu[0];
                        button1.Text = kuzeycevaplar[0];
                        button2.Text = kuzeycevaplar[1];
                        button3.Text = kuzeycevaplar[2];
                        button4.Text = kuzeycevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = kuzeysorusu[1];
                        button1.Text = kuzeycevaplar[4];
                        button2.Text = kuzeycevaplar[5];
                        button3.Text = kuzeycevaplar[6];
                        button4.Text = kuzeycevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = kuzeysorusu[2];
                        button1.Text = kuzeycevaplar[8];
                        button2.Text = kuzeycevaplar[9];
                        button3.Text = kuzeycevaplar[10];
                        button4.Text = kuzeycevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = kuzeysorusu[3];
                        button1.Text = kuzeycevaplar[12];
                        button2.Text = kuzeycevaplar[13];
                        button3.Text = kuzeycevaplar[14];
                        button4.Text = kuzeycevaplar[15];
                    }
                }
                else if (deger == 3)
                {
                    pictureBox3.Image = Image.FromFile(@"sata.png");
                    if (sayi == 0)
                    {
                        label1.Text = satasorusu[0];
                        button1.Text = satacevaplar[0];
                        button2.Text = satacevaplar[1];
                        button3.Text = satacevaplar[2];
                        button4.Text = satacevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = satasorusu[1];
                        button1.Text = satacevaplar[4];
                        button2.Text = satacevaplar[5];
                        button3.Text = satacevaplar[6];
                        button4.Text = satacevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = satasorusu[2];
                        button1.Text = satacevaplar[8];
                        button2.Text = satacevaplar[9];
                        button3.Text = satacevaplar[10];
                        button4.Text = satacevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = satasorusu[3];
                        button1.Text = satacevaplar[12];
                        button2.Text = satacevaplar[13];
                        button3.Text = satacevaplar[14];
                        button4.Text = satacevaplar[15];
                    }
                }
                else if (deger == 4)
                {
                    pictureBox3.Image = Image.FromFile(@"kuzeygüney.png");
                    if (sayi == 0)
                    {
                        label1.Text = guneysorusu[0];
                        button1.Text = guneycevaplar[0];
                        button2.Text = guneycevaplar[1];
                        button3.Text = guneycevaplar[2];
                        button4.Text = guneycevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = guneysorusu[1];
                        button1.Text = guneycevaplar[4];
                        button2.Text = guneycevaplar[5];
                        button3.Text = guneycevaplar[6];
                        button4.Text = guneycevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = guneysorusu[2];
                        button1.Text = guneycevaplar[8];
                        button2.Text = guneycevaplar[9];
                        button3.Text = guneycevaplar[10];
                        button4.Text = guneycevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = guneysorusu[3];
                        button1.Text = guneycevaplar[12];
                        button2.Text = guneycevaplar[13];
                        button3.Text = guneycevaplar[14];
                        button4.Text = guneycevaplar[15];
                    }
                }
                else if (deger == 5)
                {
                    pictureBox3.Image = Image.FromFile(@"pcı-e.png");
                    if (sayi == 0)
                    {
                        label1.Text = pciesorusu[0];
                        button1.Text = pciecevaplar[0];
                        button2.Text = pciecevaplar[1];
                        button3.Text = pciecevaplar[2];
                        button4.Text = pciecevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = pciesorusu[1];
                        button1.Text = pciecevaplar[4];
                        button2.Text = pciecevaplar[5];
                        button3.Text = pciecevaplar[6];
                        button4.Text = pciecevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = pciesorusu[2];
                        button1.Text = pciecevaplar[8];
                        button2.Text = pciecevaplar[9];
                        button3.Text = pciecevaplar[10];
                        button4.Text = pciecevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = pciesorusu[3];
                        button1.Text = pciecevaplar[12];
                        button2.Text = pciecevaplar[13];
                        button3.Text = pciecevaplar[14];
                        button4.Text = pciecevaplar[15];
                    }
                }
                else if (deger == 6)
                {
                    pictureBox3.Image = Image.FromFile(@"pci.png");
                    if (sayi == 0)
                    {
                        label1.Text = pcisorusu[0];
                        button1.Text = pcicevaplar[0];
                        button2.Text = pcicevaplar[1];
                        button3.Text = pcicevaplar[2];
                        button4.Text = pcicevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = pcisorusu[1];
                        button1.Text = pcicevaplar[4];
                        button2.Text = pcicevaplar[5];
                        button3.Text = pcicevaplar[6];
                        button4.Text = pcicevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = pcisorusu[2];
                        button1.Text = pcicevaplar[8];
                        button2.Text = pcicevaplar[9];
                        button3.Text = pcicevaplar[10];
                        button4.Text = pcicevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = pcisorusu[3];
                        button1.Text = pcicevaplar[12];
                        button2.Text = pcicevaplar[13];
                        button3.Text = pcicevaplar[14];
                        button4.Text = pcicevaplar[15];
                    }
                }
                else if (deger == 7)
                {
                    pictureBox3.Image = Image.FromFile(@"usb.png");
                    if (sayi == 0)
                    {
                        label1.Text = usbsorusu[0];
                        button1.Text = usbcevaplar[0];
                        button2.Text = usbcevaplar[1];
                        button3.Text = usbcevaplar[2];
                        button4.Text = usbcevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = usbsorusu[1];
                        button1.Text = usbcevaplar[4];
                        button2.Text = usbcevaplar[5];
                        button3.Text = usbcevaplar[6];
                        button4.Text = usbcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = usbsorusu[2];
                        button1.Text = usbcevaplar[8];
                        button2.Text = usbcevaplar[9];
                        button3.Text = usbcevaplar[10];
                        button4.Text = usbcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = usbsorusu[3];
                        button1.Text = usbcevaplar[12];
                        button2.Text = usbcevaplar[13];
                        button3.Text = usbcevaplar[14];
                        button4.Text = usbcevaplar[15];
                    }
                }
                else if (deger == 8)
                {
                    pictureBox3.Image = Image.FromFile(@"güc.png");
                    if (sayi == 0)
                    {
                        label1.Text = gucsorusu[0];
                        button1.Text = guccevaplar[0];
                        button2.Text = guccevaplar[1];
                        button3.Text = guccevaplar[2];
                        button4.Text = guccevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = gucsorusu[1];
                        button1.Text = guccevaplar[4];
                        button2.Text = guccevaplar[5];
                        button3.Text = guccevaplar[6];
                        button4.Text = guccevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = gucsorusu[2];
                        button1.Text = guccevaplar[8];
                        button2.Text = guccevaplar[9];
                        button3.Text = guccevaplar[10];
                        button4.Text = guccevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = gucsorusu[3];
                        button1.Text = guccevaplar[12];
                        button2.Text = guccevaplar[13];
                        button3.Text = guccevaplar[14];
                        button4.Text = guccevaplar[15];
                    }
                }
                else if (deger == 9)
                {
                    pictureBox3.Image = Image.FromFile(@"bios.png");

                    if (sayi == 0)
                    {
                        label1.Text = biossorusu[0];
                        button1.Text = bioscevaplar[0];
                        button2.Text = bioscevaplar[1];
                        button3.Text = bioscevaplar[2];
                        button4.Text = bioscevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = biossorusu[1];
                        button1.Text = bioscevaplar[4];
                        button2.Text = bioscevaplar[5];
                        button3.Text = bioscevaplar[6];
                        button4.Text = bioscevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = biossorusu[2];
                        button1.Text = bioscevaplar[8];
                        button2.Text = bioscevaplar[9];
                        button3.Text = bioscevaplar[10];
                        button4.Text = bioscevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = biossorusu[3];
                        button1.Text = bioscevaplar[12];
                        button2.Text = bioscevaplar[13];
                        button3.Text = bioscevaplar[14];
                        button4.Text = bioscevaplar[15];
                    }
                }
                else if (deger == 10)
                {
                    pictureBox3.Image = Image.FromFile(@"seskarti.png");

                    if (sayi == 0)
                    {
                        label1.Text = sessorusu[0];
                        button1.Text = sescevaplar[0];
                        button2.Text = sescevaplar[1];
                        button3.Text = sescevaplar[2];
                        button4.Text = sescevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = sessorusu[1];
                        button1.Text = sescevaplar[4];
                        button2.Text = sescevaplar[5];
                        button3.Text = sescevaplar[6];
                        button4.Text = sescevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = sessorusu[2];
                        button1.Text = sescevaplar[8];
                        button2.Text = sescevaplar[9];
                        button3.Text = sescevaplar[10];
                        button4.Text = sescevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = sessorusu[3];
                        button1.Text = sescevaplar[12];
                        button2.Text = sescevaplar[13];
                        button3.Text = sescevaplar[14];
                        button4.Text = sescevaplar[15];
                    }
                }
                else if (deger == 11)
                {
                    pictureBox3.Image = Image.FromFile(@"biospili.png");

                    if (sayi == 0)
                    {
                        label1.Text = biospilisorusu[0];
                        button1.Text = biospilicevaplar[0];
                        button2.Text = biospilicevaplar[1];
                        button3.Text = biospilicevaplar[2];
                        button4.Text = biospilicevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = biospilisorusu[1];
                        button1.Text = biospilicevaplar[4];
                        button2.Text = biospilicevaplar[5];
                        button3.Text = biospilicevaplar[6];
                        button4.Text = biospilicevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = biospilisorusu[2];
                        button1.Text = biospilicevaplar[8];
                        button2.Text = biospilicevaplar[9];
                        button3.Text = biospilicevaplar[10];
                        button4.Text = biospilicevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = biospilisorusu[3];
                        button1.Text = biospilicevaplar[12];
                        button2.Text = biospilicevaplar[13];
                        button3.Text = biospilicevaplar[14];
                        button4.Text = biospilicevaplar[15];
                    }
                }
                else if (deger == 12)
                {
                    pictureBox3.Image = Image.FromFile(@"işlemci.png");

                    if (sayi == 0)
                    {
                        label1.Text = islemcisorusu[0];
                        button1.Text = islemcicevaplar[0];
                        button2.Text = islemcicevaplar[1];
                        button3.Text = islemcicevaplar[2];
                        button4.Text = islemcicevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = islemcisorusu[1];
                        button1.Text = islemcicevaplar[4];
                        button2.Text = islemcicevaplar[5];
                        button3.Text = islemcicevaplar[6];
                        button4.Text = islemcicevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = islemcisorusu[2];
                        button1.Text = islemcicevaplar[8];
                        button2.Text = islemcicevaplar[9];
                        button3.Text = islemcicevaplar[10];
                        button4.Text = islemcicevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = islemcisorusu[3];
                        button1.Text = islemcicevaplar[12];
                        button2.Text = islemcicevaplar[13];
                        button3.Text = islemcicevaplar[14];
                        button4.Text = islemcicevaplar[15];
                    }
                }
                else if (deger == 13)
                {
                    pictureBox3.Image = Image.FromFile(@"rom.png");

                    if (sayi == 0)
                    {
                        label1.Text = romsorusu[0];
                        button1.Text = romcevaplar[0];
                        button2.Text = romcevaplar[1];
                        button3.Text = romcevaplar[2];
                        button4.Text = romcevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = romsorusu[1];
                        button1.Text = romcevaplar[4];
                        button2.Text = romcevaplar[5];
                        button3.Text = romcevaplar[6];
                        button4.Text = romcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = romsorusu[2];
                        button1.Text = romcevaplar[8];
                        button2.Text = romcevaplar[9];
                        button3.Text = romcevaplar[10];
                        button4.Text = romcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = romsorusu[3];
                        button1.Text = romcevaplar[12];
                        button2.Text = romcevaplar[13];
                        button3.Text = romcevaplar[14];
                        button4.Text = romcevaplar[15];
                    }
                }
                else if (deger == 14)
                {
                    pictureBox3.Image = Image.FromFile(@"ram.png");

                    if (sayi == 0)
                    {
                        label1.Text = ramsorusu[0];
                        button1.Text = ramcevaplar[0];
                        button2.Text = ramcevaplar[1];
                        button3.Text = ramcevaplar[2];
                        button4.Text = ramcevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = ramsorusu[1];
                        button1.Text = ramcevaplar[4];
                        button2.Text = ramcevaplar[5];
                        button3.Text = ramcevaplar[6];
                        button4.Text = ramcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = ramsorusu[2];
                        button1.Text = ramcevaplar[8];
                        button2.Text = ramcevaplar[9];
                        button3.Text = ramcevaplar[10];
                        button4.Text = ramcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = ramsorusu[3];
                        button1.Text = ramcevaplar[12];
                        button2.Text = ramcevaplar[13];
                        button3.Text = ramcevaplar[14];
                        button4.Text = ramcevaplar[15];
                    }
                }
                else if (deger == 15)
                {
                    pictureBox3.Image = Image.FromFile(@"ethernetkarti.png");

                    if (sayi == 0)
                    {
                        label1.Text = ethernetsorusu[0];
                        button1.Text = ethernetcevaplar[0];
                        button2.Text = ethernetcevaplar[1];
                        button3.Text = ethernetcevaplar[2];
                        button4.Text = ethernetcevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = ethernetsorusu[1];
                        button1.Text = ethernetcevaplar[4];
                        button2.Text = ethernetcevaplar[5];
                        button3.Text = ethernetcevaplar[6];
                        button4.Text = ethernetcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = ethernetsorusu[2];
                        button1.Text = ethernetcevaplar[8];
                        button2.Text = ethernetcevaplar[9];
                        button3.Text = ethernetcevaplar[10];
                        button4.Text = ethernetcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = ethernetsorusu[3];
                        button1.Text = ethernetcevaplar[12];
                        button2.Text = ethernetcevaplar[13];
                        button3.Text = ethernetcevaplar[14];
                        button4.Text = ethernetcevaplar[15];
                    }
                }
                else if (deger == 16)
                {
                    pictureBox3.Image = Image.FromFile(@"ekrankarti.png");

                    if (sayi == 0)
                    {
                        label1.Text = ekransorusu[0];
                        button1.Text = ekrancevaplar[0];
                        button2.Text = ekrancevaplar[1];
                        button3.Text = ekrancevaplar[2];
                        button4.Text = ekrancevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = ekransorusu[1];
                        button1.Text = ekrancevaplar[4];
                        button2.Text = ekrancevaplar[5];
                        button3.Text = ekrancevaplar[6];
                        button4.Text = ekrancevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = ekransorusu[2];
                        button1.Text = ekrancevaplar[8];
                        button2.Text = ekrancevaplar[9];
                        button3.Text = ekrancevaplar[10];
                        button4.Text = ekrancevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = ekransorusu[3];
                        button1.Text = ekrancevaplar[12];
                        button2.Text = ekrancevaplar[13];
                        button3.Text = ekrancevaplar[14];
                        button4.Text = ekrancevaplar[15];
                    }

                }
                else if (deger == 17)
                {
                    pictureBox3.Image = Image.FromFile(@"anakart-png-4.png");

                    if (sayi == 0)
                    {
                        label1.Text = anakartsorusu[0];
                        button1.Text = anakartcevaplar[0];
                        button2.Text = anakartcevaplar[1];
                        button3.Text = anakartcevaplar[2];
                        button4.Text = anakartcevaplar[3];
                    }
                    else if (sayi == 1)
                    {
                        label1.Text = anakartsorusu[1];
                        button1.Text = anakartcevaplar[4];
                        button2.Text = anakartcevaplar[5];
                        button3.Text = anakartcevaplar[6];
                        button4.Text = anakartcevaplar[7];
                    }
                    else if (sayi == 2)
                    {
                        label1.Text = anakartsorusu[2];
                        button1.Text = anakartcevaplar[8];
                        button2.Text = anakartcevaplar[9];
                        button3.Text = anakartcevaplar[10];
                        button4.Text = anakartcevaplar[11];
                    }
                    else if (sayi == 3)
                    {
                        label1.Text = anakartsorusu[3];
                        button1.Text = anakartcevaplar[12];
                        button2.Text = anakartcevaplar[13];
                        button3.Text = anakartcevaplar[14];
                        button4.Text = anakartcevaplar[15];
                    }

                }

                this.Size = new Size(780, 568);
                timer2.Start();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            if (progressBar1.Value < 40) // Burada progressbarın value değerini kontrol ettiriyoruz. Değer 100 ün altındaysa sürekli olarak 10 arttırıyoruz.
            {
                progressBar1.Value += 1;
                sd.SoundLocation = "yavassaat.wav";
                sd.Play();
            }


            if (progressBar1.Value >= 40 && progressBar1.Value < 60)
            {
                progressBar1.ForeColor = Color.Red;
                progressBar1.Value += 1;
                sd.SoundLocation = "hizlanansaat.wav";
                sd.Play();
            }
            if (progressBar1.Value >= 60) // burada progressbarın değerininin 100 olup olmadığını kontrol ediyoruz. Değer 100 olduğunda Sıfır’lıyoruz.
            {
                progressBar1.Value = 0;
                button1.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false;
                button4.Enabled = false;
                timer2.Stop();
                MessageBox.Show("Daha hızlı olmalısın! Yeniden çarkı çevir.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            timer2.Stop();
            progressBar1.Visible = false;
            if (puan >= 5)
            {
                if (deger == 1)
                {
                    if (sayi == 1)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;

                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;

                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 2)
                {
                    if (sayi == 3 || sayi == 1 || sayi == 0)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 3)
                {
                    if (sayi == 1)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 4)
                {
                    if (sayi == 3)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 5)
                {
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button1.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 6)
                {
                    if (sayi == 1)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 7)
                {
                    if (sayi == 2)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 8)
                {
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button1.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 9)
                {
                    if (sayi == 0 || sayi == 3)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 10)
                {
                    if (sayi == 0 || sayi == 2)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 11)
                {
                    if (sayi == 0 || sayi == 1 || sayi == 3)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 12)
                {
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button1.BackColor = Color.Green;
                    dosya = "dogrucevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();

                }
                else if (deger == 13)
                {
                    if (sayi == 2 || sayi == 0)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 14)
                {
                    if (sayi == 3)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                }
                else if (deger == 15)
                {
                    if (sayi == 1 || sayi == 0)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();


                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                }
                else if (deger == 16)
                {
                    if (sayi == 3)
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();


                    }
                    else
                    {
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button1.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }

                }
                else if (deger == 17)
                {
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button1.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
            }

            else
            {
                MessageBox.Show("Biraz daha çalışmalısın ;)");
            }
            label2.Text = puan.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            timer2.Stop();
            progressBar1.Visible = false;
            if (puan >= 5)
            {
                if (deger == 1)
                {
                    if (sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 2)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 3)
                {
                    if (sayi == 3 || sayi == 0)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 4)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 5)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 6)
                {
                    if (sayi == 0 || sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 7)
                {
                    if (sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 8)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 9)
                {
                    if (sayi == 1)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 10)
                {
                    if (sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 11)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 12)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 13)
                {
                    if (sayi == 1)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 14)
                {
                    button1.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button2.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 15)
                {
                    if (sayi == 2 || sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 16)
                {
                    if (sayi == 0)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 17)
                {
                    if (sayi == 0)
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Green;
                        puan += 15;
                        dosya = "dogrucevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button2.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();

                    }

                }
            }
            else
            {
                MessageBox.Show("Biraz daha çalışmalısın ;)");
            }
            label2.Text = puan.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            timer2.Stop();
            progressBar1.Visible = false;

            if (puan >= 5)
            {
                if (deger == 1)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();

                }
                else if (deger == 2)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 3)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 4)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 5)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 6)
                {
                    if (sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 7)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 8)
                {
                    if (sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 9)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 10)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 11)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 12)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 13)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 14)
                {
                    if (sayi == 1)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 15)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 16)
                {
                    if (sayi == 1 || sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button4.BackColor = Color.White;
                        button3.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 17)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
            }
            else
            {
                MessageBox.Show("Biraz daha çalışmalısın ;)");
            }
            label2.Text = puan.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            timer2.Stop();
            progressBar1.Visible = false;
            if (puan >= 5)
            {
                if (deger == 1)
                {
                    if (sayi == 0 || sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 2)
                {
                    if (sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 3)
                {
                    if (sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }
                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 4)
                {
                    if (sayi == 2 || sayi == 1 || sayi == 0)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();

                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 5)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Green;
                    puan += 15;
                    sd.SoundLocation = "dogrucevap.wav";
                    sd.Play();
                }
                else if (deger == 6)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 7)
                {
                    if (sayi == 0 || sayi == 1)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 8)
                {
                    if (sayi == 0 || sayi == 1 || sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 9)
                {
                    if (sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 10)
                {
                    if (sayi == 1)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 11)
                {
                    if (sayi == 2)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 12)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 13)
                {
                    if (sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 14)
                {
                    if (sayi == 2 || sayi == 0)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
                else if (deger == 15)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 16)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Red;
                    puan -= 5;
                    dosya = "yanliscevap.wav";
                    sd.SoundLocation = dosya;
                    sd.Play();
                }
                else if (deger == 17)
                {
                    if (sayi == 1 || sayi == 2 || sayi == 3)
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Green;
                        puan += 15;
                        sd.SoundLocation = "dogrucevap.wav";
                        sd.Play();
                    }

                    else
                    {
                        button1.BackColor = Color.White;
                        button2.BackColor = Color.White;
                        button3.BackColor = Color.White;
                        button4.BackColor = Color.Red;
                        puan -= 5;
                        dosya = "yanliscevap.wav";
                        sd.SoundLocation = dosya;
                        sd.Play();
                    }

                }
            }
            else
            {
                MessageBox.Show("Biraz daha çalışmalısın ;)");
            }
            label2.Text = puan.ToString();
        }

    }
}
