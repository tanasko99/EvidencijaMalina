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
    public partial class Ulaz : Form
    {
        private readonly TransactionBusiness transactionBusiness;
        private readonly UserBusiness userBusiness;
        private readonly BalanceBusiness balanceBusiness;
        public Ulaz()
        {
            this.transactionBusiness = new TransactionBusiness();
            this.userBusiness = new UserBusiness();
            this.balanceBusiness = new BalanceBusiness();
            InitializeComponent();
        }

       

        

        private void Ulaz_Load(object sender, EventArgs e)
        {
            fillComboUlaz();
        }
        //definicija dumeta za potvrdu, ubacuje ulaze u bazu
        private void buttonUlazPotvrdi_Click(object sender, EventArgs e)
        {
            Transaction s = new Transaction();
            s.ID = Convert.ToInt32(textBoxUlazBroj.Text);
            s.VrstaRobe = comboBoxVrstaRobeUlaz.SelectedItem.ToString();
            s.Datum = dateTimePickerUlaz.Value;
            s.Kolicina = Convert.ToDecimal(textBoxKolicinaUlaz.Text);
            s.KupacProizvodjac = comboBoxProizvodjacUlaz.SelectedItem.ToString();
            s.OvlascenoLice = this.ComboBoxOvlascenoliceUlaz.SelectedItem.ToString();
            s.Vrsta = "Ulaz";

            if (this.transactionBusiness.InsertTransaction(s))

                MessageBox.Show("Uspeno zaveden Izlaz!");
            textBoxUlazBroj.Clear();
            textBoxKolicinaUlaz.Clear();
            comboBoxVrstaRobeUlaz.Text = string.Empty;
            comboBoxProizvodjacUlaz.Text = string.Empty;
            ComboBoxOvlascenoliceUlaz.Text = string.Empty;
        }
        //popunjava combobox iz baze podataka
        public void fillComboUlaz()
        {
            List<Balance> balances = this.balanceBusiness.GetBalance();
            foreach (Balance s in balances)
            {
                comboBoxVrstaRobeUlaz.Items.Add(s.VrstaRobe);
            }
            List<User> users = this.userBusiness.GetAllUsers();
            foreach (User u in users)
            {
                if (u.Uloga == "Proizvodjac")
                    comboBoxProizvodjacUlaz.Items.Add(u.Ime + " " + u.Prezime);
                else if (u.Uloga == "Zaposleni")
                    ComboBoxOvlascenoliceUlaz.Items.Add(u.Ime + " " + u.Prezime);
            }

        }
        //dugme za kretanje kroz forme
        private void buttonUlazNazad_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var m = new Meni();
            m.Closed += (s, args) => this.Close();
            m.Show();
        }
    }

}
