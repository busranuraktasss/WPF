using System;
using System.Collections.Generic;
using System.Text;

namespace InsertTextTarget
{
    public class SimpleRemoteControl
        //Invoker Sınıfımız
        //Komut sınıflarımızı bu kısımda çağırıyoruz
        //Komut nesnesini nasıl kullanacağımızı burda belirliyoruz.
    {
        ICommand text;
        public SimpleRemoteControl() { }
        public void setCommand(ICommand command)
        {
            text = command;
        }
        public void buttonWasPressed()
        {
            text.execute();
        }
    }
}
