using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSimulation.Abstract
{
    public abstract class Card : Customer
    {
        public string CardNumber { get; set; }       
        public DateTime ExpireDate { get; set; }
        public string CardType { get; set; }
        //CVC güvenlik kodu ve Kart ismi ilk önce private olarak işleme alındı, sonrasında bilginin diğer sınıflarda da kullanılması için protected olarak düzenlendi.
        protected string _cardName { get; set; }  
        protected string CvcCode { get; set; }

        //Bu kısımda CVC ve CardName'in kullanılması için constructor metodu ile işleme alıyoruz.
        public Card(string CVC, string CardName)
        {
            CvcCode = CVC;
            _cardName = CardName;
        }

        //CustomerInfo metodunu virtual ile manipüle ederek diğer sınıflarda kullanılmasını sağlamış olduk. 
        public virtual void CustomerInfo()
        {
        }
    }
}
