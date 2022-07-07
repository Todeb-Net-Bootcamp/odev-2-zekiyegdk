using BankSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.Concrete
{
    public class CreditCard : Card
    {
        //Kart limiti kredi kartları için geçerli olduğundan dolayı eklenmiştir.
        public int CardLimit { get; set; }  

        public CreditCard(string CVC, string CardName) : base(CVC, CardName)
        {
        }

        public override void CustomerInfo()
        {
            Console.WriteLine($"{FirstName} {LastName};  Müşterinin Kart türü: {_cardName}, CVC Kodu: {CvcCode}, Limiti: {CardLimit}");

            base.CustomerInfo();
        }


    }
}
