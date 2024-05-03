using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Meni : Form
    {
        public Meni()
        {
            InitializeComponent();
        }

        private void Meni_Load(object sender, EventArgs e)
        {

        }
        //dugme za povratak na login
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var l = new Login();
            l.Closed += (s, args) => this.Close();
            l.Show();
        }
        //dugme za prelazak na formu ulaz
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var u = new Ulaz();
            u.Closed += (s, args) => this.Close();
            u.Show();
        }
        //dugme za prelazak na formu izlaz
        private void buttonMeniIzlaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var i = new Izlaz();
            i.Closed += (s, args) => this.Close();
            i.Show();
        }
    }
}
