﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace agape_rfid_mobile
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ConfigurationManager.AppSettings.Add("connString", "");
            ConfigurationManager.AppSettings.Get("connString");
            Application.Run(new OrderMD());
        }
    }
}