using System;
using System.Collections.Generic;
using System.Text;

namespace FocusTracker.AdaptorPattern
{
    interface IError
    {
        int ErrorNumber { get; set; }
        string Description { get; set; }
        void SendMail();
    }
}
