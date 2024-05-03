using BusinessLayer;
using DataAccessLayer.Models;
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
    public partial class Izlaz : Form
    {
        private readonly TransactionBusiness transactionBusiness;
        private readonly UserBusiness userBusiness;
        private readonly BalanceBusiness balanceBusiness;
        public Izlaz()
        {
            this.transactionBusiness = new TransactionBusiness();
            this.userBusiness = new UserBusiness();
            this.balanceBusiness = new BalanceBusiness();
            InitializeComponent();
        }



        private void Izlaz_Load(object sender, EventArgs e)
        {
            fillComboIzlaz();
        }
        //definicija dugmeta potvrdi, za unos ulaza u bazu
        private void buttonUlazPotvrdi_Click(object sender, EventArgs e)
        {
            Transaction s = new Transaction();
            s.ID = Convert.ToInt32(textBoxIzlazBroj.Text);
            s.VrstaRobe = comboBoxVrstaRobeIzlaz.SelectedItem.ToString();
            s.Datum = dateTimePickerIzlaz.Value;
            s.Kolicina = Convert.ToDecimal(textBoxKolicinaIzlaz.Text);
            s.KupacProizvodjac = comboBoxKupac.SelectedItem.ToString();
            s.OvlascenoLice = this.comboBoxOvlascenoLiceIzlaz.SelectedItem.ToString();
            s.Vrsta = "Izlaz";

            if (this.transactionBusiness.InsertTransaction(s))

                MessageBox.Show("Uspeno zaveden Izlaz!");
            textBoxIzlazBroj.Clear();
            textBoxKolicinaIzlaz.Clear();
            comboBoxVrstaRobeIzlaz.Text = string.Empty;
            comboBoxKupac.Text = string.Empty;
            comboBoxOvlascenoLiceIzlaz.Text = string.Empty;
        }
        //dugme zakretanje kroz forme
        private void buttonUlazNazad_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
        //popunjavanje combox-ova iz baze podataka
        public void fillComboIzlaz()
        {
            List<Balance> balances = this.balanceBusiness.GetBalance();
            foreach (Balance s in balances)
            {
                comboBoxVrstaRobeIzlaz.Items.Add(s.VrstaRobe);
            }
            List<User> users = this.userBusiness.GetAllUsers();
            foreach (User u in users)
            {
                if (u.Uloga == "Kupac")
                    comboBoxKupac.Items.Add(u.Ime + " " + u.Prezime);
                else if (u.Uloga == "Zaposleni")
                    comboBoxOvlascenoLiceIzlaz.Items.Add(u.Ime + " " + u.Prezime);
            }

        }
    }
}
