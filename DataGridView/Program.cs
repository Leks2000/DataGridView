﻿using Manager;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace DataGridView
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var factory = LoggerFactory.Create(builder => builder.AddDebug());
            var logger = factory.CreateLogger(nameof(DataGrid));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var storage = new MemoryApplicantStorage();
            var manager = new ApplicantManager(storage, logger);

            Application.Run(new ApplicantDataForm());
        }
    }
}
