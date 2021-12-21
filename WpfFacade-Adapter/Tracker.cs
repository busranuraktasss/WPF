// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using FocusTracker.AdaptorPattern;
using FocusTracker.Facade;
using System;
using System.Windows.Automation;

namespace FocusTracker
{
    public class Tracker 
    {
        /// <summary>
        ///     Constructor.
        /// </summary>

        /// <summary>
        ///     Entry point.
        /// </summary>
        /// <param name="args">Command-line arguments; not used.</param>
        public static void Main(string[] args)
        {
            
                while (true)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("1-Adapter");
                    Console.WriteLine("2-Facade");
                    Console.WriteLine("3-Exit");
                    Console.WriteLine(" ");

                    int number;
                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            Order order = new Order { OrderErrorCode = 4000, ErrorDescription = "Sipariþ onaylanamýyor" };
                            IError[] errors = {
                      new StockError{ErrorNumber=100,Description="Kodlu Ürün" },
                            new AppError{ErrorNumber=300,Description="Giriþ saðlanamadý" },
                               new OrderAdapter(order)
                            };

                            foreach (IError error in errors)
                                error.SendMail();


                            //Console.ReadKey();
                            break;
                        case 2:
                            FacadePat fcd = new FacadePat();
                            fcd.KýtapOduncAl(new Uye { Ad = "Burak", ogrNo = "123303", UyeNumarasi = 4234242 }, 1000);

                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }

            
            



            
            
        }

        /// <summary>
        ///     Initialization.
        /// </summary>
       

        /// <summary>
        ///     Retrieves the top-level window that contains the specified
        ///     UI Automation element.
        /// </summary>
        /// <param name="element">The contained element.</param>
        /// <returns>The  top-level window element.</returns>

        /// <summary>
        ///     Handles focus-changed events. If the element that received focus is
        ///     in a different top-level window, announces that. If not, just
        ///     announces which element received focus.
        /// </summary>
        /// <param name="src">Object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
    }
}