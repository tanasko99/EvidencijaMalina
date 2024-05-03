using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPresentationLayer
{
    public partial class Stanje : System.Web.UI.Page
    {
        private readonly TransactionBusiness transactionBusiness;
        private readonly UserBusiness userBusiness;
        private readonly BalanceBusiness balanceBusiness;
        public Stanje()
        {
            this.transactionBusiness = new TransactionBusiness();
            this.userBusiness = new UserBusiness();
            this.balanceBusiness = new BalanceBusiness();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonPrikaziMiker_Click(object sender, EventArgs e)
        {
            List<Transaction> transaction = this.transactionBusiness.GetAllTransactions();
            decimal ulazUkupnoMiker = 0;
            decimal izlazUkupnoMiker = 0;
            decimal ulazUkupnoVilamet = 0;
            decimal izlazUkupnoVilamet = 0;
            decimal ukupnoVilamet = 0;
            decimal ukupnoMiker = 0;
            foreach (Transaction t in transaction)
            {
                if (t.Vrsta == "Ulaz" && t.VrstaRobe == "Vilamet")
                    ulazUkupnoVilamet += t.Kolicina;
                else if (t.Vrsta == "Izlaz" && t.VrstaRobe == "Vilamet")
                    izlazUkupnoVilamet += t.Kolicina;
                else if (t.Vrsta == "Ulaz" && t.VrstaRobe == "Miker")
                    ulazUkupnoMiker += t.Kolicina;
                else if (t.Vrsta == "Izlaz" && t.VrstaRobe == "Miker")
                    izlazUkupnoMiker += t.Kolicina;
            }
            List<Balance> balances = this.balanceBusiness.GetBalance();
            foreach (Balance b in balances)
            {
                if (b.VrstaRobe == "Miker")
                    ukupnoMiker += b.Kolicina;
                else if (b.VrstaRobe == "Vilamet")
                    ukupnoVilamet += b.Kolicina;
            }
            ukupnoVilamet = (ukupnoVilamet + ulazUkupnoVilamet) - izlazUkupnoVilamet;
            ukupnoMiker = (ukupnoMiker + ulazUkupnoMiker) - izlazUkupnoMiker;

            LabelPrikazMiker.Text = Convert.ToString(ukupnoMiker);
            LabelPrikazVilamet.Text = Convert.ToString(ukupnoVilamet);
        }
    }
}