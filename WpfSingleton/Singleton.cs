using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FindText
{
    public class Singleton : MainWindow
    {
        private Singleton()
        {
        }
        private static Singleton instance;
        //static metodun içinde bu referansı kullanabilmemiz için static olması gerekiyor.
        //static metodun içinde sadece static metodlar kullanılabilir.
        public static Singleton Getinstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;

            
        } 
        


    }
    
}
