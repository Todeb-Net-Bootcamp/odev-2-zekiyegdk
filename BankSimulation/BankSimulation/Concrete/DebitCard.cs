using BankSimulation.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.Concrete
{
    class DebitCard : Card
    {
        //Müşteri numarası Hesap kartlarına özgü olduğu için kendi sınıfı içerisine eklendi.
        public string CustomerNumber { get; set; }
        public DebitCard(string CVC, string CardName) : base(CVC, CardName)
        {
        }
        public override void CustomerInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}; Müşterinin Kart Türü: {_cardName}, Müşteri Numarası: {CustomerNumber}, CVC Kodu: {CvcCode} ");

            base.CustomerInfo();
        }
    }
}
