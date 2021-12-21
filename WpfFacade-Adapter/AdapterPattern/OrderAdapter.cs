using System;
using System.Collections.Generic;
using System.Text;

namespace FocusTracker.AdaptorPattern
{
    public class OrderAdapter:IError
    {
        private Order _order;

        public OrderAdapter(Order order)
        {
            _order = order;
        }

        public int ErrorNumber
        {
            get { return _order.OrderErrorCode; }
            set { _order.OrderErrorCode = value; }
        }

        public string Description
        {
            get { return _order.ErrorDescription; }
            set { _order.ErrorDescription = value; }
        }

        public void SendMail()
        {
            Console.WriteLine("{0} {1} -> Sipariş hatasi alindi ", ErrorNumber.ToString(), Description);
        }
    }
}
