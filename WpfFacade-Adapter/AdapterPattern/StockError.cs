using System;
using System.Collections.Generic;
using System.Text;

namespace FocusTracker.AdaptorPattern
{
    public class StockError:IError
    {
        private int _errorNumber;
        private string _description;

        public int ErrorNumber
        {
            get { return _errorNumber; }
            set { _errorNumber = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        public void SendMail()
        {
            Console.WriteLine("{0} {1} -> Ürün stokta bulunamıyor", ErrorNumber.ToString(), Description);
        }
    }
}
