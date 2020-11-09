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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string img, nickname;

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;
            pictureBox1.Image = Image.FromFile(@"arkaplan2.jpg");
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font.FontFamily.Name, 12);
            button4.Font = new Font(button1.Font.FontFamily.Name, 12);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Nickname kullanmalısın :)");
            else
            {
                img = @"avatar1.png";
                nickname = textBox1.Text;
                Form4 menu = new Form4();
                menu.img = img;
                menu.nickname = nickname;
                menu.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Nickname kullanmalısın :)");
            else
            {
                img = @"avatar2.png";
                nickname = textBox1.Text;
                Form4 menu = new Form4();
                menu.img = img;
                menu.nickname = nickname;
                menu.Show();
                this.Hide();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("***Oyuna Başla diyerek oyuna ilk adımınızı atınız. \n***Oyunda kullanacağınız 'nickname'i yazdıkdan sonra kişi profilini seçiniz. \n***Gelen menüde  çarkın üzerindeki parçaların ne işe yaradağını öğrenmek için eğitim butonuna tıklayınız. \n***Çarkın üzerindeki donanım parçalarıyla ilgili soru - cevap oyununu 'oyna'ya tıklayarak oynayabilirsiniz.\n***Çarkı çevirdikten sonra 60 saniye içerisinde soruyu yanıtlamanız gerekmektedir.");
        }

    }
}
