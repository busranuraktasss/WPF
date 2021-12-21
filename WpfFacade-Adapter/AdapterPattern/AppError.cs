using System;
using System.Collections.Generic;
using System.Text;

namespace FocusTracker.AdaptorPattern
{
    public class AppError:IError
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
            Console.WriteLine("{0} {1} -> Uygulama kaynaklı hata oluştu", ErrorNumber.ToString(), Description);
        }
    }
}
