using DataGridView.Forms;
using DataGridView.Standart.Manager;
using DataGridView.Standart.Memory;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Logging;
using System;
using System.Windows.Forms;



namespace DataGridView
{
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serilogSeqLoger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.Seq("http://localhost:5341", apiKey: "Jb4fLbZoMb0l0TpYcjUx")
                .CreateLogger();


            var logger = new SerilogLoggerFactory(serilogSeqLoger).CreateLogger("DataGridView");

            var storage = new MemoryApplicantStorage();
            var manager = new ApplicantManager(storage, logger);


            Application.Run(new ApplicantDataForm(manager));
        }
    }
}
