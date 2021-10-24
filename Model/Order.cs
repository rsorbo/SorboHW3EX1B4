using System;
using System.Net.Mail;
using HW3EX1B4.Services;
using HW3EX1B4.Utility;

namespace HW3EX1B4.Model
{
    //public class Order : Notify_Customer
    //{
    //    public void Checkout(ICart cart, PaymentDetails paymentDetails, bool notifyCustomer)
    //    {
    //        if (paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
    //        {
    //            ChargeCard(paymentDetails, cart);
    //        }

    //        if (paymentDetails.PaymentMethod == PaymentMethod.Online)
    //        {
    //            ChargeCard(paymentDetails, cart);
    //            ReserveInventory(cart);
    //            NotifyCustomer(cart);
    //        }

    //        //Cash won't need inventory handling, card charge, or customer Notification
                        
    //    }

    public class Order : Notify_Customer
    { 
        //public void Checkout(Cart cart, PaymentDetails paymentDetails, PaymentMethod creditCard)
        //{   creditCard = PaymentMethod.CreditCard;
        //    ChargeCard(paymentDetails, cart);
        //}

        //public void Checkout(Cart cart, PaymentDetails paymentDetails, PaymentMethod online, Notify_Customer notify)
        //{
        //    online = PaymentMethod.Online;
        //    ChargeCard(paymentDetails, cart);
        //    ReserveInventory(cart);
        //    NotifyCustomer(cart);
        //}



        //I tried this below after watching the Pizza Factory example in the recommended YouTube video
        public static Order CreateTransaction (PaymentMethod type)
        {
            switch (type)
            {
                case PaymentMethod.CreditCard:
                    return new Credit();
                case PaymentMethod.Online:
                    return new Online();
                default:
                    return null;
            }

        }
          
    }

    internal class Credit : Order
    {
        public void CreditTransaction(PaymentDetails paymentdetails, Cart cart)
        {
            ChargeCard(paymentDetails, cart);
        }

        public static PaymentDetails paymentDetails { get; private set; }
    }

    internal class Online : Order
    {
        public PaymentDetails paymentdetails { get; private set; }

        public void OnlineTransaction(PaymentDetails paymentdetails, Cart cart)
        {
            ChargeCard(paymentdetails, cart);
            ReserveInventory(cart);
            NotifyCustomer(cart);
        }
    }
}
