using BankSimulation.Abstract;
using BankSimulation.Concrete;
using System;

namespace BankSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard1 = new CreditCard("123", "Kredi Kartı");
            creditCard1.Id = 1;
            creditCard1.FirstName = "Zekiye";
            creditCard1.LastName = "Gedik";
            creditCard1.CardNumber = "12345678945";
            creditCard1.ExpireDate = new DateTime(2024, 6, 1);
            creditCard1.CardLimit = 5000;
            creditCard1.CardType = "MasterCard";
            creditCard1.CustomerInfo();

            Console.WriteLine();
       

            DebitCard debitCard = new DebitCard("568", "Hesap Kartı");
            debitCard.Id = 3;
            debitCard.FirstName = "Semih";
            debitCard.LastName = "Gedik";
            debitCard.CardNumber = "5327263987";
            debitCard.CustomerNumber = "2536563";
            debitCard.ExpireDate = new DateTime(2029,7,1);
            debitCard.CardType = "MasterCard";
            debitCard.CustomerInfo();

            Console.WriteLine();

            //Burada Card sınıfını kalıtım verdiği VirtualCard sınıfına new'ledik. Sebebi ise Abstract sınıfları new'lenemez fakat kalıtım verdiği sınıflara new'lenebilirler.
            //Yukarıda ki diğer işlemlerde bunu yapamadık. Çünkü kendi sınıfları içerisinde de özellikleri var ve Card sınıfı üzerinden new'

            Card virtualCard = new VirtualCard("256", "Sanal Kart");
            virtualCard.Id = 2;
            virtualCard.FirstName = "Ayşe";
            virtualCard.LastName = "Yılmaz";
            virtualCard.CardNumber = "547224630154";
            virtualCard.ExpireDate = new DateTime(2024, 4, 1);
            virtualCard.CardType = "Visa";
            virtualCard.CustomerInfo();




        }

    }
}
