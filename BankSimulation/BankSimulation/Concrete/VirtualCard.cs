using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSimulation.Abstract;


namespace BankSimulation.Concrete
{
    class VirtualCard : Card
    {
        public VirtualCard(string CVC, string CardName) : base(CVC, CardName)
        {
        }

        //Card sınıfında tanımladığımız CustomerInfo metodumuzu override ederek alt sınıflarda kullanmış olduk.
        public override void CustomerInfo()
        {
            Console.WriteLine(
                $"{FirstName} {LastName}; Müşterinin Kart Türü: {_cardName}, Kart Numarası: {CardNumber}, Son Kullanma Tarihi: {ExpireDate.ToString("yy MM")} CVC Kodu:{CvcCode} Kart Tipi: {CardType}"
                );
            base.CustomerInfo();
        }
    }
}
