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
    public partial class Form4 : Form
    {
        public string img, nickname;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 egitim = new Form3();
            egitim.img = img;
            egitim.nickname = nickname;
            egitim.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 oyun = new Form2();
            oyun.img = img;
            oyun.nickname = nickname;
            oyun.Show();
            this.Hide();
        }

    }
}
